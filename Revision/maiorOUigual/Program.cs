using System;
using System.ComponentModel;

namespace comparaçao
{
    class Program
    {
        static void Main()
        {
           int maior;
           int n1, n2, n3;

           Console.WriteLine("Digite o primeiro numero: ");
           n1 = int.Parse(Console.ReadLine()!);

           Console.WriteLine("Digite o sugundo numero: ");
           n2 = int.Parse(Console.ReadLine()!);

           Console.WriteLine("Digite o terceiro numero: ");
           n3 = int.Parse(Console.ReadLine()!); 

           maior = n1;

           if (n2 > maior)
            {
                maior = n2;
            }
            if (n3 > maior)
            {
                maior = n3;
            }

            Console.WriteLine("O maior numero é:" + maior);


        }                                             
    }
}