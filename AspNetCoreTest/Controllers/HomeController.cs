using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTest.Models;
using AspNetCoreTest.Services;
using AspNetCoreTest.Repository;

namespace AspNetCoreTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<User> _users;
        private readonly IRepository<Order> _orders;
        private readonly IUserService _userService;

        public HomeController(IRepository<User> users, 
                              IRepository<Order> orders,
                              IUserService userService)
        {
            this._users = users;
            this._orders = orders;
            this._userService = userService;
        }


        #region Basic ActionResults
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion

        public IActionResult GetRecords()
        {
            return View(_users.Get());
        }

        //Test Web Component 
        public IActionResult PageWithOrders()
        {
            return View();
        }

        #region CRUD_Area

        public IActionResult RecordsPage()
        {
            return  View();
        }

        [ActionName("GetRecord")]
        [HttpPost]
        public IActionResult RecordsPage(int user_id)
        {
            _users.Get().Where(a=>a.Id == user_id).FirstOrDefault();
            return View("RecordsPage");
        }

        [ActionName("AddRecord")]
        [HttpPost]
        public IActionResult RecordsPage(User user)
        {
            _users.Insert(user);
            return View("RecordsPage");
        }

        [HttpPost]
        //[Route("asd")]
        [ActionName("RemoveRecord")]
        public IActionResult RecordsPage(int user_id)
        {         
            return View("RecordsPage", _userService.GetUserById(user_id));
        }

        [HttpPost]
        [ActionName("UpdateRecord")]
        public IActionResult RecordsPage(int user_id)
        {
            User _user = _userService.GetUserById(user_id);
            _users.Update(_user);
            return View("RecordsPage");
        }
        #endregion

        #region Web_Components
        //Test Invoke Async
        #endregion
    }
}
