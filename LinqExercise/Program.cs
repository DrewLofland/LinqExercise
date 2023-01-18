using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine();

            //TODO: Print the Average of numbers
            var avg = numbers.Average();
            Console.WriteLine($"Average: {avg}");
            Console.WriteLine();
            
            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine($"Ascending order:");
            var ascend = numbers.OrderBy(x => x);
            foreach(var num in ascend)
                Console.WriteLine(num);
                Console.WriteLine();

            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine($"Descending order:");
            var descend = numbers.OrderByDescending(x => x);
            foreach (var num in descend)
                Console.WriteLine(num);
                Console.WriteLine();
            
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine($"Numbers above 6:");
            var abovesix = numbers.Where(x => x > 6);
            foreach(var num in abovesix)
                Console.WriteLine(num);
                Console.WriteLine();
            
            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine($"Ascending first 4:");
            var first4 = numbers.OrderBy(x =>x).Take(4);
            foreach(var num in first4)
                Console.WriteLine(num);
                Console.WriteLine();
            
            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine($"Replace index 4 with age then descending:");
            numbers[4] = 33;
            var desc = numbers.OrderByDescending(x => x);
            foreach (var num in desc)
                Console.WriteLine(num);
                Console.WriteLine();



            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine($"Employees with names starting with C or S:");
            var cors = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName[0] == 'S').OrderBy(x => x.FirstName);
            foreach (var employee in cors)
            {
                Console.WriteLine(employee.FullName);
            }
            Console.WriteLine();
            
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine($"Employees over age 26:");
            var over26 = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var employee in over26)
                Console.WriteLine($" {employee.FullName}, {employee.Age}");
                Console.WriteLine();
            
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var yearsoe = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var avgyoe = yearsoe.Average(x => x.YearsOfExperience);
            var sumyoe = yearsoe.Sum(x => x.YearsOfExperience);
            Console.WriteLine($"Avg YOE: {avgyoe} Sum of YOE: {sumyoe}");
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine($"New employee added to end:");
            employees = employees.Append(new Employee("New", "Employee", 33, 1)).ToList();
            foreach(var employee in employees)
            {
                Console.WriteLine(employee.FullName);
            }

            
            
            
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
