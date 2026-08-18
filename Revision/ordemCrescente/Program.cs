using System;
using System.Data;
using System.Threading; // Necessário para o Thread.Sleep funcionar

namespace ordem 
{ 
    class Program 
    { 
        static void Main() 
        { 
            int Op = 0; 
            do 
            { 
                Console.Clear(); 
                Console.WriteLine("\n Menu Opções:"); 
                Console.WriteLine(" 1 - Toca um beep"); 
                Console.WriteLine(" 2 - Troca a Cor de Letra e Fundo"); 
                Console.WriteLine(" 3 - Alterna"); 
                Console.WriteLine(" 4 - Sair"); 
                Console.Write("\n Digite uma Opção: "); 
                
                Op = int.Parse(Console.ReadLine()!); 
                
                switch (Op) 
                { 
                    case 1: 
                        Console.Beep(100, 9); // Adicionado parâmetros para testar o som
                        break; 
                    case 2: 
                        Console.BackgroundColor = ConsoleColor.DarkGreen; 
                        Console.ForegroundColor = ConsoleColor.Black; 
                        Console.WriteLine("Texto na cor preta com fundo verde..."); 
                        Console.ReadKey(); 
                        Console.ResetColor(); 
                        Console.WriteLine("Texto na cor normal..."); 
                        break; 
                    case 3: 
                        Console.Title = "Si/ADS PUC Minas Betim"; 
                        Console.ReadKey(); 
                        break; 
                    case 4: 
                        Console.WriteLine("Saindo do programa"); 
                        Thread.Sleep(10); 
                        return; // Sai do método Main diretamente
                } 
                
                Console.WriteLine("\n\nESC para Sair ou outra Tecla para Continuar"); 
            } while(Console.ReadKey().Key != ConsoleKey.Escape); 
        } 
    } 
}
