using System;

namespace vetor10
{
    class Program
    {
        static void Main(string[] args)
        {
            double TMedia, TMaior = 0;
            int DiaTMaior = 0;
            int DiasTAcima = 0, DiasTAbaixo = 0;
            double[] Temperaturas = new double[7];

            for (int i = 0; i < Temperaturas.Length; i++)
            {
                Console.Write($"\nDigite a temperatura {i + 1}: ");
                Temperaturas[i] = double.Parse(Console.ReadLine()!);
            }

            TMedia = CalcMedia(Temperaturas);
            CalcDiasTAcimaAbaixo(Temperaturas, TMedia, ref DiasTAcima, ref DiasTAbaixo);
            CalcTMaior(Temperaturas, ref TMaior, ref DiaTMaior);

            Console.WriteLine($"\nTemperatura média: {TMedia:F2} °C");
            Console.WriteLine($"\n{DiasTAcima} com temperatura acima da média");
            Console.WriteLine($"\n{DiasTAbaixo} com temperatura abaixo da média");
            Console.WriteLine($"\nA maior temperatura da semana foi {TMaior:F2} °C no dia {DiaTMaior}");

            Console.ReadKey();
        }

        static double CalcMedia(double[] T)
        {
            double soma = 0;

            for (int i = 0; i < T.Length; i++)
            {
                soma += T[i];
            }

            return soma / T.Length;
        }

        static void CalcTMaior(double[] T, ref double TMaior, ref int DiaTMaior)
        {
            TMaior = T[0];
            DiaTMaior = 1;

            for (int i = 1; i < T.Length; i++)
            {
                if (T[i] > TMaior)
                {
                    TMaior = T[i];
                    DiaTMaior = i + 1;
                }
            }
        }

        static void CalcDiasTAcimaAbaixo(double[] T, double TMedia, ref int DiasTAcima, ref int DiasTAbaixo)
        {
            DiasTAcima = 0;
            DiasTAbaixo = 0;

            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] > TMedia)
                {
                    DiasTAcima++;
                }
                else if (T[i] < TMedia)
                {
                    DiasTAbaixo++;
                }
            }
        }
    }
}