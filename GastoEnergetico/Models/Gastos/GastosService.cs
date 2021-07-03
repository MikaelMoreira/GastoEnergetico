using GastoEnergetico.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GastoEnergetico.Models.Gastos;
using GastoEnergetico.Models.Categorias;

namespace GastoEnergetico.Models.Gastos
{
    public class GastosService
    {

        private readonly DatabaseContext    _databaseContext;
        private readonly CategoriaService _categoriaService;




        public GastosService(
            DatabaseContext databaseContext,
            CategoriaService categoriaService
            )
        {
            _categoriaService = categoriaService;
            _databaseContext = databaseContext;
        }





        public ICollection<GastosEntity> obterTodos()
        {
            return _databaseContext.gastos.Include(g => g.Categoria).ToList();
        }

        public GastosEntity ObterPorId(Guid id)
        {
  
                try
                {
                    return _databaseContext.gastos.Include(g => g.Categoria).First(g => g.id == id);
                }
                catch {
                    throw new Exception("Gasto de ID #" + id + "não encontrada");
                }
            }


        public GastosEntity Adicionar(IDadosBasicosGastoModel dadosBasicos)
        {

            var novoGasto = ValidarDadosBasicos(dadosBasicos);
            _databaseContext.gastos.Add(novoGasto);
            _databaseContext.SaveChanges();

            return novoGasto;

        }

        public GastosEntity Editar(
            
            Guid id,
            IDadosBasicosGastoModel dadosBasicos                      
        )
        {

            var gastoEntity = ObterPorId(id);
            gastoEntity = ValidarDadosBasicos(dadosBasicos, gastoEntity);
            _databaseContext.SaveChanges();

            return gastoEntity;

        }

        private GastosEntity ValidarDadosBasicos(
            IDadosBasicosGastoModel dadosBasicos,
            GastosEntity entidadeExistente = null
        )
        {

            //Instanciar ou utilizar entidade previamente instanciada
            var entidade = entidadeExistente ?? new GastosEntity();


            // Validar e Atribuir Descrição


            if(dadosBasicos.Descricao == null) {

                throw new Exception("A Descrição é obrigatorio");

            }

            if (dadosBasicos.Descricao.Length < 3)
            {
                throw new Exception("A Descrição informada deve conter pelo menos 3 caracteres");
            }

            try
            {
                var data = DateTime.Parse(dadosBasicos.Data);
                entidade.Data = data;

            }catch{

                throw new Exception("A data informada não possui um formado válido");
            }

            if(dadosBasicos.Categoria == null)
            {
                throw new Exception("A Categoria é obrigatoria");
            }
            entidade.Categoria = _categoriaService.ObterPorId(Convert.ToInt32(dadosBasicos.Categoria));

            if(dadosBasicos.Valor == null)
            {
                throw new Exception("O valor é obrigatorio");
            }

            try
            {
                var valor = Decimal.Parse(dadosBasicos.Valor);
                entidade.Valor = valor;
            } catch
            {
                throw new Exception("O valor informado não possui um formato válido");
            }

          
            return entidade;
        }
    }

    public interface IDadosBasicosGastoModel
    {

        public string Descricao { get; set; }
        public string Data { get; set; }
        public string Categoria { get; set; }
        public string Valor { get; set; }
        public string Recorrente { get; set; }

    }


}
