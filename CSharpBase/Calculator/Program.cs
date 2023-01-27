using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int x = 25;
            int y = 70;
            int z = 100;
            int c = x + y;
            Console.WriteLine("ответ: " + c);

            int r = y - x;
            Console.WriteLine("вычитание: " + r);
            Console.WriteLine();
         }
    }
}
