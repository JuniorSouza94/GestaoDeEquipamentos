namespace GestaoDeEquipamentos.ConsoleApp
{
    public class Chamado
    {
        public int IdChamado { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Equipamento Equipamento { get; set; }
        public DateTime DataAbertura { get; set; }       
        
        public Chamado(int idChamado, string titulo, string descricao, Equipamento equipamento, DateTime dataAbertura)
        {
            IdChamado = idChamado;
            Titulo = titulo;
            Descricao = descricao;
            Equipamento = equipamento;
            DataAbertura = dataAbertura;
        }
        public Chamado()
        { }
        public override string ToString()
        {
            return $"IdChamado: {IdChamado}, Titulo: {Titulo}, Descricao: {Descricao}, Equipamento: {Equipamento}, DataAbertura: {DataAbertura}";
        }

    }

}