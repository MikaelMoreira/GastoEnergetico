using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.ViewModels.Categorias
{
    public class IndexViewModel
    {

        public ICollection<Categoria> Categorias { get; set; }

        public IndexViewModel()
        {
            Categorias = new List<Categoria>();

        }
}     

        public class Categoria
        {
            public string Id { get; set; }
            public string Descricao { get; set; }
            public string CategoriaPaiId { get; set; }
        }
    }

