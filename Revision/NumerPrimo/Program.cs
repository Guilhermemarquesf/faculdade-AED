using System;

namespace numeroPrimo
{
    class Program
    {
        static void Main()
        {
           int QtdeDiv;

           for (int n = 2; n <= 50; n++ )
            {
                QtdeDiv = 0;

                for (int Div = 1; Div <= n; Div++)
                {
                    if(n % 2 Div == 0) 
                    {
                        QtdeDiv++;
                    }
                }

                if (QtdeDiv == 2)
                {
                    Console.WriteLine($"{n,5}");
                }
            }

            Console.WriteLine("");
        }                                             
    }
}