using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForGithub03.Entities;

namespace ForGithub03.DataAccess
{
   
        public class EmployeeRepository
        {
            private readonly string connectionString;

            public EmployeeRepository(string connectionString) // Constructor eklendi
            {
                this.connectionString = connectionString;
            }
            public int AddEmployee(Employee employee)
            {
                return 0;
            }


            public List<Employee> GetEmployees()
            {
                return new List<Employee>();
            }

            public Employee GetEmployee(int id)
            {
                return null;
            }

            public void UpdateEmployee(Employee employee)
            {

            }

            public void DeleteEmployee(int id)
            {

            }
        }
    }




