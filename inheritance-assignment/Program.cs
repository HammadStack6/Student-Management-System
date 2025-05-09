using inheritance_assignment;

Console.BackgroundColor = ConsoleColor.Red;

auth a = new auth("h", "12");
a.EnterAuthDetails();
if (a.IsAuthenticated())
{


    {
        List<Finance> financeList = new List<Finance>();

        Console.WriteLine("-------------STUDENT DETAILS-----------------");
        Console.Write("Enter the number of students you want to enter: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter the details of student {i + 1}: ");
            Console.WriteLine("---------FINANCE DETAILS--------------");

            Finance f = new Finance();
            f.EnterStudentDetails();
            f.EnterCourseFee();

            Console.WriteLine("***********The student details are********: ");
            f.PrintStudentDetails();
            f.PrintCourseFees();
            f.CalculateTotalFee();

            financeList.Add(f);
            f.Check(financeList);

            f.FinanceChecker();
        }

        
        
    }
}
