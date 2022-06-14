using Project_Management.Models.DataManager;
using System;
using System.Web.Mvc;

namespace Project_Management.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginManager p_model)
        {

            string userType = null;
            if (ModelState.IsValid)
            {
                try
                {
                    LoginManager loginManager = new LoginManager();
                    userType = loginManager.ValidateUser(p_model);
                    switch (userType)
                    {
                        case "Admin":
                            return AdminRedirectToLocal();
                        case "Employee":
                            return EmployeeRedirectToLocal();
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                ModelState.AddModelError("", "Please Enter LoginID and Password");
            }
            return View(p_model);
        }

        private ActionResult AdminRedirectToLocal()
        {
            return Redirect("~/Admin/Index");
        }
        private ActionResult EmployeeRedirectToLocal()
        {
                return Redirect("~/Employee/Index");            
        }
    }
}