using InternetApplicationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetApplicationProject.Controllers
{
    public class CustomerController : Controller
    {
        


        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddProjectForm()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ListProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ListProject(Project project)
        {
            var proj = db.Project.Tolist();
            return View();
        }
    }
}