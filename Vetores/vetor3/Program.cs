using System;

namespace vetor3
{
    class Program
    {
        static void Main()
        {
           int x, y, z;

           (x, y, z) = MyFunção();

           Console.WriteLine($"Os elementos sao {x} - {y} - {z}");

           Console.ReadKey();

           x = MyFunção().Item1;

           Console.WriteLine($"O primeiro elemento é: {x}");

           Console.ReadKey();
        }

        static (int, int, int) MyFunção()
        {
            return (10, 20, 30);
        }                                            
    }
}