using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DLL.Model
{
    public class Department
    {
        public string name { get; set; }
        [Key]
        public string code { get; set; }
    }
}
 