using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementAPI.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        [HttpGet]
        public List<Manager> GetAllManagers()
        {
            return ManagerDB.managers;
        }

        [HttpGet("{id}")]
        public Manager GetManagerById(int id)
        {
            var manager = ManagerDB.managers.ToList();
             foreach(var item in manager)
            {
                if (item.id == id) return item;
            }
                return null;
        }

        [HttpPost]
        public Object Post([FromBody] Manager newManager)
        {
            ManagerDB.managers.Add(newManager);
            return Ok("Updated ManagerDB");
        }

    }
}