using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dbsk7.Models;

namespace dbsk7.Controllers
{
    public class Page5Controller : Controller
    {

        private StudentsModel sm = new StudentsModel("wwwlab.iki.his.se-dbsk");
        private StudyProgramModel sp = new StudyProgramModel();

        //
        // GET: /Page5/

        public ActionResult Index()
        {
            ViewBag.DangerTable = sp.GetAllDanger();
            return View(new dbsk7.Models.StudyProgramModel().GetAllAliens());

        }

        public ActionResult InsertAlien(string ID, string RaceName, string Color, int Danger)
        {
            sp.InsertAlien(ID,RaceName,Color, Danger);
            return RedirectToAction("Index");
        }

    }
}