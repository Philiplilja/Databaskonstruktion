using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dbsk7.Models;

namespace dbsk7.Controllers
{
    public class Page6Controller : Controller
    {

        private StudentsModel sm = new StudentsModel("wwwlab.iki.his.se-dbsk");
        private StudyProgramModel sp = new StudyProgramModel();

        //
        // GET: /Page6/

        public ActionResult Index()
        {
            ViewBag.DangerTable = sp.GetAllDanger();
            return View(new dbsk7.Models.StudyProgramModel().GetAllAliens());

        }

        public ActionResult UpdateDanger(string ID, int Danger)
        {
            sp.UpdateDanger(ID, Danger);
            return RedirectToAction("Index");
        }

    }
}
