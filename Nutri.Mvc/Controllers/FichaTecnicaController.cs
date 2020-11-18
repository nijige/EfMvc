using System;
using Microsoft.AspNetCore.Mvc;
using Nutri.Mock;
using Nutri.Mvc.Models;
using Nutri.Mvc.Utils;

namespace Nutri.Controllers
{
    public class FichaTecnicaController : Controller
    {
        private readonly FichaTecnicaRepositoryFake _repository;
        public FichaTecnicaController(FichaTecnicaRepositoryFake repository)
        {
            _repository = repository;
        }
        public IActionResult Index(int? pageNumber)
        {
            if (pageNumber == null) pageNumber = 1;
            var lista = _repository.GetAll();
            var itensPorPagina = 5;
            PaginatedList<FichaTecnica> listaPaginada = PaginatedList<FichaTecnica>.Create(lista, pageNumber ?? 1, itensPorPagina);
            return View(listaPaginada);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FichaTecnica viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);
            _repository.Create(viewModel);
            TempDataUtil.Put(TempData, "viewModel", viewModel);
            return RedirectToAction("Details", new { message = "Cadastrado com sucesso!" });
        }

        public IActionResult Edit(Guid id)
        {
            var viewModel = _repository.GetById(id);
            return View(viewModel);
        }


        [HttpPost]
        public IActionResult Edit(FichaTecnica viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            _repository.Update(viewModel);
            TempDataUtil.Put(TempData, "viewModel", viewModel);
            return RedirectToAction("Details", new { message = "Atualizado com sucesso!" });
        }

        public IActionResult Delete(Guid id)
        {
            var viewModel = _repository.GetById(id);
            return View(viewModel);
        }


        [HttpPost]
        public IActionResult Delete(FichaTecnica viewModel)
        {
            _repository.Delete(viewModel.Id);
            return RedirectToAction("Index");
        }


        public IActionResult Details(string message)
        {
            ViewBag.Message = message;
            var viewModel = TempData.Get<FichaTecnica>("viewModel");
            return View(viewModel);
        }


        public IActionResult Pagination(int? pageNumber)
        {
            if (pageNumber == null) pageNumber = 1;
            var lista = _repository.GetAll();
            var itensPorPagina = 5;
            PaginatedList<FichaTecnica> listaPaginada = PaginatedList<FichaTecnica>.Create(lista, pageNumber ?? 1, itensPorPagina);
            return PartialView("_TabelaIndex", listaPaginada);
        }


        public IActionResult Search(int? pageNumber, string parametro)
        {
            if (parametro == null) parametro = "";
            var lista = _repository.Search(parametro);
            var itensPorPagina = 5;
            PaginatedList<FichaTecnica> listaPaginada = PaginatedList<FichaTecnica>.Create(lista, pageNumber ?? 1, itensPorPagina);
            return PartialView("_TabelaIndex", listaPaginada);
        }

    }
}