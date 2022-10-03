using Demo_ASPNET_MVC.Data;
using Demo_ASPNET_MVC.Models;
using Demo_ASPNET_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Demo_ASPNET_MVC.Controllers
{
    public class MultipleModelsInSingleViewController : Controller
    {
        public IActionResult MultipleModelsInSingleView()
        {
            return View();
        }

        #region Using Dynamic Model
        public IActionResult UsingDynamicModel()
        {
            DepartmentHelper deptHelper = new DepartmentHelper();
            EmployeeHelper empHelper = new EmployeeHelper();

            dynamic dynamicObj = new ExpandoObject();

            dynamicObj.Departments = deptHelper.GetDepartments();
            dynamicObj.Employees = empHelper.GetEmployees();

            return View(dynamicObj);
        }
        #endregion

        #region Using ViewModels
        public IActionResult UsingViewModels()
        {
            DepartmentHelper deptHelper = new DepartmentHelper();
            EmployeeHelper empHelper = new EmployeeHelper();

            DeptEmpViewModel deptEmpViewModel = new DeptEmpViewModel();

            deptEmpViewModel.Departments = deptHelper.GetDepartments();
            deptEmpViewModel.Employees = empHelper.GetEmployees();

            return View(deptEmpViewModel);
        }
        #endregion

        #region Using ViewData
        public IActionResult UsingViewData()
        {
            DepartmentHelper deptHelper = new DepartmentHelper();
            EmployeeHelper empHelper = new EmployeeHelper();

            ViewData["Departments"] = deptHelper.GetDepartments();
            ViewData["Employees"] = empHelper.GetEmployees();

            return View();
        }
        #endregion

        #region Using ViewBag
        public IActionResult UsingViewBag()
        {
            DepartmentHelper deptHelper = new DepartmentHelper();
            EmployeeHelper empHelper = new EmployeeHelper();

            ViewBag.Departments = deptHelper.GetDepartments();
            ViewBag.Employees = empHelper.GetEmployees();

            return View();
        }
        #endregion

        #region Using Tuple
        public IActionResult UsingTuple()
        {
            DepartmentHelper deptHelper = new DepartmentHelper();
            EmployeeHelper empHelper = new EmployeeHelper();

            var deptEmpTuple = new Tuple<List<Department>, List<Employee>>(deptHelper.GetDepartments(), empHelper.GetEmployees());
            return View(deptEmpTuple);
        }
        #endregion

        #region Using RenderAction Method And PartialView
        public IActionResult UsingRenderActionMethodAndPartialView()
        {
            return View();
        }

        public  PartialViewResult RenderDepartmentPartialView()
        {
            DepartmentHelper deptHelper = new DepartmentHelper();
            return PartialView(deptHelper.GetDepartments());
        }

        public PartialViewResult RenderEmployeePartialView()
        {
            EmployeeHelper empHelper = new EmployeeHelper();
            return PartialView(empHelper.GetEmployees());
        }
        #endregion
    }
}
