using Microsoft.AspNetCore.Mvc;
using WannaBuy.Data;
using WannaBuy.Models.Entities;

namespace WannaBuy.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext context;
        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Order()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Order(Order order)
        {
            return View();
        }
    }
}
