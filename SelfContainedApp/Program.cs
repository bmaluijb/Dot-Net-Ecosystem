using System;

namespace SelfContainedApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var location = SharedClassLibrary
                .SharedClass.GetCurrentAssemblyLocation();

            Console.WriteLine("Hello World from a self-contained app! " + location);
            Console.ReadLine();
        }
    }
}