using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WannaBuy.Controllers
{
    public class CategoriesController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Accessories()
        {
            return View();
        }
        [HttpGet]
        public ActionResult HomeAndGarden()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Auto()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Technologies()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Office()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Sport()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Services()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Others()
        {
            return View();
        }

    }
}
