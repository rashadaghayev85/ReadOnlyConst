using Readonly_Const_Inheritance.Models;
using Readonly_Const_Inheritance.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonly_Const_Inheritance.Controllers
{
    internal class EmployeeController
    {
        public EmployeeService employeeService; 
        public EmployeeController()
        {
            employeeService=new EmployeeService();
        }
        public void GetAll()
        {
            EmployeeService employeService=new EmployeeService();
           var result= employeService.GetAll();
            foreach ( var item in result)
            {
                Console.WriteLine(item.name+" "+item.surname);
            }
        }
        public void GetAllByAge()
        {
            EmployeeService employeService=new EmployeeService();
            var employees = employeService.GetAll();
            var result = employeService.GetAllByAge(employees, 30);
            foreach ( var item in result)
            {
                Console.WriteLine(item.name+" "+item.age+" "+item.email);
            }
        }
        public void GetCountByAge()
        {
            Console.WriteLine("add first age");
            int firstAge=int.Parse(Console.ReadLine());
            Console.WriteLine("add last age");
            int lastAge = int.Parse(Console.ReadLine());
            int count = employeeService.GetCountByAge(employeeService.GetAll(),firstAge,lastAge);
            Console.WriteLine(count); 
        }
        public void GetSumOfAges()
        {
            int sumOfAge = employeeService.SumOfAge(employeeService.GetAll());
            Console.WriteLine(sumOfAge);
        }
        public void GetAllByCheckedEmail()
        {
            Console.WriteLine("Add your text:");
            string str=Console.ReadLine();  
            
            Employee[] employees = employeeService.GetAll();
            Employee[] checkedEmployees = employeeService.GetAllByCheckedEmail(employees, str);
            foreach (var item in checkedEmployees)
            {
                Console.WriteLine(item.name + " " + item.age + " " + item.email);
            }
        }
    }
}
