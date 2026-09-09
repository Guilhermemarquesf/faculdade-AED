using System;

namespace vetor 
{
    class Program
    {
        static void Main()
        {
           int n;

           Console.WriteLine("Digite um valor: ");
           n = int.Parse(Console.readLine()!)

           Imprime ("Valor de n é, 1, n");

           Console.ReadKey();

           static void Imprime(string Texto, int Nr, int QtdeVezes)
           {
                if (Nr <= QtdeVezes)
                {
                    Console.WriteLine($"{Texto} {Nr}");
                    Nr++;

                    Imprime(Texto, Nr, QtdeVezes);
                }
           }
        }                                             
    }
}