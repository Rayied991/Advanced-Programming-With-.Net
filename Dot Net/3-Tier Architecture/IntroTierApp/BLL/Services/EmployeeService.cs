using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
        //deal with employee related all logical operations[for time being no logical needed]
        //make them static
        /* public static List<Employee> Get()
          {

             return EmployeeRepo.Get();
          }*/
        public static object Get()
        {

            return EmployeeRepo.Get();
        }
        //Employees id between 1 to 10
        public static List<Employee> Get10()
        {
            var data = from e in EmployeeRepo.Get()
                       where e.Id < 11
                       select e;
            return data.ToList();
        }

        public static Employee Get(int id)
        {
            return EmployeeRepo.Get(id);
        }
         public static bool Create(Employee employee)
        {

            return EmployeeRepo.Create(employee);
        }

        public static bool Update(Employee employee)
        {
            return EmployeeRepo.Update(employee);
        }

        public static bool Delete(int id)
        {
            return EmployeeRepo.Delete(id);
        }
    }
}
