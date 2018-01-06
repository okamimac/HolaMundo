﻿using HolaMundo.DAL;
using HolaMundo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolaMundo.Controllers
{
    public class HomeController : Controller
    {
        private PeliculasRepository _peliculasRepository;

        public HomeController()
        {
            _peliculasRepository = new PeliculasRepository();
        }

        public ActionResult Index()
        {
             return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Página acerca de";

            return View();
        }

        [ChildActionOnly]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }

        public ActionResult Grafica()
        {
            return View();
        }
    }
}