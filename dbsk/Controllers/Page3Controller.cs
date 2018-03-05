using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dbsk7.Models;

namespace dbsk7.Controllers
{
    public class Page3Controller : Controller
    {

        private StudentsModel sm = new StudentsModel("wwwlab.iki.his.se-dbsk");
        private StudyProgramModel sp = new StudyProgramModel();

        //
        // GET: /Page3/

        public ActionResult Index()
        {
            ViewBag.AllStudyProgramsTable = sp.GetAllStudyPrograms();
            return View();
        }

        //
        // GET: /Home/SearchStudents/{name}?studyProgram={studyProgram}

        public ActionResult SearchStudents(string name, string studyProgram)
        {
            ViewBag.SearchResults = sm.SearchStudents(name, studyProgram);
            return View();
        }

    }
}

