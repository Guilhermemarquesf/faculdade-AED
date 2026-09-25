using System;

namespace vetor13
{
    class Program
    {
        static void Main()
        {
           long n;
           long nTermo;

            Console.WriteLine("Digite o termo da serie: ");
            n = long.Parse(Console.ReadLine()!);

            nTermo = CalcFibonacci(n);

            Console.WriteLine($"\n O termo {n} da Série de Fibonacci é {nTermo}");

            Console.ReadKey();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i,3} = {CalcFibonacciR(i)}");
            }

            Console.ReadKey();
        }                  

        static long CalcFibonacciR(long n)
        {
            if (n < 2)
                return n;
            else
                return CalcFibonacciR(n - 1) + CalcFibonacciR(n - 2);
        }   

        static long CalcFibonacci(long n)
        {
            long atual = 0;
            long anterior = 1;

            for (long i = 0; i < n; i++)
            {
                long proximo = atual + anterior;
                atual = anterior;
                anterior = proximo;
            }

            return atual;
        }                        
    }
}