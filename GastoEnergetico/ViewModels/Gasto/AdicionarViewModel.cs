using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace GastoEnergetico.ViewModels.Gastos
{
    public class AdicionarViewModel
    {

        public string[] FormMensagensErro { get; set; }

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
