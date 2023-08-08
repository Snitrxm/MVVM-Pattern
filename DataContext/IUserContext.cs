using MVVM_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Pattern.DataContext
{
    interface IUserContext
    {
        List<User> GetUsers();
    }
}
