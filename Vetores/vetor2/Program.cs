using System;

namespace vetor2
{
    class Program
    {
        static void Main()
        {
            double a, b, c;
            double delta;
            double r1 = 0, r2 = 0;

            Console.Write("Digite o valor de a: ");
            a = double.Parse(Console.ReadLine()!);

            Console.Write("Digite o valor de b: ");
            b = double.Parse(Console.ReadLine()!);

            Console.Write("Digite o valor de c: ");
            c = double.Parse(Console.ReadLine()!);

            delta = CalcDelta(a, b, c);

            Console.WriteLine($"\nDelta = {delta}");

            if (delta < 0)
            {
                Console.WriteLine("\nNao existem raizes reais...");
            }
            else
            {
                CalcRaizes(a, b, delta, out r1, out r2);
                Console.WriteLine($"Raiz 1 = {r1}");
                Console.WriteLine($"Raiz 2 = {r2}");
            }

            Console.ReadKey();
        }

        static double CalcDelta(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        static void CalcRaizes(double a, double b, double delta, out double r1, out double r2)
        {
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);
        }
    }
}