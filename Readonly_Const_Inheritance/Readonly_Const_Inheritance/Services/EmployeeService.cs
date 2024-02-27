using Readonly_Const_Inheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Readonly_Const_Inheritance.Services
{
    internal class EmployeeService:Employee
    {
        public Employee[] GetAll()
        {
            Employee employee1 = new()
            {
                id = 1,
                name = "Employe1",
                surname = "employev1",
                address = "baki1",
                email = "employe1@gmail.com",
                age = 18,
            };
            Employee employee2 = new()
            {
                id = 2,
                name = "Employe2",
                surname = "employev2",
                address = "baki1",
                email = "employe2@gmail.com",
                age = 34
            };
            Employee employee3 = new()
            {
                id = 3,
                name = "Employe3",
                surname = "employev3",
                address = "baki3",
                email = "employe3@gmail.com",
                age = 54
            };
            Employee employee4 = new()
            {
                id = 4,
                name = "Employe4",
                surname = "employev4",
                address = "baki4",
                email = "employe4@gmail.com",
                age = 28
            };

            Employee[] employess = { employee1, employee2, employee3, employee4 };
           
           
                 
            return employess;
            
    }
        public Employee[] GetAllByAge(Employee[]employees ,int age)
        {
           
            return employees.Where(m=>m.age>age).ToArray();
        }
        public int  GetCountByAge(Employee[] employees ,int firstAge,int lastAge)
        {
            return employees.Where(m => m.age >firstAge&&m.age<lastAge).Count();
        }
        public int SumOfAge(Employee[] employees)
        {
            return employees.Sum(m => m.age);
        }
   public Employee[] GetAllByCheckedEmail(Employee[] employees,string str)
        {
            return employees.Where(m => m.email.StartsWith(str)).ToArray();
        }
    }  
}
