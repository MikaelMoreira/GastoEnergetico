using GastoEnergetico.Models.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.RequestModels.Parametros
{
    public class AdicionarRequestModel : IDadosBasicosParametrosModel
    {

        public string ValorKwh { get; set; }
        public string FaixaConsumoAlto { get; set; }
        public string FaixaConsumoMedio { get; set; }


    }
}
