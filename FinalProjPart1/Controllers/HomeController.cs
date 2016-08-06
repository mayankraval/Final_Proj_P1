﻿/** Authors & Student Number:
    Mayank Raval 200300508
    Fei Wang 200278460
    Mayank Bhardwaj 200305245    
    Siqian Yu 200286902
    Date Modified: 08-05-2016
    File Description: This is the controller for home page, contact page, and about page. 
    **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjPart1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}