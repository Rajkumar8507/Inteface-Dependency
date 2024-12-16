using Inteface_Dependency.DAL;
using Inteface_Dependency.IEmployeeInterface;
using Inteface_Dependency.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;


namespace Inteface_Dependency.ServerRepository
{
    
    public class SqlServerRepo : IEmployee
    {
        private readonly EmployeeContext _Context;
        public SqlServerRepo()
        {
            _Context=new EmployeeContext();
        }
        public void AddEmployee(Employee emp)
        {
          _Context.employees.Add(emp);
          _Context.SaveChanges();
        }

        public void DeleteEmployee(string s)
        {
            Employee e=_Context.employees.Find(s);
            
            
                _Context.employees.Remove(e);
            
        }

        public void EditEmployee(Employee emp)
        {
            Employee raj=_Context.employees.Find(emp.id);
            Employee e = raj;
            if (e != null)
            {


                e.Name = emp.Name;
                e.City = emp.City;
                e.Address = emp.Address;
                _Context.SaveChanges();
            }
        }

        public Employee FindEmployee(string s)
        {
            Employee e = _Context.employees.Find(s);
            return e;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> emp=_Context.employees.ToList();
            return emp;
        }
    }
}