using System.ComponentModel.DataAnnotations;

namespace GastoEnergetico.Models.Categorias
{
    public class CategoriasEntity
    {
        [Key] public int id { get; set; }
        public string Descricao { get; set; }
        public int CategoriaPaiId { get; set; }

        public CategoriasEntity()
        {
        }

        public CategoriasEntity(int id, string descricao, int categoriaPaiId)
        {
            this.id = id;
            Descricao = descricao;
            CategoriaPaiId = categoriaPaiId;
        }
    }
}