using System;

namespace vetor6
{
    class Program
    {
        static void Main()
        {
           int n;
           int resultado;

           Console.WriteLine("Digite um numero:");
           n = int.Parse(Console.ReadLine()!);

           resultado = triplo(n);

           Console.WriteLine($"\n O trilho é: {resultado}");

           Console.ReadKey();
        }                                             

        static int triplo (int x)
        {
            return x * 3;
        }
    }
}