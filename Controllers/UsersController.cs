using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsersViewer.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            var users = new API.UsersController().GetUsers();
            return View(users.Data);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details()
        {
            try
            {
                Int64 id = Int64.Parse(Request.QueryString["userID"]);
                var user = new API.UsersController().GetUserById(id);
                return View(user.Data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult Edit()
        {
            try
            {
                Int64 id = Int64.Parse(Request.QueryString["userID"]);
                var user = new API.UsersController().GetUserById(id);
                return View(user.Data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult Delete()
        {
            try
            {
                Int64 id = Int64.Parse(Request.QueryString["userID"]);
                new API.UsersController().DeleteUser(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}