using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DLL.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
}
