using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_assignment
{
  
    class Student
    {
        public string name;
        public int rollnumber;
        public  string Department;

        public void EnterStudentDetails()
        {
            Console.WriteLine("Enter the name of the student: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the roll number of the student: ");
            rollnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the department of the student: ");
            Department = Console.ReadLine();
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine($"Name: {name}, Roll Number: {rollnumber}, Department: {Department}");
        }

       


    }
}