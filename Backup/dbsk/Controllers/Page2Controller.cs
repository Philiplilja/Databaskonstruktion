using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dbsk7.Controllers
{
    public class Page2Controller : Controller
    {
        //
        // GET: /Page2/

        public ActionResult Index()
        {
            return View(new dbsk7.Models.StudyProgramModel().GetAllStudyPrograms());
        }

    }
}
