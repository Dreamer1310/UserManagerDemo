using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersViewer.Repository.DTO;
using UsersViewer.Repository.Users;

namespace UsersViewer.API
{
    public class UsersController : Controller
    {
        private readonly IUsersRepo _repository;

        public UsersController()
        {
            _repository = new MyUsersRepo();
        }


        [HttpGet]
        public JsonResult GetUsers()
        {
            return Json(_repository.GetUsers(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetUserById(Int64 userID)
        {
            try
            {
                return Json(_repository.GetUserById(userID), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            { 
                return Json(new
                {
                    Message = "User Not Found.",
                    Source = ex.Message
                });
            }
           
        }

        [HttpDelete]
        public JsonResult DeleteUser(Int64 userID)
        {
            try
            {
                return Json(_repository.DeleteUser(userID));
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Message = "Couldn't delete user or doesn't exist.",
                    Source = ex.Message
                });
            }

            
        }

        [HttpPost]
        public JsonResult CreateUser(UserWriteDto userDto)
        {
            return Json(_repository.CreateUser(userDto));
        }

        [HttpPost]
        public JsonResult EditUser(UserReadDto userDto)
        {
            try
            {
                return Json(_repository.EditUser(userDto));
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Message = "Couldn't edit of find user.",
                    Source = ex.Message
                });
            }
        }

    }
}