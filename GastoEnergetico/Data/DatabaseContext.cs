using GastoEnergetico.Models.Categorias;
using GastoEnergetico.Models.Gastos;
using GastoEnergetico.Models.Itens;
using GastoEnergetico.Models.Parametros;
using Microsoft.EntityFrameworkCore;

namespace GastoEnergetico.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<CategoriasEntity> Categorias { get; set; }
        public DbSet<ItensEntity> Itens { get; set; }
        public DbSet<ParametrosEntity> Parametros { get; set; }

        public DbSet<GastosEntity> gastos { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {


        }
    }
}