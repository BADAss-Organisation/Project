using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WannaBuy.Data;
using WannaBuy.Models.Entities;
using WannaBuy.ViewModels.Application;

namespace WannaBuy.Controllers
{
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
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EachProduct (int id)
        {
            return View("EachProductView");
        }
    }
}
