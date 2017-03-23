using DDDAngular.Dominio.Carrinhos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDAngular.Persistencia.Carrinhos
{
    public class CarrinhoConfiguration : EntityTypeConfiguration<Carrinho>
    {
        public CarrinhoConfiguration()
        {
            HasKey(p => p.IdCarrinho);

            HasRequired(p => p.Consumidor);
            HasRequired(p => p.Produtos);
        }
    }
}
