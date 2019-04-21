using InternetApplicationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternetApplicationProject.Models;

namespace InternetApplicationProject.Controllers
{
    public class CustomerController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        //DefaultConnection db = new DefaultConnection(); 

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
        
        public ActionResult ListProject()
        {
            var proj = db.Projects.ToList();
            return View(proj);
        }
    }
}