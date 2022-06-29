using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services.Interface;

namespace Project.Controllers
{
   [ApiController]
    [Route("[controller]/[Action]")]

    public class UserController:Controller
    {
        
        public UserController()
        {
            
        }


        [HttpPost]
        public ActionResult CreateUser(User user)
        {
               
            return  BadRequest("Successfully Created");
        }
    }
}