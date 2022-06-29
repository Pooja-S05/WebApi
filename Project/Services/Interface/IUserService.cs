using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Services.Interface
{
    public interface IUserService
    {
        public bool CreateUser(User user);
    }
}