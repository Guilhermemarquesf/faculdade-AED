using System;

namespace veetor2
{
    class Program
    {
        static void Main()
        {
           double a, b, c;
           double Delta;
           double CalcDelta ;

           Console.WriteLine("");
           Console.WriteLine("");
           Console.WriteLine("");






           Delta = CalcDelta(a, b, c);

           Console.WriteLine($"\n Delta = {Delta}");

           if (Delta < 0)
           {
                Console.Write("\n Nao existem Raizes Reais...");
           }
           else 
           {
            CalcRaizes(a, b, Delta, ref R1, ref R2); 
            Console.WriteLine($"Raiz 1 = {R1}");
            Console.WriteLine($"Raiz 2 = {R2}");
           }

           Console.ReadKey();
        }                             

        static double CalcDelta(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;

        }                

        static void CalcRaizes(double a, double b, double Delta, ref double R1, double R2);
        {
            R1 = (-b + Math.Sqrt(Delta)) / (2 * a);
            R2 = (-b + Math.Sqrt(Delta)) / (2 * a);
        }
#andregion        
    }
}