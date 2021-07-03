using GastoEnergetico.Models.Categorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.RequestModels.Categorias
{
    public class AdicionarRequestModel : IDadosBasicosCategoriaModel
    {

        public string Id { get; set; }
        public string Descricao { get; set; }
        public string CategoriaPaiId { get; set; }


    }
}
