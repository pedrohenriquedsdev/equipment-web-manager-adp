<<<<<<< HEAD
using GestaoDeEquipamentosWeb.ConsoleApp.Compartilhado;
=======
﻿using GestaoDeEquipamentosWeb.ConsoleApp.Compartilhado;
>>>>>>> v0
using GestaoDeEquipamentosWeb.ConsoleApp.Compartilhado.Arquivos;
using GestaoDeEquipamentosWeb.ConsoleApp.ModuloFabricante;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeEquipamentosWeb.ConsoleApp.Controllers;

<<<<<<< HEAD
//MVC
=======
// MVC - Model, View, Controller
>>>>>>> v0
public class FabricanteController : Controller
{
    private readonly IRepositorio<Fabricante> repositorioFabricante;

    public FabricanteController()
    {
        ContextoJson contexto = new ContextoJson();
        contexto.Carregar();

<<<<<<< HEAD
        repositorioFabricante = new RepositorioFabricanteEmArquivo(contexto);
=======
        repositorioFabricante =
            new RepositorioFabricanteEmArquivo(contexto);
>>>>>>> v0
    }

    [HttpGet]
    public ActionResult Listar()
    {
        List<Fabricante> fabricantes = repositorioFabricante.SelecionarTodos();

        return View(fabricantes);
    }

    [HttpGet]
    public ActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Cadastrar(string nome, string email, string telefone)
    {
        Fabricante novoFabricante = new Fabricante(nome, email, telefone);

        repositorioFabricante.Cadastrar(novoFabricante);

        return RedirectToAction(nameof(Listar));
    }

    [HttpGet]
    public ActionResult Editar(string id)
    {
        Fabricante? fabricante = repositorioFabricante.SelecionarPorId(id);

        if (fabricante == null)
            return RedirectToAction(nameof(Listar));

        return View(fabricante);
    }

    [HttpPost]
    public ActionResult Editar(string id, string nome, string email, string telefone)
    {
        Fabricante fabricanteAtualizado = new Fabricante(nome, email, telefone);

        repositorioFabricante.Editar(id, fabricanteAtualizado);

        return RedirectToAction(nameof(Listar));
    }

    [HttpGet]
    public ActionResult Excluir(string id)
    {
        Fabricante? fabricante = repositorioFabricante.SelecionarPorId(id);

        if (fabricante == null)
            return RedirectToAction(nameof(Listar));

        return View(fabricante);
    }

    [HttpPost]
    [ActionName("Excluir")]
    public ActionResult ExcluirConfirmado(string id)
    {
        Fabricante? fabricante = repositorioFabricante.SelecionarPorId(id);

        if (fabricante == null)
            return RedirectToAction(nameof(Listar));

        repositorioFabricante.Excluir(fabricante);

        return RedirectToAction(nameof(Listar));
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> v0
