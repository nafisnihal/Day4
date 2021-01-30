using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 1;
            while (option == 1) { 
            Console.Write("Welcome to password strength checker\nEnter Your Password:");
            string password = Console.ReadLine();

            int passlength = password.Length;

            if (passlength <= 5)
            {
                Console.WriteLine("Weak Password");
            }
            else if (passlength > 5)
            {
                if (password[passlength-1]%2==0) 
                    Console.WriteLine("Strong Password");
                else
                    Console.WriteLine("Average");
            }
            

            Console.WriteLine("Press 1 to check again");
            Console.WriteLine("Press 0 to exit");

            string select = Console.ReadLine();
            option = Convert.ToInt32(select);

            if (option == 0)
            {
                option = 0;
                }
            }
        }
    }
}
