using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_assignment
{
    class exam : Student
    {

           public int subject1Marks;
        public int subject2Marks;
        public  int subject3Marks;


        public void EnterMarks()
        {
            Console.WriteLine("Enter the marks of subject 1");
            string subject1 = Console.ReadLine();

            Console.WriteLine("Enter the marks of subject 2");
            string subject2 = Console.ReadLine();
            Console.WriteLine("Enter the marks of subject 3");
            string subject3 = Console.ReadLine();
        }

        public void CalculateResult()
        {
            int totalMarks = subject1Marks + subject2Marks + subject3Marks;
            Console.WriteLine($"The result is:{totalMarks} ");
        }
        List<exam> examList = new List<exam>();
        public void CheckList()
        {
            Console.WriteLine("***********The  student exam  details are********: ");
            foreach (exam result in examList)
            {
                Console.WriteLine($"Name: {result.name}");
                Console.WriteLine($"Roll Number: {result.rollnumber}");
                Console.WriteLine($"Department: {result.Department}");
                Console.WriteLine($"Subject 1 Marks: {result.subject1Marks}");
                Console.WriteLine($"Subject 2 Marks: {result.subject2Marks}");
                Console.WriteLine($"Subject 3 Marks: {result.subject3Marks}");
            }

        }




    }
}
