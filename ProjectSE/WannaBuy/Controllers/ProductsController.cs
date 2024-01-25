using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WannaBuy.Data;
using WannaBuy.Models.Entities;
using WannaBuy.ViewModels.Application;
using WannaBuy.ViewModels.Product;

namespace WannaBuy.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ProductsController(ApplicationDbContext dbContext)
        {
            this.applicationDbContext = dbContext;
        }
       [HttpGet]
       public IActionResult Add()
        {
            ViewBag.CategoryId = new SelectList(applicationDbContext.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]  
        public async Task<IActionResult> Add(AddApplicationViewModel model)
        {
            var product = new Product()
            {
                Name = model.Name,
                Price = model.Price,
                Amount = model.Amount,
                Description = model.Description,
                Image = model.Image,
            };
            await applicationDbContext.AddAsync(product);
            await applicationDbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Categories");
        }

        [HttpGet]
        public async Task<IActionResult> EachProduct (Guid id)
        {
            var product = await applicationDbContext.Products.FindAsync(id);
            return View("EachProductView", product);
        }

        [HttpGet]
        public async Task<IActionResult> Buy(Guid id)
        {
            var product = applicationDbContext.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                return await Task.Run(() => View("Order", product));
            }
            return RedirectToAction("Confirmation", "Order");
        }
        [HttpPost]
        public async Task<IActionResult> Buy(BuyProductViewModel viewModel)
        {
            var product = await applicationDbContext.Products.FindAsync(viewModel.Id);
            if (product != null)
            {
                applicationDbContext.Products.Remove(product);

                await applicationDbContext.SaveChangesAsync();
                return RedirectToAction("Confirmation", "Order");
            }
            return RedirectToAction("Confirmation", "Order");
        }
    }
}
