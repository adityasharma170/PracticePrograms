using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter line : ");
            String line = Console.ReadLine();
            Console.WriteLine(line);
            string toTotalCase=  line.ToTitleCase();
            Console.WriteLine(toTotalCase);

        }

        
    }
}
