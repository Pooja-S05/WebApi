using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class User
    {
        public User()
        {
            
        }
        [Key]
        public int UserId {get;set;}
        [StringLength(50)]
        public string UserName {get;set;} =null;

        public string Gender {get;set;}

        public string EmailId {get;set;}

        public string Password {get;set;}

    }
}