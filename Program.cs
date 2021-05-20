using System;
using System.IO;
using System.Collections.Generic;
namespace ConsoleApp8
{
    class Program
    {

        static void DirectorySearch(string dir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                    Console.WriteLine("  -" + "{0}", f[(f.LastIndexOf("\\") + 1)..]);

                foreach (string d in Directory.GetDirectories(dir))
                {
                    Console.WriteLine("--" + "{0}", d[(d.LastIndexOf("\\") + 1)..]);
                    DirectorySearch(d);
                }
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter directory path");
            string root = @"" + Console.ReadLine();
            DirectorySearch(root);
            Console.ReadKey();
        }
        }

   
}