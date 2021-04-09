using System;
using System.Collections.Generic;
using System.Linq;

namespace ProvaPraticaUCDB.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Valor { get; private set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();

        public Pedido()
        {
        }

        public Pedido(int id, DateTime dataVencimento)
        {
            Id = id;
            DataVencimento = dataVencimento;
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }

        public void AplicarDesconto(double valor)
        {
            if (DataVencimento >= new DateTime())
            {
                Valor = Valor -= valor;
            }
        }

        public void TotalPedido()
        {
            Valor = Produtos.Sum(produto => produto.Valor);
        }
    }
}
