using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUD_Login_MVC_WebApp.Models
{
    public class DbServicesContext: DbContext
    {
        public DbSet<Employee> tbl_emp { get; set; }

    }
}