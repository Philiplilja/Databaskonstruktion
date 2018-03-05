using System.Web.Mvc;

namespace dbsk7.Controllers
{
    public class HomeController : Controller
    {

        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.SomeText = "Some text passed from the controller using the ViewBag";
            return View(); 
        }

    }
}
