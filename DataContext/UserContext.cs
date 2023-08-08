using MVVM_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Pattern.DataContext
{
    public class UserContext : IUserContext
    {
        public List<User> GetUsers()
        {
            var listUsers = new List<User>
            {
                new User() { Id = 1, Name = "Andre Rocha", Email = "andre@gmail.com" }
            };

            return listUsers;
            
            
        }
    }
}
