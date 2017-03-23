using DDDAngular.Dominio.Carrinhos;
using DDDAngular.Dominio.Consumidores;
using DDDAngular.Dominio.Produtos;
using DDDAngular.Persistencia.Carrinhos;
using DDDAngular.Persistencia.Consumidores;
using DDDAngular.Persistencia.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDAngular.Persistencia
{
    public class EcomerceContext : DbContext
    {

        public IDbSet<Consumidor> Consumidores { get; set; }

        public IDbSet<Produto> Produtos { get; set; }

        public IDbSet<Carrinho> Carrinhos { get; set; }

        public EcomerceContext() : base("DDDAngular")
        {
            Database.SetInitializer(new EcomerceInicializer());
        }

        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ConsumidorConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new CarrinhoConfiguration());
        }
    }
}
