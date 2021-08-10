using System;

namespace Uri_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, quociente, resto;
            n = int.Parse(Console.ReadLine());

            resto = n;

            quociente = resto / 365;
            Console.WriteLine($"{quociente} ano(s)");
            resto = resto % 365;

            quociente = resto / 30;
            Console.WriteLine($"{quociente} mes(es)");
            resto = resto % 30;

            Console.WriteLine($"{resto} dia(s)");

        }
    }
}
