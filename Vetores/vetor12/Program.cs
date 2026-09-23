using System;

namespace vetor12
{
    class Program
    {
        static void Main()
        {
            int Qntdgols; // (Pode até apagar essa se não for usar)
            int SomaTot = 0;
            double media = 0; // Ajuste 2: Inicializada com zero

            int[] gols = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite os gols do galo no jogo {i + 1}: ");
                gols[i] = int.Parse(Console.ReadLine()!);
                
                // Ajuste 3: Tirei a soma daqui, o Main agora só lê os gols
            }

            // Ajuste 4: Chamar a função para ela fazer a mágica matemática
            calcularEstatisticas(gols, ref SomaTot, ref media);

            Console.WriteLine($"\n Total de gols nas 5 partidas: {SomaTot}");
            Console.WriteLine($"\n Média de gols por jogo: {media}");
            Console.ReadKey();
        }    

        static void calcularEstatisticas(int[] v, ref int soma, ref double media)               
        {
            for (int i = 0; i < 5; i++)
            {
                soma = soma + v[i]; // Ajuste 1: 'v' minúsculo e com o índice '[i]'
            }

            media = (double)soma / 5;
        }                          
    }
}