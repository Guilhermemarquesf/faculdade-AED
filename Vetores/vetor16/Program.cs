using System;
namespace veotr16
{
    class Program
    {

        class Funcionario
        {
            private string _ID;

            public Funcionario()
            {
                _ID = Guid.NewGuid().ToString().Substring(4, 4).ToUpper();
            }

            public Funcionario(string x)
            {
                _ID = x;
            }

            public string ID
            {
                get { return _ID; }
                // set {_ID = Value; }
            }

            private string _Nome;
            public string Nome
            {
                get { return _Nome; }           
                set { _Nome = value; }
            }

            private double _Salario;        
            public double Salario
            {
                get { return _Salario; }               
                set {
                    if (value < 0) 
                    {
                        _Salario = -value;
                    }
                    else
                    {
                        _Salario = value;
                    }
                }
            }
            
            
        }
        static void Main()
        {
           Funcionario[] CadFunc = new Funcionario[3];
            
                for (int i = 0; i < 3; i++ )
                {
                    Funcionario Func = new Funcionario();

                    Console.Write("Nome ..........");
                    Func.Nome = Console.ReadLine() ?? string.Empty;

                    Console.Write("Salario..........");
                    Func.Salario = double.Parse(Console.ReadLine() ?? "0");

                    CadFunc[i] = Func;
                }

                Console.Clear();

                foreach(Funcionario F in CadFunc)
            {
                Console.WriteLine($"{F.Nome} - {F.ID}");
                Console.WriteLine($"R$ {F.Salario}");
            }

            Console.ReadKey();
        }                                             
    }
}