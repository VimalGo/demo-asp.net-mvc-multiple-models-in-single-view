using Demo_ASPNET_MVC.Models;

namespace Demo_ASPNET_MVC.ViewModels
{
    public class DeptEmpViewModel
    {
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
