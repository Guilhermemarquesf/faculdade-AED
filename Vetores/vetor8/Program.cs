using System;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace vetor8
{
    class Program
    {
        static void Main()
        {
           int a, b;
           int resultado;

           Console.WriteLine("Digite o pimeiro numero:");
           a = int.Parse(Console.ReadLine()!);

           Console.WriteLine("Digite o segundo numero:");
           b = int.Parse(Console.ReadLine()!);

           resultado = AchaMaior(a, b);

           Console.WriteLine($"\n O resultado maior é: {resultado}");

           Console.ReadKey();
        }              

        static int AchaMaior(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }                               
    }
}