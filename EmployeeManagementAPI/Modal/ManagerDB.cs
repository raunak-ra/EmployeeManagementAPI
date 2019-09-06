using EmployeeManagementAPI.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Controllers
{
    public static class ManagerDB
    {
        public static List<Manager> managers = new List<Manager>()
        {
            new Manager() { id=1, name = "MA", age = 20, salary = 200000 },
            new Manager() { id=2, name = "MB", age = 21, salary = 300000 }
      
        };
    }
}
