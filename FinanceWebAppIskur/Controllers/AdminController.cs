﻿using FinanceWebAppIskur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinanceWebAppIskur.Controllers
{
   
    public class AdminController : Controller
    {

        // Database/VeriTabanı
        DataContext db = new DataContext();


        // GET: Admin
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {                  
            //Permission permission = new Permission();
            //permission.Name = "Project Lider";
            //permission.Description = "Package Lider in Anatolia";            
            //permission.Status = false;
            //permission.Delete = false;
            //db.Permission.Add(permission);
            //db.SaveChanges();

            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
                   
            return View();
        }


        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(User user, string passwordr)
        {


            if (user.Password == passwordr)
            {

                db.User.Add(user);
                db.SaveChanges();


            }





            return View();
        }







    }
}