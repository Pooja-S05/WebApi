using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.DataAccessLayer.Interface;
using Project.Models;

namespace Project.DataAccessLayer
{
    public class UserRepository:IUserRepository
    {
        private Context _context;
        public UserRepository(Context context)
        {
            _context=context;
        }
        public bool CreateUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return true;
        }
    }
}