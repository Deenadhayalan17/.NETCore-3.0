using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DLL.Model;
namespace DLL.DBContext
{
    public class ApplicationDBCOntext :DbContext
    {
        public ApplicationDBCOntext( DbContextOptions options):base(options)
        {

        }
        public DbSet<Department> departments { get; set; }

        public DbSet<Student> students { get; set; }
    }
}
