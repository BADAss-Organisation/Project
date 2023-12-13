using Microsoft.AspNetCore.Mvc;
using WannaBuy.Data;

namespace WannaBuy.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ApplicationController(ApplicationDbContext dbContext)
        {
            this.applicationDbContext = dbContext;
        }
       //[HttpGet]
       //public async Task<IActionResult>Add()
       // {
           
       // }
    }
}
