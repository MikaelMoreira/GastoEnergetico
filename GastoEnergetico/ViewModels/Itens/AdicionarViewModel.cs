﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GastoEnergetico.Models.Itens;

namespace GastoEnergetico.ViewModels.Itens
{
    public class AdicionarViewModel : IDadosBasicosItensModel
    {

        public string Id { get; set; }
        public string Categoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DataFabricacao { get; set; }
        public string ConsumoWatts { get; set; }
        public string HorasUsoDiario { get; set; }


        public ICollection ValidarEFiltrar()
        {

            var listaErros = new List<string>();

            return listaErros;

        }     
    }
}
