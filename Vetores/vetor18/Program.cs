using System;

namespace vetor18
{
    struct Jogador 
    {
        public string Nomes;
        public int GolsMarcados;
        public int Partidasjogadas;
    }

    class Program
    {
        static void Main()
        {
            Jogador[] Atletas = new Jogador[4];

            for (int i = 0; i < Atletas.Length; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1} jogador: ");
                Atletas[i].Nomes = Console.ReadLine()!;

                Console.WriteLine("Gols marcados: ");
                Atletas[i].GolsMarcados = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Partidas jogadas: ");
                Atletas[i].Partidasjogadas = int.Parse(Console.ReadLine()!);
            }

            // 1. Declarando as variáveis antes de chamar o método
            int totalPartidas = 0;
            double mediaGols = 0;

            // 2. Chamando o método corretamente
            CalcularEstatisticas(Atletas, ref totalPartidas, ref mediaGols);

            // Exibindo o resultado final
            Console.WriteLine($"\nTotal de partidas jogadas pelo time: {totalPartidas}");
            Console.WriteLine($"Média geral de gols: {mediaGols:F2}");

            Console.ReadKey();
        }    

        static void CalcularEstatisticas(Jogador[] v, ref int somaPartidas, ref double media)
        {
            int somaGols = 0;

            for (int i = 0; i < v.Length; i++)
            {
                somaPartidas = somaPartidas + v[i].Partidasjogadas;
                somaGols = somaGols + v[i].GolsMarcados;
            }

            media = (double)somaGols / v.Length;
        }                                     
    }
}