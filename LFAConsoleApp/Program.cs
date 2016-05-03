using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFAConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Welcome to the Leapfrog Console Appication");
                Console.ReadLine();
                Console.WriteLine("Enter the UserName");
                string strUserName = Console.ReadLine();
                Console.WriteLine("Enter the Password");
                string strPassword = Console.ReadLine();
                if ((strUserName == "admin") && (strPassword == "admin"))
                {
                    Console.WriteLine("You are authenticated to enter to the Leap Frog User Management");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter Valid Username and Password");
                }
            }
            while (true);
    
        }
    }
}
