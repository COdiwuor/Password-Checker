using System;

namespace csharp_password_checker
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input your password:");
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChar = "#?!,-'/`_*$";
            string password = Console.ReadLine();
            int score = 0;

            if ((score) >= (minLength))
            {
                score++;
            }
            if (Contains(password, uppercase))
            {
                score++;
            }
            if (Contains(password, lowercase))
            {
                score++;
            }
            if (Contains(password, digits))
            {
                score++;
            }
            if (Contains(password, specialChar))
            {
                score++;
            }

            Console.WriteLine(password);
            Console.WriteLine(score);

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("This is an extremely strong password");
                    break;
                case 3:
                    Console.WriteLine("This is a strong password");
                    break;
                case 2:
                    Console.WriteLine("This is an average password");
                    break;
                case 1:
                    Console.WriteLine("This is a weak password");
                    break;
                default:
                    Console.WriteLine("This password doesn't meet the standards");
                    break;
            }
            //Console.ReadLine();
        }

        //Add the Contains method here after the Main method, but still inside the MainClass class
        //Using the expression bodied definition or the lambda expression
        //Fat arrow mwthod (=>)
        public static bool Contains(string target, string list) => target.IndexOfAny(list.ToCharArray()) != -1;

    }
}
