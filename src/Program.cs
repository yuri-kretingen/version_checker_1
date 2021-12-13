using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestApi();
            test.TestFoo();
            Console.WriteLine("Main");
            test.TestFoo2();
        }
    }
}
