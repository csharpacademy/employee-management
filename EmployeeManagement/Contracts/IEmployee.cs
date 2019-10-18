using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Contracts
{
    interface IEmployee
    {
        string FirstName { get; set; } // Ferdynand

        string LastName { get; set; } // Kiepski

        decimal Salary { get; set; } // 4000

        /// <summary>
        /// Generates company email using first letter of FirstName and 6 first letters of LastName and company suffix
        /// </summary>
        /// <returns></returns>
        string GetEmailAddress();

        /// <summary>
        /// Calculates employee cost for the company
        /// Full time employee: Salary * 1.5
        /// Contractor: Salary * 1.3
        /// Intern: Salary * 1.2
        /// </summary>
        /// <returns></returns>
        decimal CalculateCost();

        /// <summary>
        /// Returns an employment type of the given employee
        /// </summary>
        /// <returns></returns>
        string GetEmploymentType();
    }
}
