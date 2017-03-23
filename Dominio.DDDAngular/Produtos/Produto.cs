using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDAngular.Dominio.Produtos
{
    public class Produto
    {
        public int IdProduto { get; set; }

        public String DescricaoProduto { get; set; }

        public Decimal PrecoProduto { get; set; }

        public int Quantidade { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}
