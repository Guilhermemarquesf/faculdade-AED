using System;

namespace vetores
{
    class Program
    {
        static void Main()
        {
            int fat = 1;
            int n;

            Console.WriteLine("n = ");
            n = int.Parse(Console.ReadLine()!);

            fat = CalcFat(n);

            Console.WriteLine($"Fatorial = {fat}");

            Console.ReadLine();
        }

        static int CalcFat(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}