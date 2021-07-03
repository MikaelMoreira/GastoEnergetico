using GastoEnergetico.Models.Categorias;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.ViewModels.Categorias
{
    public class AdicionarViewModel : IDadosBasicosCategoriaModel
    {

        public string Id { get; set; }
        public string Descricao { get; set; }
        public string CategoriaPaiId { get; set; }

        public ICollection ValidarEFiltrar()
        {

            var listaErros = new List<string>();

            return listaErros;


        }






    }
}
