using GastoEnergetico.Models.Gastos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.RequestModels.Gasto
{
    public class AdicionarRequestModel : IDadosBasicosGastoModel
    {
        string IDadosBasicosGastoModel.Descricao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDadosBasicosGastoModel.Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDadosBasicosGastoModel.Categoria { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDadosBasicosGastoModel.Valor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDadosBasicosGastoModel.Recorrente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        //Campos formulario 



        public ICollection<string> ValidarEFiltrar()
        {

            var listaDeErros = new List<string>();

            return listaDeErros;
        }
    }
}
