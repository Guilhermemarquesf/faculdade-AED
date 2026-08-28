using System;

namespace vetor4
{
    class Program
    {
        static void Main()
        {
           int n;
           int resultado;

           Console.WriteLine("Digite um numero:");
           n = int.Parse(Console.ReadLine()!);

           resultado = Dobro(n);

           Console.WriteLine($"Dobro {resultado}");

           Console.ReadKey(); 
           
        }                                     

        static int Dobro(int x)
        {
            return x * 2;
        }        
    }
}