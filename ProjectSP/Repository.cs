using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSP
{
    public class Repository
    {
        private static List<Employee> employees = new List<Employee>();

        public static IEnumerable<Employee> GetEmployees
        {
            get
            {
                return employees;
            }
        }

        public static void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
    }
}
