using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject.Controllers
{
    [ApiController]
    [Route(template:"[controller]")]
    public class DepartmentController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("get all the stident");
        }
        
        [HttpGet(template:"{code}")]
        public IActionResult GetA( string code)
        {
            return Ok("get" + code + " data");
        }
        [HttpPost]
        public IActionResult Insert()
        {
            return Ok("insert sucess");
        }
        [HttpPut(template: "{code}")]
        public IActionResult update(string code)
        {
            return Ok("update" + code + " data");
        }
        [HttpDelete(template: "{code}")]
        public IActionResult delete( string code)
        {
            return Ok("delete" + code + " data");
        }
    }
}
