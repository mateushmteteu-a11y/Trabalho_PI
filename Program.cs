class Program
{
    static void Main(string[] args)
    {
         int opcao = 0;

        do
        {
            Console.Clear();

            Console.WriteLine(" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
            Console.WriteLine("|       SISTEMA DE ASSISTENCIA TECNICA        |");
            Console.WriteLine("|_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _|");
            Console.WriteLine("|1 - Cadastro de Clientes                     |");
            Console.WriteLine("|2 - Cadastro de Objetos                      |");
            Console.WriteLine("|3 - Cadastro de Funcionarios                 |");
            Console.WriteLine("|4 - Cadastro de Ordens de Servico            |");
            Console.WriteLine("|_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _|");
            Console.WriteLine("|5 - Consultar Registros                      |");
            Console.WriteLine("|6 - Atualizar Registros                      |");
            Console.WriteLine("|7 - Excluir Registros                        |");
            Console.WriteLine("|_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _|");
            Console.WriteLine("|8 - Sair                                     |");
            Console.WriteLine("|_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _|");

            Console.Write("Escolha uma opcao: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
            Console.WriteLine("Opcao invalida!");
            Console.ReadKey();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Cadastro de Clientes");
                        break;

                case 2:
                    Console.WriteLine("Cadastro de Objetos");
                        break;

                case 3:
                    Console.WriteLine("Cadastro de Funcionarios");
                        break;

                case 4:
                    Console.WriteLine("Cadastro de Ordens de Servico");
                        break;

                case 5:
                    Console.WriteLine("Consulta de Registros");
                        break;

                case 6:
                    Console.WriteLine("Atualizacao de Registros");
                        break;

                case 7:
                    Console.WriteLine("Exclusao de Registros");
                        break;

                case 8:
                    Console.WriteLine("Sistema encerrado!");
                        break;

                default:
                    Console.WriteLine("Opcao invalida!");
                        break;
            }

            if (opcao != 8)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcao != 8);
    }
}