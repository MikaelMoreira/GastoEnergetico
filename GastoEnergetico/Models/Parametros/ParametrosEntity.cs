using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.Models.Parametros
{
    public class ParametrosEntity
    {
        public int Id { get; set; }
        public decimal ValorKwh { get; set; }
        public decimal FaixaConsumoAlto { get; set; }
        public decimal FaixaConsumoMedio { get; set; }

        public ParametrosEntity()
        {
        }

        public ParametrosEntity(int id, decimal valorKwh, decimal faixaConsumoAlto, decimal faixaConsumoMedio)
        {
            Id = id;
            ValorKwh = valorKwh;
            FaixaConsumoAlto = faixaConsumoAlto;
            FaixaConsumoMedio = faixaConsumoMedio;
        }
    }
}
