using EmployeeManagementAPI.Controllers;
using EmployeeManagementAPI.Modal;
using FluentAssertions;
using System;
using Xunit;

namespace EmployeeManagement.Tests
{
    public class EmployeeTest
    {
        [Fact]
        public void Get_Should_Return_All_Employee_Count()
        {
            var actual = new EmployeeController().GetAllEmployee().Count;
            Assert.Equal(5, actual);
        }

        [Fact]
        public void GetEmployeeById_Should_return_employee_by_id()
        {
            var actual = new EmployeeController().GetEmployeeById(1);
            var expected = new Employee() { id = 1, name = "MA", age = 20, salary = 200000 };

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
