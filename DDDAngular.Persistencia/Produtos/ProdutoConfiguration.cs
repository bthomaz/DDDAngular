using DDDAngular.Dominio.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDAngular.Persistencia.Produtos
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {

        public ProdutoConfiguration()
        {
            HasKey(c => c.IdProduto);

            Property(c => c.DescricaoProduto)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200);

            Property(c => c.PrecoProduto)
                .IsRequired()
                .HasPrecision(18, 2);

            Property(c => c.DataCriacao)
                .IsRequired();


        }
    }
}
