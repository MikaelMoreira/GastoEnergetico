using GastoEnergetico.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.Models.Itens
{
    public class ItensService : IDadosBasicosItensModel
    {
        public string Id { get; set; }
        public string Categoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DataFabricacao { get; set; }
        public string ConsumoWatts { get; set; }
        public string HorasUsoDiario { get; set; }

        private readonly DatabaseContext _dataBaseContext;

        public ItensService(DatabaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public ICollection<ItensEntity> BuscarTodos()
        {
            return _dataBaseContext.Itens
                .Include(i => i.Categoria)
                .ToList();
        }

        public ICollection<ItensEntity> ObterTodos()
        {
            return _dataBaseContext.Itens.Include(c => c.Categoria).ToList();
        }

        public ICollection<ItensEntity> ObterTodosPorCategoria(int id)
        {
            return _dataBaseContext.Itens.Include(c => c.Categoria).Where(c => c.Id == id).ToList();
        }
    }

    public interface IDadosBasicosItensModel
    {
        public string Id { get; set; }
        public string Categoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DataFabricacao { get; set; }
        public string ConsumoWatts { get; set; }
        public string HorasUsoDiario { get; set; }
    }


}
