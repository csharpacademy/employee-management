using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Contracts;

namespace EmployeeManagement.Models
{
    public class FullTimeEmployee: IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public string GetEmailAddress()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateCost()
        {
            throw new NotImplementedException();
        }

        public string GetEmploymentType()
        {
            throw new NotImplementedException();
        }
    }
}
