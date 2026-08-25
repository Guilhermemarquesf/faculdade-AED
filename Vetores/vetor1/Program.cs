using System;

namespace vetores 
{
    class Program
    {
        static int main()
        {
           int Fat = 1;
           int n;
           
           Console.WriteLine("n = ");
           n = int.Parse(Console.ReadLine()!);

           Fat = CalcFat(n);

           Console.WriteLine($"Fatorial = {fat}");

           Console.ReadLine();

           static int CalcFat(int x)
           {
                int Result = 1;

                for (int i = 1; i <= x; i++)
                    result = 1;

                return Result;    
           }



        }                                             
    }
}