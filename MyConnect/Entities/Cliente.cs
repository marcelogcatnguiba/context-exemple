namespace MyConnect.Entities
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; } = string.Empty;
        public IEnumerable<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}