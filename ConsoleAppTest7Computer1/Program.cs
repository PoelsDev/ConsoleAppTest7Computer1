using System;

namespace ConsoleAppTest7Computer1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Computer1(3, 4);
            c1.Som();
            Console.WriteLine(c1.Resultaat);
            c1.Verschil();
            Console.WriteLine(c1.Resultaat);
            c1.Product();
            Console.WriteLine(c1.Resultaat);

            var c2 = new Computer2(3, 4);
            Console.WriteLine(c2.Som());
            Console.WriteLine(c2.Verschil());
            Console.WriteLine(c2.Product());
        }
    }
}
