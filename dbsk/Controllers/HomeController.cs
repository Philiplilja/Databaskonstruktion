using System.Web.Mvc;

namespace dbsk7.Controllers
{
    public class HomeController : Controller
    {

        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.SomeText = "Welcome to PUCKO";
            return View(); 
        }

    }
}
