using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Project_Management.Models.DataManager;
using Project_Management.Models.Objects;
using System.Linq;

namespace Project_Management.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            List<Projects> projects = new List<Projects>();
            try
            {
                ProjectManager projectManager = new ProjectManager();
                projects = projectManager.GetAllProjects();

            }
            catch (Exception ex)
            {

            }
            return View(projects);
        }

        public ActionResult GetTasks()
        {
            List<Tasks> lstTasks = new List<Tasks>();
            try
            {
                TaskManager taskManager = new TaskManager();
                lstTasks = taskManager.GetAllTasks();

            }
            catch (Exception ex)
            {

            }
            return View(lstTasks);
        }

        public ActionResult GetUsers()
        {
            List<User> lstUser = new List<User>();
            try
            {
                UserManager userManager = new UserManager();
                lstUser = userManager.GetAllUsers();

            }
            catch (Exception ex)
            {

            }
            return View(lstUser);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Estimate(int id)
        {
            Projects pro = new Projects();
            try
            {
                List<Projects> projects = new List<Projects>();
                ProjectManager prm = new ProjectManager();
                projects = prm.GetAllProjects();

                pro = projects.Where(p => p.id == id.ToString()).FirstOrDefault();

                ModelState.AddModelError("", "The Project Estimated End time is" + pro.estimateTime);

            }
            catch (Exception ex)
            {

            }
            return View(pro);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
