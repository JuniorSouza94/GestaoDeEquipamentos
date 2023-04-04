namespace GestaoDeEquipamentos.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {                 
                Console.WriteLine("----- MENU PRINCIPAL -----");
                Console.WriteLine("1. Registrar equipamento");
                Console.WriteLine("2. Visualizar equipamentos registrados");
                Console.WriteLine("3. Editar equipamento");
                Console.WriteLine("4. Excluir equipamento");
                Console.WriteLine("5. Registrar chamado de manutenção");
                Console.WriteLine("6. Visualizar chamados registrados");
                Console.WriteLine("7. Editar chamado");
                Console.WriteLine("8. Excluir chamado");
                Console.WriteLine("9. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Metodos.RegistrarEquipamento();
                        break;
                    case 2:
                        Metodos.VisualizarEquipamentos();
                        break;
                    case 3:
                        Metodos.EditarEquipamento();
                        break;
                    case 4:
                        Metodos.ExcluirEquipamento();
                        break;
                    case 5:
                        Metodos.RegistrarChamado();
                        break;
                    case 6:
                        Metodos.VisualizarChamados();
                        break;
                    case 7:
                        Metodos.EditarChamado();
                        break;
                    case 8:
                        Metodos.ExcluirChamado();
                        break;
                    case 9:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine();

            } while (opcao != 9);
        }
    }

}