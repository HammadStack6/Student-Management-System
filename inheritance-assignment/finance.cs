using System;
using System.Collections.Generic;
using System.Linq;

namespace inheritance_assignment
{
    class Finance : Student
    {
        public int CourseFee1;
        public int CourseFee2;
        public int CourseFee3;

        public void EnterCourseFee()
        {
            Console.WriteLine("Enter the course fee for course 1: ");
            CourseFee1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the course fee for course 2: ");
            CourseFee2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the course fee for course 3: ");
            CourseFee3 = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintCourseFees()
        {
            Console.WriteLine($"Course Fee 1: {CourseFee1} Rs");
            Console.WriteLine($"Course Fee 2: {CourseFee2} Rs");
            Console.WriteLine($"Course Fee 3: {CourseFee3} Rs");
        }

        public void CalculateTotalFee()
        {
            int totalFee = CourseFee1 + CourseFee2 + CourseFee3;
            Console.WriteLine($"The total fee is: {totalFee} Rs");
        }

        public void Check(List<Finance> financeList)
        {
            Console.WriteLine("\n*********** Student Finance Details ***********");
            foreach (Finance item in financeList)
            {
                Console.WriteLine($"Name: {item.name}");
                Console.WriteLine($"Roll Number: {item.rollnumber}");
                Console.WriteLine($"Department: {item.Department}");
                Console.WriteLine($"Course Fee 1: {item.CourseFee1}");
                Console.WriteLine($"Course Fee 2: {item.CourseFee2}");
                Console.WriteLine($"Course Fee 3: {item.CourseFee3}");
  
            }
        }

        public void FinanceChecker()
        {
            int TotalAmount = 75000;
            int totalFee = CourseFee1 + CourseFee2 + CourseFee3;

            if (totalFee < TotalAmount)
            {
                Console.WriteLine("The student has to pay the remaining amount.");
            }
            else
            {
                Console.WriteLine("For more information, contact the finance department.");
            }
        }

        public void SwitchCase(List<Finance> financeList)
        {
            bool continueInput = true;

            while (continueInput)
            {
                Console.WriteLine("\nWhat operation do you want to perform?");
                Console.WriteLine("For ADD press a");
                Console.WriteLine("For DELETE press d");
                Console.WriteLine("For UPDATE press u");
                Console.WriteLine("For READ press v");

                string orgInput = Console.ReadLine();

                char operationBefore = Convert.ToChar(orgInput.ToLower());
                char operation = operationBefore;

                switch (operation)
                {
                    case 'a':
                        Console.WriteLine("Add operation selected");
                        Finance newFinance = new Finance();
                        newFinance.EnterStudentDetails();
                        newFinance.EnterCourseFee();
                        financeList.Add(newFinance);
                        Check(financeList);
                        break;

                    case 'd':
                        Console.WriteLine("Delete operation selected");
                        Console.WriteLine("Enter Roll Number:");
                        int rollNumberToDelete = Convert.ToInt32(Console.ReadLine());
                        var studentToDelete = financeList.FirstOrDefault(x => x.rollnumber == rollNumberToDelete);
                        if (studentToDelete != null)
                        {
                            financeList.Remove(studentToDelete);
                            Console.WriteLine("Student deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case 'u':
                        Console.WriteLine("Update operation selected");
                        Console.WriteLine("Enter Roll Number:");
                        int rollNumberToUpdate = Convert.ToInt32(Console.ReadLine());
                        var studentToUpdate = financeList.FirstOrDefault(x => x.rollnumber == rollNumberToUpdate);
                        if (studentToUpdate != null)
                        {
                            Console.WriteLine("Enter new details:");
                            studentToUpdate.EnterStudentDetails();
                            studentToUpdate.EnterCourseFee();
                            Console.WriteLine("Student updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case 'v':
                        Console.WriteLine("Read operation selected");
                        Console.WriteLine("Enter Roll Number:");
                        int rollNumberToView = Convert.ToInt32(Console.ReadLine());
                        var studentToView = financeList.FirstOrDefault(x => x.rollnumber == rollNumberToView);
                        if (studentToView != null)
                        {
                            studentToView.PrintStudentDetails();
                            studentToView.PrintCourseFees();
                            studentToView.CalculateTotalFee();
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid operation selected.");
                        break;
                }

                Console.WriteLine("Do you want to continue? (yes/no): ");
                string continueChoice = Console.ReadLine().ToLower();
                if (continueChoice == "no")
                {
                    continueInput = false;
                    Console.WriteLine("Thank you for using the program.");
                }
            }
        }
    }
}
