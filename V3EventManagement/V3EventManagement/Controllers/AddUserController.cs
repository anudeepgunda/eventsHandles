using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using V3EventManagement.Models;

namespace V3EventManagement.Controllers
{
    public class AddUserController : Controller
    {
        // GET: AddUser
        public ActionResult Index()
        {
            return RedirectToAction("Index","Home");
        }


        public ActionResult AddUsers(AddUserViewModel ViMo)
        {
            EventManagementEntities1 dbobj = new EventManagementEntities1();
           // UserDetailsViewModel ViMo = new UserDetailsViewModel();
            try
            {
                
                            if (ModelState.IsValid)
                            {
                                var lst1 = new List<tblUser>
                            {
                                new tblUser {
                                    UserID=ViMo.UserID,
                                    Username =ViMo.Username,
                                Password = ViMo.Password,
                                Role = ViMo.Role
                                
                            }
                            };
                                
                                lst1.ForEach(s => dbobj.tblUsers.Add(s));
                                //dbobj.Users.Add(user);
                               //dbobj.SaveChanges();

                                //var UID = (from id in dbobj.tblUsers
                                //           where id.Username == ViMo.Username 
                                //    select new { id.UserID } ).FirstOrDefault();

                                //int Userid = Convert.ToInt32(UID);
                                var lst2 = new List<tblUserDetail>
                            {
                                new tblUserDetail {
                                    UserID=ViMo.UserID,
                                    //UserID = Userid,
                                    FirstName =ViMo.FirstName,
                                LastName = ViMo.LastName,
                                Email = ViMo.Email,
                                Contact= ViMo.Contact,
                                Address =ViMo.Address

                            }
                            };
                                lst2.ForEach(r => dbobj.tblUserDetails.Add(r));
                                //dbobj.Users.Add(user);
                                dbobj.SaveChanges();

                                return RedirectToAction("AddUserView");

                            }
                     
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View("AddUserView");

        }
    }
}