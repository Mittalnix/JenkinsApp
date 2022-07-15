using System;
using ClassLibrary1;

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome To Jenkins");
            Console.WriteLine("Welcome To Jenkins");
            Console.ReadLine();
            Class1 cls = new Class1();
            Console.WriteLine(cls.add(10, 20));
            Console.WriteLine(cls.mup(10, 20));
            Console.ReadLine();
        }
    }
}
