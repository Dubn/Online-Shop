using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Online_Shop.Models;
using Online_Shop.ViewModels;

namespace Online_Shop.Controllers
{
    public class UserManagmentController : Controller
    {
        //dependency injection
        private readonly OnlineShopContext _dbContext;

        public UserManagmentController(OnlineShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var vm = new UserManagmentIndexViewModel {
                Users = _dbContext.Users.OrderBy(u => u.Country).ToList()
            };
            return View(vm);
        }
    }
}