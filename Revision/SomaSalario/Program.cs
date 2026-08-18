using System;

namespace somasalario
{
    class Program
    {
        static void Main()
        {
            string Nome;
            char Sexo;
            double Salario;

            string NomeSalario = "";
            int QtdHomens = 0;
            double MediaSalarioHomens = 0;
            double SomaSalarioHomens = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Digite seu nome: ");
                Nome = Console.ReadLine()!;

                Console.WriteLine("Me diga seu sexo (M/F): ");
                Sexo = char.Parse(Console.ReadLine()!.ToUpper());

                Console.WriteLine("Digite seu salario: ");
                Salario = double.Parse(Console.ReadLine()!);
                
                if (Sexo == 'M')
                {
                    SomaSalarioHomens += Salario;
                    QtdHomens++;
                }
            }

            if (QtdHomens > 0)
            {
                MediaSalarioHomens = SomaSalarioHomens / QtdHomens;
            }

            Console.WriteLine($"\nTotal de homens: {QtdHomens}");
            Console.WriteLine($"Soma do salario dos homens: {SomaSalarioHomens:C}");
            Console.WriteLine($"Media do salario dos homens: {MediaSalarioHomens:C}");
        }                                             
    }
}
