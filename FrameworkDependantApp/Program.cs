using System;

namespace FrameworkDependantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var location = 
                SharedClassLibrary.SharedClass
                .GetCurrentAssemblyLocation();

            Console.WriteLine("Hello World! " + location);
            Console.ReadLine();
        }
    }
}