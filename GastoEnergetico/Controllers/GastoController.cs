using GastoEnergetico.Models;
using GastoEnergetico.Models.Categorias;
using GastoEnergetico.Models.Gastos;
using GastoEnergetico.Models.Itens;
using GastoEnergetico.Models.Parametros;
using GastoEnergetico.RequestModels.Gasto;
using GastoEnergetico.ViewModels.Gastos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace GastoEnergetico.Controllers
{
    public class GastoController : Controller
    {


        private readonly GastosService _gastosService;
        private readonly CategoriaService _categoriaService;

        public GastoController(GastosService gastosService, CategoriaService categoriaService)
        {
            _gastosService = gastosService;
            _categoriaService = categoriaService;
        }

        public IActionResult Index()

        //Passos para fazer uma listagem
        {

            //Criando um ViewModel contendo uma lista de dados dos Gastos a serem exibidos aos usuários
            var viewModel = new IndexViewModel()
            {

                MensagemSucesso = (string)TempData["formMensagemSucesso"],
                MensagemErro = (string)TempData["formMensagemErro"]

            };

            //Obter lista de entidade do tipo de gasto

            var listaDeGastos = _gastosService.obterTodos();

            //Processar a lista de entidades para coletar para a ViewModel apenas as informações necessarias


            foreach (GastosEntity gastosEntity in listaDeGastos)
            {
                viewModel.Gastos.Add(new Gastos()
                {
                    id = gastosEntity.id.ToString(),
                    Data = gastosEntity.Data.ToShortDateString(),
                    Categoria = gastosEntity.Categoria.Descricao,
                    Descricao = gastosEntity.Descricao,
                    Valor = gastosEntity.Valor.ToString("C"),
                    IsRecorrente = gastosEntity.Recorrente ? "Sim" : "Não"

                });
            }


            // Retornar a view junto com a ViewModel
            return View(viewModel);

        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            var viewModel = new AdicionarViewModel()
            {
                FormMensagensErro = (string[])TempData["formMensagensErro"]

            };


            var categorias = _categoriaService.obterTodos();

            foreach (var CategoriasEntity in categorias)
            {
                viewModel.Categorias.Add(new SelectListItem()
                {
                    Value = CategoriasEntity.id.ToString(),
                    Text = CategoriasEntity.Descricao

                });
            }


            return View(viewModel);
        }


        [HttpPost]
        public RedirectToActionResult Adicionar(AdicionarRequestModel requestModel)
        {


            var listaDeErros = requestModel.ValidarEFiltrar();

            if (listaDeErros.Count > 0)
            {

                TempData["formMensagensErro"] = listaDeErros;

                return RedirectToAction("Adicionar");

            }

            try
            {
                _gastosService.Adicionar(requestModel);
                TempData["formMensagemSucesso"] = "Gasto adicionado com sucesso";


                return RedirectToAction("Index");

            }
            catch (Exception exception)
            {
                TempData["formMensagensErro"] = new List<string> { exception.Message };

                return RedirectToAction("Adicionar");

            }

        }


        public IActionResult Categorias()
        {
            return View();
        }

        public IActionResult Itens()
        {
            return View();
        }

        public IActionResult Parametros()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}