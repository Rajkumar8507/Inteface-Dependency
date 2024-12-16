using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Inteface_Dependency.Models;

namespace Inteface_Dependency.DAL
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Employee>().ToTable("IEmployee");
        }
        public DbSet<Employee> employees { get; set; }
    }
}