using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taska_DataAccess.Repository.UserConfiguration;
using Taska_DomainModel.UserConfiguration;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace TaskaApp.Controllers.UserConfiguration
{
    public class UserConfigurationController : Controller
    {
        #region Extension

        UserConfigurationRepository repo = new UserConfigurationRepository();

        #endregion


        public ActionResult Login()
        {
            return View();
        }
        public ActionResult UserRegister()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        public JsonResult login (UserRegister logindata) 
        {
            return Json(data:logindata);
        }

        [HttpPost]
        public ActionResult User_Register(UserRegister data)
        { 
            if(ModelState.IsValid) 
            {
                ViewBag.registmesaage = "data Created Successfull!";
                return View("UserRegister"); 
            }
            else { return View(); }    
            
        }
    }
}