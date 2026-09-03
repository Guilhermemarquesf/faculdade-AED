using System;

using System.Formats.Asn1;

using System.Net.Http.Headers;

namespace vetor5
{
    class Program
    {
        static void Main()
        {
            int[] Vetor = new int[10];

            Random x = new Random();

            int Maior, Menor;

            double Media = 0;

            double Raio;

            double Área, Perimetro;

            for (int i = 0; i < 10; i++)
            {
                Vetor[i] = x.Next(1, 101);

                Console.Write($"{Vetor[i],7}");
            }

            Console.ReadKey();

            Maior = AchaMaior(Vetor);
            Menor = AchaMenor(Vetor);
            Media = CalcMedia(Vetor, ref Media);

            Console.Write($"Maior = {Maior}");
            Console.Write($"Menor = {Menor}");
            Console.Write($"Media = {Media}");

            Console.ReadKey();

            Console.WriteLine("Raio do circulo: ");
            Raio = double.Parse(Console.ReadLine()!);

            (Área, Perimetro) = CalcAreaPerimetro(Raio);

            Console.WriteLine($"\nArea: {Área}");
            Console.WriteLine($"\nPerimetro: {Perimetro}");

            Console.ReadKey();
        }

        static (double, double) CalcAreaPerimetro(double R)
        {
            double A = Math.PI * Math.Pow(R, 2);

            double P = 2 * Math.PI * R;

            return (A, P);
        }

        static int AchaMaior(int[] V)
        {
            int Maior = V[0];

            for (int i = 1; i < V.Length; i++)
            {
                if (V[i] > Maior)
                    Maior = V[i];
            }

            return Maior;
        }

        static int AchaMenor(int[] V)
        {
            int Menor = V[0];

            for (int i = 1; i < V.Length; i++)
            {
                if (V[i] < Menor)
                    Menor = V[i];
            }

            return Menor;
        }

        static double CalcMedia(int[] V, ref double Media)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Media += V[i];
            }

            Media = Media / V.Length;

            return Media;
        }
    }
}