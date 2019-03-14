using System;

namespace ProjectSP
{
    public class EmployeeManage : IEmployeeManage
    {
        public double TotalSalary(Employee x)
        {
            return x.Salary * 3.14;
        }
    }
}
