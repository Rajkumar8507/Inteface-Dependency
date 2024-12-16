using Inteface_Dependency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Inteface_Dependency.IEmployeeInterface
{
    public interface IEmployee
    {
        void AddEmployee(Employee emp);
        void EditEmployee(Employee emp);
        void DeleteEmployee(string s);
        Employee FindEmployee(string s);
        List<Employee> GetEmployees();
       
    }
}
