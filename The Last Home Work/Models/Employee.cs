using System;
using System.Collections.Generic;
using System.Text;

namespace The_Last_Home_Work.Models
{
   internal class Employee
    {
        public static int id = 1;
        public int No;
        public string FullName;
        public int Salary;
        public string Position;

        public Employee()
        {
            No = id;
            id++;
        }
    }
}
