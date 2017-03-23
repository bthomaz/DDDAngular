using DDDAngular.Dominio.Consumidores;
using DDDAngular.Dominio.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDAngular.Persistencia
{
    public class EcomerceInicializer : CreateDatabaseIfNotExists<EcomerceContext>
    {
        protected override void Seed(EcomerceContext context)
        {
            base.Seed(context);
            CriarConsumidores(context);
            CriarProdutos(context);

        }

        private void CriarConsumidores(EcomerceContext context)
        {
            context.Consumidores.Add(new Consumidor { NomeConsumidor = "Consumidor 1", IdadeConsumidor = 18, DataCriacao = DateTime.Now });
            context.Consumidores.Add(new Consumidor { NomeConsumidor = "Consumidor 2", IdadeConsumidor = 24, DataCriacao = DateTime.Now });
            context.Consumidores.Add(new Consumidor { NomeConsumidor = "Consumidor 3", IdadeConsumidor = 10, DataCriacao = DateTime.Now });
        }

        private void CriarProdutos(EcomerceContext context)
        {
            context.Produtos.Add(new Produto { DescricaoProduto = "Produto 1", PrecoProduto = 10, Quantidade = 5, DataCriacao = DateTime.Now });
            context.Produtos.Add(new Produto { DescricaoProduto = "Produto 2", PrecoProduto = 3, Quantidade = 53, DataCriacao = DateTime.Now });
            context.Produtos.Add(new Produto { DescricaoProduto = "Produto 3", PrecoProduto = 44, Quantidade = 45, DataCriacao = DateTime.Now });
            context.Produtos.Add(new Produto { DescricaoProduto = "Produto 4", PrecoProduto = 1580, Quantidade = 2, DataCriacao = DateTime.Now });
            context.Produtos.Add(new Produto { DescricaoProduto = "Produto 5", PrecoProduto = 58, Quantidade = 1, DataCriacao = DateTime.Now });
            context.Produtos.Add(new Produto { DescricaoProduto = "Produto 6", PrecoProduto = 1, Quantidade = 0, DataCriacao = DateTime.Now });
        }
     
    }
}
