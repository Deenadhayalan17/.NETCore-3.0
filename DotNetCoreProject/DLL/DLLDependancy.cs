using DLL.DBContext;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
    public static class DLLDependancy
    {
        public static void AllDependancy (IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBCOntext>( optionsAction : options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));//DbCOntext
        }
    }
}
