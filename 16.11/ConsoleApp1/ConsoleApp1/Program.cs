using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your favorite football player t-shirt number!");
            string number = Console.ReadLine();
            int numberParsed = Int16.Parse(number);

            // teen siia if ja else loogikaga vastused
            // nt kui on alla 50, siis tuleb console writeline vastus

            Console.WriteLine();

            if (numberParsed <= 50)
            {
             Console.WriteLine("See nr on võrdne või väiksem 50-st");
            }
            else
            {
                Console.WriteLine("Kõik ülejäänud numbrid.");
            }
            
        }
    }
}