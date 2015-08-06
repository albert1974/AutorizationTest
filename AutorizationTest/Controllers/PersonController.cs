using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutorizationTest.Models;

namespace AutorizationTest.Controllers
{
    public class PersonController : Controller
    {
        private PersonManagerDataContext mDataContext;


        public PersonController()
        {

            mDataContext = new PersonManagerDataContext();

        }

        // GET: Person
        public ActionResult Index()
        {
            ViewBag.MyHeader = "Основная информация";

            return View(mDataContext.Persons);
//            return View();
        }
    }
}