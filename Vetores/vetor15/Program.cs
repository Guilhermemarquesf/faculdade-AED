using System; // Importa a biblioteca System, que contém classes como Console e Convert.

namespace vetor15 // Define o namespace do programa, organizando o código.
{
    struct Funcionario // Cria uma estrutura para armazenar os dados de um funcionário.
    {
        public string Nome; // Armazena o nome do funcionário.
        public Data DataNasc; // Armazena a data de nascimento do funcionário.
        public double Salario; // Armazena o salário do funcionário.
    }

    class Data // Cria a classe Data para guardar o dia e o mês de nascimento.
    {
        public string Dia = ""; // Armazena o dia da data de nascimento.
        public string Mes = ""; // Armazena o mês da data de nascimento.
    }

    class Program // Define a classe principal do programa.
    {
        static void Main() // Método principal, executado ao iniciar o programa.
        {
            Funcionario[] Cadastro = new Funcionario[3]; // Cria um vetor com capacidade para 3 funcionários.

            for (int i = 0; i < Cadastro.Length; i++) // Repete o bloco para cada funcionário do vetor.
            {
                Funcionario Func = new Funcionario { DataNasc = new Data() }; // Cria uma variável do tipo Funcionario com data inicializada.

                Console.WriteLine("Nome do Funcionario....."); // Mostra a mensagem pedindo o nome.
                Func.Nome = Console.ReadLine()!; // Lê o nome digitado pelo usuário e armazena no funcionário.

                Console.WriteLine("Data de nascimento - Dia: "); // Mostra a mensagem pedindo o dia.
                Func.DataNasc.Dia = Console.ReadLine()!; // Lê o dia e salva na propriedade Dia.

                Console.WriteLine("                    - Mes: "); // Mostra a mensagem pedindo o mês.
                Func.DataNasc.Mes = Console.ReadLine()!; // Lê o mês e salva na propriedade Mes.

                Console.WriteLine("Salario....."); // Mostra a mensagem pedindo o salário.
                Func.Salario = double.Parse(Console.ReadLine()!); // Lê o salário e converte para double.

                Cadastro[i] = Func; // Armazena o funcionário no vetor na posição i.
            }

            Console.Clear(); // Limpa a tela do console.

            foreach (Funcionario F in Cadastro) // Percorre cada funcionário do vetor.
            {
                Console.WriteLine($"{F.Nome} - Nasceu em {F.DataNasc.Dia} de {F.DataNasc.Mes}"); // Exibe o nome e a data de nascimento.
                Console.WriteLine($"Salario: R$ {F.Salario:F2}"); // Exibe o salário formatado com duas casas decimais.
            }

            Console.ReadKey(); // Pausa a execução até o usuário pressionar uma tecla.
        }
    }
}