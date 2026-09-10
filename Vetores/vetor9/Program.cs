using System;

namespace vetor
{
    class Program
    {
        static void Main()
        {
            int n;

            Console.WriteLine("Digite um valor: ");
            n = int.Parse(Console.ReadLine()!);

            Imprime("Valor de n é", 1, n);

            Console.ReadKey();
        }

        static void Imprime(string texto, int nr, int qtdeVezes)
        {
            if (nr <= qtdeVezes)
            {
                Console.WriteLine($"{texto} {nr}");
                nr++;

                Imprime(texto, nr, qtdeVezes);
            }
        }
    }
}