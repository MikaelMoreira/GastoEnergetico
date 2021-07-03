using GastoEnergetico.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.Models.Itens
{
    public class ItensService
    {

        private readonly DatabaseContext _databaseContext;

        public ItensService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
    }
}
