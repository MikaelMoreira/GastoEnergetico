using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.ViewModels.Home
{
    public class IndexViewModel
    {
        public ICollection<TotalConsumo> totalConsumos { get; set; }
        public ICollection<CategoriaQueConsome> CategoriasQueMaisConsomem { get; set; }
        public ICollection<ItemQueConsome> ItensQueMaisConsomem { get; set; }

        public IndexViewModel()
        {
            CategoriasQueMaisConsomem = new List<CategoriaQueConsome>();
            ItensQueMaisConsomem = new List<ItemQueConsome>();
            totalConsumos = new List<TotalConsumo>();
        }  
    }
}


public class TotalConsumo
{
    public string FaixaDeConsumo { get; set; }
    public string ConsumoMensalWatts { get; set; }
    public string ValorMensalKwh { get; set; }

}

public class ItemQueConsome
{
    public string Posicao { get; set; }
    public string NomeItem { get; set; }
    public string NomeCategoriaItem { get; set; }
    public string ConsumoMensalKwh { get; set; }
    public string ValorMensalKwh { get; set; }

}

public class CategoriaQueConsome
{

    public string Posicao { get; set; }
    public string NomeCategoria { get; set; }
    public string ConsumoMensalKwh { get; set; }
    public string ValorMensalKwh { get; set; }
}

