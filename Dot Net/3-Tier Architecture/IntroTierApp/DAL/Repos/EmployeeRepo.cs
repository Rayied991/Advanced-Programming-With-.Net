using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EmployeeRepo
    {
        //Here these repos are some libraries
        static EmpContext empContext;//if its not static i have to create instance through instance i have to access it


        static EmployeeRepo()
        {
            empContext = new EmpContext();//Database Instance
        }

        public static List<Employee> Get()
        {
            //[if changes occurs after a period of time]
            return empContext.Employees.ToList();

            //old code
            //var employees = new List<Employee>();
            //for (int i = 1; i < 11; i++)
            //{
            //    employees.Add(new Employee
            //    {
            //        Id= i, Name="E-"+1
            //    });
            //}
            //return employees;
        }
        public static Employee Get(int id)
        {
            return empContext.Employees.Find(id);
        }
        public static bool Create(Employee employee)
        {
            empContext.Employees.Add(employee);
            return empContext.SaveChanges()>0;//How many row has affected= savechanges ;sc>0:true/false
        }
        public static bool Update(Employee employee) {
            var exemp = empContext.Employees.Find(employee.Id);
            empContext.Entry(exemp).CurrentValues.SetValues(employee);
            return empContext.SaveChanges()>0;
        }

        public static bool Delete(int id)
        {
            var exemp = Get(id);
            empContext.Employees.Remove(exemp);
            return empContext.SaveChanges()>0;
        }

    }
}
