using Microsoft.AspNetCore.Mvc;

namespace PackBook.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorldController
        public ActionResult Index()
        {
            return View();
        }

    }
}
