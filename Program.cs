using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we do write writeline
            Console.Write("Enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Hi" + name);
            Console.Write("How old are you");
            //the values from user are always strings
            string age = Console.ReadLine();
            Console.WriteLine("I am" + 23);
            Console.ReadLine();



        }
    }
}
