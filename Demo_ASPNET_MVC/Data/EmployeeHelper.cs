using Demo_ASPNET_MVC.Models;

namespace Demo_ASPNET_MVC.Data
{
    public class EmployeeHelper
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>(){
                new Employee() { EmployeeId = 1, FirstName = "Vimal", LastName="Gohil", DeptId =1, IsActive=true},
                new Employee() { EmployeeId = 2, FirstName = "Manish", LastName="Patel", DeptId =2, IsActive=false},
                new Employee() { EmployeeId = 3, FirstName = "Suresh", LastName="Patil", DeptId =3, IsActive=true},
                new Employee() { EmployeeId = 4, FirstName = "Chandresh", LastName="Ladva", DeptId =4, IsActive=false},

                new Employee() { EmployeeId = 5, FirstName = "Test FistName", LastName="Test LastName", DeptId =1, IsActive=true},
                new Employee() { EmployeeId = 6, FirstName = "Test FirstName1", LastName="Test LastName1", DeptId =2, IsActive=false},
                new Employee() { EmployeeId = 7, FirstName = "Test FirstName2", LastName="Test LastName2", DeptId =3, IsActive=true},
                new Employee() { EmployeeId = 8, FirstName = "Test FirstName3", LastName="Test LastName3", DeptId =4, IsActive=false},
            };
        }
    }
}
