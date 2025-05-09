using System;

namespace inheritance_assignment
{
    class auth : Student
    {
        private string staticusername;
        private String staticpassword;

        private string inputusername;
        private string inputpassword;

        private const int maxAttempts = 10;
        public auth(string username, String  password)
        {
            staticusername = username;
            staticpassword = password;
        }

        public void EnterAuthDetails()
        {
            Console.WriteLine("You have a maximum of 10 attempts to log in.");

            for (int attempt = 1; attempt < maxAttempts; attempt++)
            {
                Console.Write("Enter the username: ");
                inputusername = Console.ReadLine();
                Console.Write("Enter the password: ");
                inputpassword = Console.ReadLine();

                if (CheckAuth(inputusername, inputpassword))
                {
                    Console.WriteLine("Authentication successful!");
                    return; 
                }
                else
                {
                    Console.WriteLine($"Authentication failed. Attempts left: {maxAttempts - attempt}");
                }
            }

            Console.WriteLine("Maximum authentication attempts reached. Exiting...");
        }


        private bool CheckAuth(string username, string password)
        {
            return username == staticusername && password == staticpassword;
        }

    
        public bool IsAuthenticated()
        {
            return inputusername == staticusername && inputpassword == staticpassword;
        }
    }
}
