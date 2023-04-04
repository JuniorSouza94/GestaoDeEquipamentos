namespace GestaoDeEquipamentos.ConsoleApp
{
    public class Equipamento
    {
        public int IdEquipamento { get; set; }
        public string Nome { get; set; }
        public double PrecoAquisicao { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Fabricante { get; set; }

        public Equipamento(int idEquipamento, string nome, double precoAquisicao, string numeroSerie, DateTime dataFabricacao, string fabricante)
        {
            Nome = nome;
            PrecoAquisicao = precoAquisicao;
            NumeroSerie = numeroSerie;
            DataFabricacao = dataFabricacao;
            Fabricante = fabricante;
            IdEquipamento = idEquipamento;
        }
        public Equipamento()
        { }
        public override string ToString()
        {
            return $"Id: {IdEquipamento}\nNome: {Nome}\nPreço de aquisição: {PrecoAquisicao:C}\nNúmero de série: {NumeroSerie}\nData de fabricação: {DataFabricacao:dd/MM/yyyy}\nFabricante: {Fabricante}\n";
        }
    }

}