using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementAPI.Modal;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        [HttpGet]
        public List<Employee> GetAllEmployee()
        {
            return EmployeeDB.employees;
        }

        [HttpGet("{id}")]
        public Employee GetEmployeeById(int id)
        {
            var tempList = new List<Employee>();
            tempList = EmployeeDB.employees;
            Employee employee = null ;
            foreach(var item in tempList)
            {
                if(item.id == id)
                {
                    employee = item;
                }
            }
            return employee;
        }


        [HttpGet("manager/{id}")]
        public IEnumerable<Employee> GetEmployeeByManagerId(int id)
        {
            var tempList = new List<Employee>();
            var employeeList = EmployeeDB.employees;
            
            foreach (var item in employeeList)
            {
                if (item.mid == id)
                {
                    tempList.Add(item);
                }
            }
            return tempList;
        }


        [HttpPost]
        public Object Post([FromBody] Employee newEmployee)
        {
            EmployeeDB.employees.Add(newEmployee);
            return Ok("Updated EmployeeDB");
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
