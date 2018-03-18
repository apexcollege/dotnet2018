using ecommerce.app;
using ecommerce.data;
using ecommerce.ui.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecommerce.ui.web.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentModel student)
        {
            StudentApp app = new StudentApp();

            //save to database
            Student s = new Student();
            s.Name = student.Name;
            s.RollNo = student.RollNo;
            s.EnrolDate = student.EnrolDate;
            s.Grade = student.Grade;
            s.Active = student.Active;

            bool success = app.CreateStudent(s);
            //show result
            if (success == true)
                return RedirectToAction("Success");
            else
                return RedirectToAction("Fail");
        }
        public ActionResult Success()
        {
            //not sending any message from controller
            //to view
            return View();
        }
        public ActionResult Fail()
        {
            //sending message from controller
            //to view
            ViewBag.Abc = "Failed to create student";
            return View();
        }
    }
}