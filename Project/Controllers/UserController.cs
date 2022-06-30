using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;
using Project.Services.Interface;

namespace Project.Controllers
{
   [ApiController]
    [Route("[controller]/[Action]")]

    public class UserController:Controller
    {
        private IUserService _UserService; 
        
        public UserController(IUserService userService)
        {
            _UserService=userService;
        }


        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            
            return  _UserService.CreateUser(user)? Ok("Successfully Created"):BadRequest("Error Occured While Creating User");
        }
    }
}