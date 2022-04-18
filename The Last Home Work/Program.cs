using System;
using The_Last_Home_Work.Models;
namespace The_Last_Home_Work

{
   internal class Program
   {
       
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Employee worker = new Employee
                {
                    FullName = "Unknown Person",
                    Salary = 1600,
                    Position = "Ceo",

                };

                Company company = new Company
                {
                    Name = "Coca Cola International LLC",
                    limit = 18,
                };
                company.AddEmployee(worker);
            }
        }
   }
