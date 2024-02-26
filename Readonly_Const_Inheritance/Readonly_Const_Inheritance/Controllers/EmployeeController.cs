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
        public void GetAll()
        {
            EmployeeService employeService=new EmployeeService();
           var result= employeService.GetAll();
            foreach ( var item in result)
            {
                Console.WriteLine(item.name+" "+item.surname);
            }
        }
    }
}
