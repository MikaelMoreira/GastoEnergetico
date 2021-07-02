using System.ComponentModel.DataAnnotations;

namespace GastoEnergetico.Models.Parametros
{
    public class ParametrosEntity
    {
        [Key]public int id { get; set; }
        public decimal ValorKwh { get; set; }
        public decimal FaixaConsumoAlto { get; set; }
        public decimal FaixaConsumoMedio { get; set; }

        public ParametrosEntity()
        {
        }

        public ParametrosEntity(int id, decimal valorKwh, decimal faixaConsumoAlto, decimal faixaConsumoMedio)
        {
            this.id = id;
            ValorKwh = valorKwh;
            FaixaConsumoAlto = faixaConsumoAlto;
            FaixaConsumoMedio = faixaConsumoMedio;
        }
    }
}