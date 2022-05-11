using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject.Controllers
{
    [ApiVersion("1.0")]// versioning 
    [ApiController]
    [Route("api/{v:apiVersion}/[controller]")]
    public class MainApiController : ControllerBase
    {
      
    }
}
