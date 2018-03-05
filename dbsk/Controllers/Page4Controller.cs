using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dbsk7.Models;

namespace dbsk7.Controllers
{
    public class Page4Controller : Controller
    {

        private StudentsModel sm = new StudentsModel("wwwlab.iki.his.se-dbsk");
        private StudyProgramModel sp = new StudyProgramModel();

        //
        // GET: /Page4/

        public ActionResult Index()
        {
            return View(new dbsk7.Models.StudyProgramModel().GetAllAliens());
        }

        public ActionResult DeleteAlien(string ID, string RaceName)
        {
            sp.DeleteAlien(ID,RaceName);
            return RedirectToAction("Index");
        }
    }
}
