using DotNetCoreProject.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DotNetCoreProject.Controllers
{
    [ApiController]
    [Route(template: "[controller]")]
    public class DepartmentController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(DepartmentStatic.GetAllDepartment());
        }

        [HttpGet(template: "{code}")]
        public IActionResult GetA(string code)
        {
            return Ok(DepartmentStatic.GetADepartment(code));
        }
        [HttpPost]
        public IActionResult Insert( Department department)
        {
            return Ok(DepartmentStatic.InsertDepartment(department));
        }
        [HttpPut(template: "{code}")]
        public IActionResult update(string code,Department department)
        {
            return Ok(DepartmentStatic.UpdateDepartment(code,department));
        }
        [HttpDelete(template: "{code}")]
        public IActionResult delete(string code)
        {
            return Ok(DepartmentStatic.DeleteDepartment(code) );
        }
    }
    public static class DepartmentStatic
    {
        public static List<Department> AllDepartment { get; set; } = new List<Department>();

        public static Department InsertDepartment(Department department)
        {
            AllDepartment.Add(department);
            return department;
        }
        public static List<Department> GetAllDepartment()
        {
            return AllDepartment;
        }
        public static Department GetADepartment(string code)
        {
            return AllDepartment.First();
           // return AllDepartment.FirstOrDefault(x: Department => x.code == code);
        }

        public static Department UpdateDepartment(string code, Department department)
        {
            foreach(var i in AllDepartment)
            {
                if (code == i.code)
                {
                    i.name = department.name;
                }
            }
            return department;
        }

        public static Department DeleteDepartment(string code)
        {
            //var department = AllDepartment.FirstOrDefault(x: department => x.code == code);
            //AllDepartment = AllDepartment.Where(x: department => x.Code != department.code).ToList();
            //return department;
            return AllDepartment.First();


        }





    }
}
