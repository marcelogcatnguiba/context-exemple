namespace MyConnect.Entities
{
    public class Pedido : EntidadeBase
    {
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = new Cliente();
        public IEnumerable<Produto> Produtos { get; set; } = new List<Produto>();

    }
}