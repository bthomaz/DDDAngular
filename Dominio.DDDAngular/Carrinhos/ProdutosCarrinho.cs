using DDDAngular.Dominio.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDAngular.Dominio.Carrinhos
{
    public class ProdutosCarrinho
    {
        public ProdutosCarrinho()
        {
            this.Carrinho = new Carrinho();
            this.Produto = new Produto();
        }

        public int IdProdutosCarrinho { get; set; }

        public Carrinho Carrinho { get; set; }

        public Produto Produto { get; set; }
    }
}
