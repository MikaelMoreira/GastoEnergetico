using GastoEnergetico.Models.Categorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.Models.Gastos
{
    public class GastosEntity
    {

        public Guid id { get; set; }
        public String Descricao { get; set; }
        public DateTime Data { get; set; }
        public CategoriasEntity Categoria { get; set; }
        public Decimal Valor { get; set; }
        public bool Recorrente { get; set; }

        public GastosEntity()
        {
            id = new Guid();   //sempre q insta
        }
    }
}
