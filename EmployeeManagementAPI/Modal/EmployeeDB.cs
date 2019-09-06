using EmployeeManagementAPI.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Controllers
{
    public static class EmployeeDB
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee() { id=1, name = "A", age = 20, salary = 200000, mid = 1},
            new Employee() { id=1, name = "B", age = 21, salary = 300000, mid = 1},
            new Employee() { id=1, name = "C", age = 22, salary = 200000, mid = 2},
            new Employee() { id=1, name = "D", age = 23, salary = 400000, mid = 2},
            new Employee() { id=1, name = "E", age = 24, salary = 500000, mid = 1}
        };
    }
}
