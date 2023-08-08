﻿using MVVM_Pattern.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Pattern.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public List<User> GetUsers()
        {
            IUserContext userContext = new UserContext();
            return userContext.GetUsers();
        }
    }
}
