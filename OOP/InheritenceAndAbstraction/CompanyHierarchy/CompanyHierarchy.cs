using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CompanyHierarchy.Classes;
using CompanyHierarchy.Classes.Employees;
using CompanyHierarchy.Classes.Employees.AdditionalClasses;
using CompanyHierarchy.Enumarator;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy
{
    class CompanyHierarchy
    {
        static List<IEmployee> Employees()
        {
            Project homeAlone = new Project("Home alone", new DateTime(2016, 05, 22), "");
            Project tarzan = new Project("Tarzan", new DateTime(2015, 05, 22), "The movie is being shot right now");
            HashSet<Project> projects = new HashSet<Project>() { homeAlone, tarzan };

            Sale buchva = new Sale("Buchva", 17.156);
            Sale korniz = new Sale("Korniz", 22.156);
            Sale magdanoz = new Sale("Magdanoz", 2.05);
            HashSet<Sale> sales = new HashSet<Sale>() { buchva, korniz, magdanoz };

            SalesEmployee salesEmployee = new SalesEmployee("Geogi", "Ivanov", "9304294003", 29129.2314m,
                Department.Production, sales);
            Developer developer = new Developer("Danel", "Kraev", "9304294003", 29129.2314m,
                Department.Production, projects);

            HashSet<Employee> managedEmployees = new HashSet<Employee>() { salesEmployee, developer };
            Manager manager = new Manager("Simeon", "Vanov", "9304294003", 29129.2314m, Department.Production,
                managedEmployees);

            List<IEmployee> employees = new List<IEmployee>() { salesEmployee, developer, manager };
            return employees;
        }
        private static void PrintOutput(List<IEmployee> employees)
        {
            foreach (var employee in employees)
            {
                Console.Write(employee);
                LineForNewEmployee();
            }
        }
        static void LineForNewEmployee()
        {
            Console.WriteLine("-----------------------------------------");
        }
        static void Main()
        {
            try
            {
                List<IEmployee> employees = Employees();
                PrintOutput(employees);
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }

        
    }
}
