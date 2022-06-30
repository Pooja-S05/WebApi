using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.DataAccessLayer.Interface;
using Project.Models;
using Project.Services.Interface;

namespace Project.Services
{
    public class UserService:IUserService
    {
        private IUserRepository _UserRepository;
        public UserService(IUserRepository userRepository)
        {
            _UserRepository=userRepository;
        }

        public bool CreateUser(User user)
        {
            return _UserRepository.CreateUser(user) ? true :false;
            
        }
    }
}