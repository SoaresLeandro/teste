namespace ProvaPraticaUCDB.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public Pedido Pedido { get; set; }
        public int PedidoId { get; set; }

        public Produto()
        {
        }

        public Produto(int id, string nome, double valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }
    }
}
