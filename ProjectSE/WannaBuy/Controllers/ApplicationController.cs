using Microsoft.AspNetCore.Mvc;
using WannaBuy.Data;

namespace WannaBuy.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ApplicationController(ApplcationDbContext dbContext)
        {
            this.applicationDbContext = dbContext;
        }
       [HttpGet]
       public async Task<IActionResult>Add()
        {
           
        }
    }
}
