using System;
using System.Collections.Generic;
using EmployeeManagement.Contracts;

namespace EmployeeManagement
{
    class Program
    {
        // this is the list 
        private static List<IEmployee> employees = new List<IEmployee>();

        static void Main(string[] args)
        {
            
        }

        private static void AddEmployee(string FirstName, string LastName, decimal Salary)
        {
            // should add an employee to the employees list
        }

        private static void RemoveEmployee(string FirstName, string LastName)
        {
            // should remove an employee from the employees list
        }

        private static void ViewEmployees()
        {
            // should display a list of all employees, for example:
            //
            // 1.
            // Ferdynand Kiepski
            // fkiepsk@company.com
            // Salary: 4000 EUR
            // Employment cost: 6000 EUR
            // Employment type: Full Time Employee
            //
            // 2.
            // Waldemar Kiepski
            // wkiepsk@company.com
            // Salary: 3000 EUR
            // Employment cost: 3900 EUR
            // Employment type: Contractor
        }
    }
}
