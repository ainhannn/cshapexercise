using System;
namespace Workspace
{
    class Program
    {
        public static int option(int min, int max)
        {
            int opt = min-1;
            try
            {
                Console.Write("Task: ");
                opt = int.Parse(Console.ReadLine());
            }
            catch (System.Exception) { }

            if (opt < min || max < opt)
            {
                Console.WriteLine("Enter a number in range[" + min + ", " + max + "]");
                return option(min, max);
            }
            return opt;
        }

        public static void Main(string[] args)
        {
            Week1.menu();
        }
    }
}