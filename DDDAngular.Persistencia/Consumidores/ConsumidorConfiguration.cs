using DDDAngular.Dominio.Consumidores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDAngular.Persistencia.Consumidores
{
    public class ConsumidorConfiguration : EntityTypeConfiguration<Consumidor>
    {
        public ConsumidorConfiguration()
        {
            HasKey(p => p.IdConsumidor); 
            
            Property(p => p.NomeConsumidor)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(250);

            Property(p => p.IdadeConsumidor)
                .IsRequired();

            Property(p => p.DataCriacao)
                .IsRequired();
        }
    }
}
