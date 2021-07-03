using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.ViewModels.Gastos
{
    public class AdicionarViewModel
    {

        public string[] FormMensagemErro { get; set;}

        public ICollection<SelectListItem> Categorias { get; set; }

        public AdicionarViewModel()
        {

            Categorias = new List<SelectListItem>
            {
                new SelectListItem("Selecione", "")

            };
        }
    }
}
