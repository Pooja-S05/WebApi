using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;

namespace Project.DataAccessLayer.Interface
{
    public interface IUserRepository
    {
        public bool CreateUser(User user);
    }
}