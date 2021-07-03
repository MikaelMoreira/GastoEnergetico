using GastoEnergetico.Models.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.ViewModels.Parametros
{
    public class AdicionarViewModel : IDadosBasicosParametrosModel
    {
        public string Id { get; set; }
        public string ValorKwh { get; set; }
        public string FaixaConsumoAlto { get; set; }
        public string FaixaConsumoMedio { get; set; }

        public ICollection<string> ValidarEFiltrar()
        {
            var listaErros = new List<string>();

            return listaErros;
        }


    }
}
