using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.ViewModels.Gastos
{
    public class IndexViewModel
    {
        public ICollection<Gastos> Gastos { get; set; }
        public string MensagemSucesso { get; set; }
        public string MensagemErro { get; set; }

        public IndexViewModel()
        {
            Gastos = new List<Gastos>();
        }
    }




    public class Gastos
    {

        public string id { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }
        public string Categoria { get; set; }
        public string Valor { get; set; }
        public string IsRecorrente { get; set; }




    }


}
