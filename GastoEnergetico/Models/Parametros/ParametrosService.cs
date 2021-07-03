using GastoEnergetico.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastoEnergetico.Models.Parametros
{
    public class ParametrosService
    {
        private readonly DatabaseContext databaseContext;

        public ParametrosService(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
    }
}
