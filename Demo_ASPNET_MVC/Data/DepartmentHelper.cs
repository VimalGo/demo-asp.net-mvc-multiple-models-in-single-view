using Demo_ASPNET_MVC.Models;

namespace Demo_ASPNET_MVC.Data
{
    public class DepartmentHelper
    {
        public List<Department> GetDepartments()
        {
            return new List<Department>(){
                new Department() { DepartmentId = 1, DeptCode = "DeptCode1", DeptName = "DeptName1", IsActive=true},
                new Department() { DepartmentId = 2, DeptCode = "DeptCode2", DeptName = "DeptName2", IsActive=false},
                new Department() { DepartmentId = 3, DeptCode = "DeptCode3", DeptName = "DeptName3", IsActive=true},
                new Department() { DepartmentId = 4, DeptCode = "DeptCode4", DeptName = "DeptName4", IsActive=false},
            };
        }
    }
}
