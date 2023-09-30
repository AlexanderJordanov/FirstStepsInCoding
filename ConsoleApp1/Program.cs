using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double year = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "m")
            {
                if (year >= 16) { Console.WriteLine("Mr."); }
                else  { Console.WriteLine("Master"); }
            }
            else if (gender == "f")
            {
                if (year >= 16) { Console.WriteLine("Ms."); }
                else  { Console.WriteLine("Miss"); }
            }
           


        }
    }
}
