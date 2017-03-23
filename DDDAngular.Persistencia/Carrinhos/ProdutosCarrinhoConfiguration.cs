using DDDAngular.Dominio.Carrinhos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDAngular.Persistencia.Carrinhos
{
    public class ProdutosCarrinhoConfiguration : EntityTypeConfiguration<ProdutosCarrinho>
    {
        public ProdutosCarrinhoConfiguration()
        {
            HasKey(c => c.IdProdutosCarrinho);

            HasRequired(c => c.Carrinho);
            HasRequired(c => c.Produto);
        }
    }
}
