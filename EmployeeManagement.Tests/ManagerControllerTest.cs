using EmployeeManagementAPI.Controllers;
using EmployeeManagementAPI.Modal;
using FluentAssertions;
using System;
using Xunit;

namespace EmployeeManagement.Tests
{
    public class ManagerTest
    {
        [Fact]
        public void Get_Should_Return_All_Manager_Count()
        {
            var actual = new ManagerController().GetAllManagers().Count;
            Assert.Equal(2, actual);
        }
        [Fact]
        public void GetManagerById_Should_return_Manager_by_id()
        {
            var actual = new ManagerController().GetManagerById(1);
            var expected = new Manager() { id = 1, name = "MA", age = 20, salary = 200000};
       
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
