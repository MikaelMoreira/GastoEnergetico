using System;
using System.ComponentModel.DataAnnotations;

namespace GastoEnergetico.Models.Itens
{
    public class ItensEntity
    {
        [Key] public int id { get; set; }
        public int CategoriaId  { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFabricacao { get; set; }
        public decimal ConsumoWatts  { get; set; }
        public int  HorasUsoDiario { get; set; }

        public ItensEntity()
        {
        }

        public ItensEntity(int id, int categoriaId, string nome, string descricao, DateTime dataFabricacao, decimal consumoWatts, int horasUsoDiario)
        {
            this.id = id;
            CategoriaId = categoriaId;
            Nome = nome;
            Descricao = descricao;
            DataFabricacao = dataFabricacao;
            ConsumoWatts = consumoWatts;
            HorasUsoDiario = horasUsoDiario;
        }
    }
}