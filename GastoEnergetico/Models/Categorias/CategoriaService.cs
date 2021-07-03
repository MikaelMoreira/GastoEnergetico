using GastoEnergetico.Data;
using GastoEnergetico.Models.Gastos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.Models.Categorias
{
    public class CategoriaService
    {
        private readonly DatabaseContext _databaseContext;

        public CategoriaService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }


        public ICollection<CategoriasEntity> obterTodos()
        {
            return _databaseContext.Categorias.ToList(); //trazer só ela mesmo
        }


        public CategoriasEntity ObterPorId(int id)
        {

            try
            {
                return _databaseContext.Categorias.Find(id);
            } catch
            {
                throw new Exception("Categoria de ID #" + id + "não encontrada");

            }

        }

    }
}
