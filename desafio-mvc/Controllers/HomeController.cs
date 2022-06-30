using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using desafio_mvc.Models;
using desafio_mvc.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace desafio_mvc.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUnitOfWork _uof;

        public HomeController(IUnitOfWork uof, UserManager<IdentityUser> UserManager)
        {
            _userManager = UserManager;
            _uof = uof;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ReceitaPreferidos = _uof.ReceitaRepository.Get().Where(p => p.IsPreferido).Include(c => c.Categoria).Include(c => c.Ingrediente).ToList()
            };
            return View(homeViewModel);
        }
        public IActionResult List(string categoria)
        {
            IEnumerable<Receita> receitas;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                receitas = _uof.ReceitaRepository.Get().Include(categoria => categoria.Categoria).OrderBy(r => r.ReceitaId);
                categoriaAtual = "Todos as Receitas";
            }
            else
            {
                receitas = _uof.ReceitaRepository.Get().Include(categoria => categoria.Categoria).Where(r => r.Categoria.Nome.Equals(categoria)).OrderBy(c => c.Nome);
                categoriaAtual = categoria;
            }
            var receitaPreferidaViewModel = new ReceitaPreferidaViewModel
            {
                Receitas = receitas,
                CategoriaAtual = categoriaAtual
            };

            return View(receitaPreferidaViewModel);
        }
        public ViewResult Search(String searchString)
        {
            List<Receita> receitas;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(searchString))
            {
                receitas = _uof.ReceitaRepository.Get().Include(c => c.Categoria).OrderBy(r => r.ReceitaId).ToList();
                categoriaAtual = "Todos as Receitas";
            }
            else
            {
                receitas = _uof.ReceitaRepository.Get().Include(i => i.Ingrediente).Include(c => c.Categoria).Where(r => r.Nome.ToLower().Contains(searchString.ToLower())).ToList();
                var receitaIngrediente = _uof.ReceitaIngredienteRepository.Get().Include(c => c.Ingrediente).Where(c => c.Ingrediente.Nome.ToLower().Contains(searchString.ToLower())).ToList();
                var receitasTotal = _uof.ReceitaRepository.Get().Include(c => c.Categoria).ToList();
                foreach (var receita in receitaIngrediente)
                {
                    foreach (var item in receitasTotal)
                    {
                        if (item.ReceitaId == receita.ReceitaId)
                        {
                            receitas.Add(item);
                        }

                    }
                }
                if (receitas.Any())
                {
                    categoriaAtual = "Receitas";
                }
                else
                {
                    categoriaAtual = "Nenhum receita foi encontrado";
                }
            }

            return View("~/Views/Home/List.cshtml", new ReceitaPreferidaViewModel
            {
                Receitas = receitas,
                CategoriaAtual = categoriaAtual
            });
        }
        public IActionResult Detalhes(int? ReceitaId)
        {
            if (ReceitaId == null)
            {
                return NotFound();
            }

            var receita = _uof.ReceitaRepository.GetByIdComCategorias(i => i.ReceitaId == ReceitaId);
            if (receita == null)
            {
                return NotFound();
            }
            LogginModels usuario = new LogginModels();
            usuario.QuantidadeDeAcesso = 1;
            usuario.ReceitaId = ReceitaId;
            _uof.LogginRepository.Add(usuario);
            _uof.Commit();
            ViewBag.ReceitaIngrediente = _uof.ReceitaIngredienteRepository.Get().Include(c => c.Ingrediente).Include(c => c.Ingrediente.UnidadeDeMedida).ToList();
            return View(receita);
        }
    }
}
