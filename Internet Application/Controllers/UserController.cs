using Internet_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Internet_Application.Controllers
{
    public class UserController : Controller
    {
        // No lo entiendo muy bien, ejercicio 2.2
        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        // Create User y guardar los tipos en la variable usu.UserTypes
        public ActionResult Edit()
        {
            var usu = new UserViewModel();

            usu.Birthdate = DateTime.Now;
            ViewBag.UserTypes = UserType.GetUserTypes();

            return View(usu);
        }

        //Validacion
        [HttpPost]
        public ActionResult Edit(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                user.UserTypes = UserType.GetUserTypes();
                return View(user);

            }
            return Content("ok");
        }

        public JsonResult UsernameAvailable(string userName)
        {
            return Json(!_userRepository.Exists(userName), JsonRequestBehavior.AllowGet);
        }

        // GET: User
        /*public ActionResult Index()
        {
            return View();
        }*/

      


    }


}
