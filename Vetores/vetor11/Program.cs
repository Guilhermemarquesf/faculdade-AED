using System;

namespace vetor
{
    class Program
    {
        static void Main()
        {
           int x, 
           int soma = 0, 
           int result;

           Console.WriteLIne("x = ");
           x = int.Parse(Console.ReadLine()!)

            result = soma(x);

            Console.WriteLIne($"\n Soma = {result}");

            result = soma(1, x);

            Console.WriteLIne($"\n Soma = {result}");

            Console.ReadKey();
        }                     

        static int Soma (int x)
        {
            int S = x;

            if (x == 0)
            {
                S = 0;
            }
            else
            S = S + Soma (x - 1);

            return S;
        }    

        static int soma (int VInicial, int VFinal)
        {
            
            int S = VInicial;

            if (VInicial == VFinal)
            {
                return S;
            }
            else
                return S + Soma(VInicial + 1, VFinal);
        }
        
                            
    }
}