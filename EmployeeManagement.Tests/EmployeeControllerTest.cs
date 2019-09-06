using EmployeeManagementAPI.Controllers;
using EmployeeManagementAPI.Modal;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace EmployeeManagement.Tests
{
    public class EmployeeControllerTest
    {
        [Fact]
        public void Test_Employee_Count()
        {
            var actual = new EmployeeController().GetAllEmployee().Count;
            Assert.Equal(5, actual);
        }

        [Fact]
        public void GetEmployeeById_Should_return_employee_by_id()
        {
            var actual = new EmployeeController().GetEmployeeById(1);
            var expected = new Employee() { id = 1, name = "A", age = 20, salary = 200000, mid = 1 };
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void GetEmployeeByManagerId_Should_return_employee_by_manager_id()
        {
            var actual = new EmployeeController().GetEmployeeByManagerId(2);
            var expected = new List<Employee>(){
                   new Employee() { id = 3, name = "C", age = 22, salary = 200000, mid = 2 },
                           new Employee() { id = 4, name = "D", age = 23, salary = 400000, mid = 2 } };
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
