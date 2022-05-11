using DotNetCoreProject.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject.Controllers
{

    public class StudentController : MainApiController
    {
        [HttpGet]
        public IActionResult GetAll()

        {
            return Ok(StudentStatic.Getstudents());
        }

        [HttpPost]
        public IActionResult insertdata(Student student)

        {
            return Ok(StudentStatic.InsertStudent(student));
        }
    }
    public static class StudentStatic
    {
        public static List<Student> AllStudents { get; set; } = new List<Student>();

        public static List<Student> Getstudents()
        {
            return AllStudents;
        }

        public static Student InsertStudent(Student student)
        {

            AllStudents.Add(student);
            return student;
        }
    } 
}
