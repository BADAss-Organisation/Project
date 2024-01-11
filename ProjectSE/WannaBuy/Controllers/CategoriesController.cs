using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WannaBuy.Data;

namespace WannaBuy.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext context;
        public CategoriesController(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Accessories()
        {
            var acc = await context.Products.Where(x=>x.Category.Name == "Accessories").ToListAsync(); 
            return View(acc);
        }
        [HttpGet]
        public async Task<IActionResult> HomeAndGarden()
        {
            var hag = await context.Products.Where(x => x.Category.Name == "HomeAndGarden").ToListAsync();
            return View(hag);
        }
        [HttpGet]
        public async Task<IActionResult> Auto()
        {
            var auto = await context.Products.Where(x => x.Category.Name == "Auto").ToListAsync();
            return View(auto);
        }
        [HttpGet]
        public async Task<IActionResult> Technologies()
        {
            var tech = await context.Products.Where(x => x.Category.Name == "Technologies").ToListAsync();
            return View(tech);
        }
        [HttpGet]
        public async Task<IActionResult> Office()
        {
            var off = await context.Products.Where(x => x.Category.Name == "OfficeAndWork").ToListAsync();
            return View(off);
        }
        [HttpGet]
        public async Task<IActionResult> Sport()
        {
            var sah = await context.Products.Where(x => x.Category.Name == "SportAndHobby").ToListAsync();
            return View(sah);
        }
        [HttpGet]
        public async Task<IActionResult> Services()
        {
            var ser = await context.Products.Where(x => x.Category.Name == "Services").ToListAsync();
            return View(ser);
        }
        [HttpGet]
        public async Task<IActionResult> Others()
        {
            var oth = await context.Products.Where(x => x.Category.Name == "Others").ToListAsync();
            return View(oth);
        }

    }
}
