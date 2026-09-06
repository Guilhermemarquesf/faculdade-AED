using System;

namespace vetor7
{
    class Program
    {
        static void Main()
        {
            int n;

           Console.WriteLine("Digite um numero:");
           n = int.Parse(Console.ReadLine()!);

           bool resultado = EhPar(n);

            if (resultado == true)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Ímpar");
            }


        }  

        static bool EhPar(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}