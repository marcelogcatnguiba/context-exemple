namespace MyConnect.Entities
{
    public class Produto : EntidadeBase
    {
        public string Descricao { get; set; } = string.Empty;
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; } = new();
    }
}