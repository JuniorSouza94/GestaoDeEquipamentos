namespace GestaoDeEquipamentos.ConsoleApp
{
    public static class Metodos
    {
        public static List<Equipamento> inventario = new List<Equipamento>();
        public static List<Chamado> chamados = new List<Chamado>();
        public static void RegistrarEquipamento()
        {
            Console.WriteLine("Digite o id do equipamento: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do equipamento: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o preço de aquisição: ");
            double precoAquisicao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de série: ");
            string numeroSerie = Console.ReadLine();

            Console.WriteLine("Digite a data de fabricação (dd/mm/yyyy): ");
            DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o fabricante: ");
            string fabricante = Console.ReadLine();

            Equipamento equipamento = new Equipamento(id, nome, precoAquisicao, numeroSerie, dataFabricacao, fabricante);
            inventario.Add(equipamento);

            Console.WriteLine("Equipamento registrado com sucesso!");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }
        public static void VisualizarEquipamentos()
        {
            Console.WriteLine("Equipamentos registrados:");
            Console.WriteLine();

            foreach (Equipamento equipamento in inventario)
            {
                Console.WriteLine($"Nome: {equipamento.Nome}");
                Console.WriteLine($"Preço de aquisição: R${equipamento.PrecoAquisicao:F2}");
                Console.WriteLine($"Número de série: {equipamento.NumeroSerie}");
                Console.WriteLine($"Data de fabricação: {equipamento.DataFabricacao.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Fabricante: {equipamento.Fabricante}");
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void EditarEquipamento()
        {
            Console.WriteLine("Digite o número de série do equipamento a ser editado: ");
            string numeroSerie = Console.ReadLine();

            Equipamento equipamento = inventario.Find(e => e.NumeroSerie == numeroSerie);

            if (equipamento == null)
            {
                Console.WriteLine("Equipamento não encontrado!");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Digite o novo nome do equipamento (deixe em branco para manter o atual): ");
            string novoNome = Console.ReadLine();

            if (!string.IsNullOrEmpty(novoNome))
            {
                equipamento.Nome = novoNome;
            }

            Console.WriteLine("Digite o novo preço de aquisição (deixe em branco para manter o atual): ");
            string novoPrecoAquisicaoStr = Console.ReadLine();

            if (!string.IsNullOrEmpty(novoPrecoAquisicaoStr))
            {
                double novoPrecoAquisicao = double.Parse(novoPrecoAquisicaoStr);
                equipamento.PrecoAquisicao = novoPrecoAquisicao;
            }

            Console.WriteLine("Digite a nova data de fabricação (dd/mm/yyyy) (deixe em branco para manter a atual): ");
            string novaDataFabricacaoStr = Console.ReadLine();

            if (!string.IsNullOrEmpty(novaDataFabricacaoStr))
            {
                DateTime novaDataFabricacao = DateTime.Parse(novaDataFabricacaoStr);
                equipamento.DataFabricacao = novaDataFabricacao;
            }

            Console.WriteLine("Digite o novo fabricante (deixe em branco para manter o atual): ");
            string novoFabricante = Console.ReadLine();

            if (!string.IsNullOrEmpty(novoFabricante))
            {
                equipamento.Fabricante = novoFabricante;
            }

            Console.WriteLine("Equipamento editado com sucesso!");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }
        public static void ExcluirChamado()
        {
            Console.WriteLine("Digite o número do chamado que deseja excluir: ");
            int numChamado = int.Parse(Console.ReadLine());

            Chamado chamado = chamados.Find(c => c.IdChamado == numChamado);

            if (chamado != null)
            {
                chamados.Remove(chamado);
                Console.WriteLine("Chamado removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Chamado não encontrado!");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void EditarChamado()
        {
            Console.WriteLine("Digite o número do chamado que deseja editar: ");
            int numChamado = int.Parse(Console.ReadLine());

            Chamado chamado = chamados.Find(c => c.IdChamado == numChamado);

            if (chamado != null)
            {
                Console.WriteLine("Digite a descrição do chamado: ");
                string descricao = Console.ReadLine();

                Console.WriteLine("Digite a data de abertura do chamado (dd/mm/yyyy): ");
                DateTime dataAbertura = DateTime.Parse(Console.ReadLine());

                chamado.Descricao = descricao;
                chamado.DataAbertura = dataAbertura;

                Console.WriteLine("Chamado editado com sucesso!");
            }
            else
            {
                Console.WriteLine("Chamado não encontrado!");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void VisualizarChamados()
        {
            if (chamados.Count == 0)
            {
                Console.WriteLine("Nenhum chamado registrado.");
            }
            else
            {
                foreach (Chamado chamado in chamados)
                {
                    Console.WriteLine($"Número do chamado: {chamado.IdChamado}");
                    Console.WriteLine($"Equipamento: {chamado.Equipamento.Nome}");
                    Console.WriteLine($"Descrição: {chamado.Descricao}");
                    Console.WriteLine($"Data de abertura: {chamado.DataAbertura.ToString("dd / MM / yyyy")}");
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void RegistrarChamado()
        {
            Console.WriteLine("Digite o número do equipamento que precisa de manutenção: ");
            int numEquipamento = int.Parse(Console.ReadLine());

            Equipamento equipamento = inventario.Find(e => e.IdEquipamento == numEquipamento);

            if (equipamento != null)
            {
                Console.WriteLine("Digite a descrição do chamado: ");
                string descricao = Console.ReadLine();

                Console.WriteLine("Digite a data de abertura do chamado (dd/mm/yyyy): ");
                DateTime dataAbertura = DateTime.Parse(Console.ReadLine());

                Chamado chamado = new Chamado();
                chamado.IdChamado = chamados.Count + 1;
                chamado.Equipamento = equipamento;
                chamado.Descricao = descricao;
                chamado.DataAbertura = dataAbertura;

                chamados.Add(chamado);

                Console.WriteLine("Chamado registrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Equipamento não encontrado!");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void ExcluirEquipamento()
        {
            Console.WriteLine("Digite o número de série do equipamento a ser excluído:");
            string numeroSerie = Console.ReadLine();

            bool encontrado = false;

            foreach (Equipamento equipamento in inventario)
            {
                if (equipamento.NumeroSerie == numeroSerie)
                {
                    encontrado = true;
                    inventario.Remove(equipamento);
                    Console.WriteLine("Equipamento removido com sucesso!");
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Equipamento não encontrado!");
            }
            Console.ReadKey();
            Console.Clear();

        }

    }
}