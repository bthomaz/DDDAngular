using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDAngular.Dominio.Consumidores;
using DDDAngular.Dominio.Produtos;

namespace DDDAngular.Dominio.Carrinhos
{
    public class Carrinho
    {
        public Carrinho()
        {
            this.Consumidor = new Consumidor();
            this.Produtos = new List<Produto>();
        }

        public int IdCarrinho { get; set; }

        public Consumidor Consumidor { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
