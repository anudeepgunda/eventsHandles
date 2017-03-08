using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using V3EventManagement.Models;

namespace V3EventManagement.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        EventManagementEntities1 db = new EventManagementEntities1();
        tblUser user = new tblUser();
       // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(tblUser model)
        {
            if (model.Username == user.Username && model.Password == user.Password)
            {
                return View("Index");
            }
            else return View("Login");
            
        }
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        // GET: /Account/ForgotPassword
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return View();
        }
    }
}