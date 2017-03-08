using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using V3EventManagement.Models;

namespace V3EventManagement.Controllers
{
    public class LoginController : Controller
    {
         EventManagementEntities1 db = new EventManagementEntities1();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Check(tblUser user)
        {
            if (ModelState.IsValid)
            {
                var result = (from userlist in db.tblUsers
                              where userlist.Username == user.Username && userlist.Password == user.Password
                              select new
                              {
                                  userlist.UserID,
                                  userlist.Username
                              }).ToList();
                if(result.FirstOrDefault()!=null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else throw new Exception("Please enter Valid Credentials");

            }
            else return View("Index");
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

