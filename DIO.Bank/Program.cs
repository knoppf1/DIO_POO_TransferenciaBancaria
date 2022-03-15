using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                    // ListarContas();
                    Console.WriteLine($"Case {opcaoUsuario}");
                    break;

                    case "2":
                    // InserirContas();
                    Console.WriteLine($"Case {opcaoUsuario}");
                    break;

                    case "3":
                    // Transferir();
                    Console.WriteLine($"Case {opcaoUsuario}");
                    break;

                    case "4":
                    // Sacar();
                    Console.WriteLine($"Case {opcaoUsuario}");
                    break;

                    case "5":
                    // Depositar();
                    Console.WriteLine($"Case {opcaoUsuario}");
                    break;

                    case "C":
                    Console.Clear();
                    Console.WriteLine(opcaoUsuario);
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por usar nossos serviços");
            Console.ReadLine();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor!!!");
            Console.WriteLine("Informe opção desejada:");
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");

            Console.WriteLine();
            string opcaoUsuario =  Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;



        }




    }
}
