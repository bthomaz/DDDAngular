using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDAngular.Dominio.Consumidores
{
    public class Consumidor
    {
        public int IdConsumidor { get; set; }

        public String NomeConsumidor { get; set; }

        public int IdadeConsumidor { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}
