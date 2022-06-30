using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using desafio_mvc.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace desafio_mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[Controller]/[Action]/{id?}")]
    [Authorize(Policy = "AcessoAdmin")]
    public class AdminReceitasController : Controller
    {

        private readonly IUnitOfWork _uof;
        private readonly IMapper _mapper;

        public AdminReceitasController(IUnitOfWork context, IMapper mapper)
        {
            _uof = context;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            ViewBag.Ingredientes = _uof.IngredienteRepository.Get().Include(c => c.UnidadeDeMedida).Where(s => s.Status == true).ToList();
            ViewBag.ReceitaIngrediente = _uof.ReceitaIngredienteRepository.Get().Include(c => c.Ingrediente).Include(c => c.Ingrediente.UnidadeDeMedida).ToList();
            return View(_uof.ReceitaRepository.Get().Include(i => i.Categoria).Include(c => c.Ingrediente).Where(s => s.Status == true).ToList());
        }
        public IActionResult GetById(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receita = _uof.ReceitaRepository.GetById(c => c.ReceitaId == id);
            if (receita == null)
            {
                return NotFound();
            }

            return View(receita);
        }
        public IActionResult Create()
        {
            ViewBag.Categorias = _uof.CategoriaRepository.Get().Where(s => s.Status == true).ToList();
            ViewBag.Ingredientes = _uof.IngredienteRepository.Get().Include(c => c.UnidadeDeMedida).Where(s => s.Status == true).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ReceitaDTO receitaDTO, ReceitaIngrediente receitaIngredienteDTO)
        {
            var receita = _mapper.Map<Receita>(receitaDTO);
            if (ModelState.IsValid)
            {
                receita.Ingrediente = receitaIngredienteDTO.ReceitaIngredientes;
                receita.Categoria = _uof.CategoriaRepository.GetById(m => m.CategoriaId == receitaDTO.CategoriaId);
                receita.Status = true;
                _uof.ReceitaRepository.Add(receita);
                _uof.Commit();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categorias = _uof.CategoriaRepository.Get().Where(s => s.Status == true).ToList();
            ViewBag.Ingredientes = _uof.IngredienteRepository.Get().Include(c => c.UnidadeDeMedida).Where(s => s.Status == true).ToList();
            var receitaDto = _mapper.Map<ReceitaDTO>(receita);
            return View(receitaDto);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var receita = _uof.ReceitaRepository.GetById(c => c.ReceitaId == id);
            var receitaDTO = _mapper.Map<ReceitaDTO>(receita);
            if (receitaDTO == null)
            {
                return NotFound();
            }
            ViewBag.Categorias = _uof.CategoriaRepository.Get().Where(s => s.Status == true).ToList();
            ViewBag.Ingredientes = _uof.IngredienteRepository.Get().Include(c => c.UnidadeDeMedida).Where(s => s.Status == true).ToList();
            return View(receitaDTO);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ReceitaDTO receitaDTO, ReceitaIngrediente receitaIngredienteDTO, int id)
        {
            if (id != receitaDTO.ReceitaId)
            {
                return NotFound();
            }

            var receita = _mapper.Map<Receita>(receitaDTO);
            receita.Status = true;
            if (ModelState.IsValid)
            {
                try
                {
                    receita.Categoria = _uof.CategoriaRepository.GetById(m => m.CategoriaId == receitaDTO.CategoriaId);
                    receita.Ingrediente = receitaIngredienteDTO.ReceitaIngredientes;
                    _uof.ReceitaRepository.Update(receita);
                    _uof.Commit();
                    if(receitaIngredienteDTO.ReceitaIngredientes != null)
                    {
                    var receitasCadastrasdas = _uof.ReceitaIngredienteRepository.Get().Where(r => r.ReceitaId == receitaDTO.ReceitaId).ToList();
                    _uof.ReceitaIngredienteRepository.DeletarReceitas(receitasCadastrasdas);
                    _uof.Commit();

                    foreach (var ingrediente in receitaIngredienteDTO.ReceitaIngredientes)
                    {
                        ingrediente.ReceitaId = receitaDTO.ReceitaId;
                    }
                    _uof.ReceitaIngredienteRepository.AddReceitas(receitaIngredienteDTO.ReceitaIngredientes);
                    _uof.Commit();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categorias = _uof.CategoriaRepository.Get().Where(s => s.Status == true).ToList();
            ViewBag.Ingredientes = _uof.IngredienteRepository.Get().Include(c => c.UnidadeDeMedida).Where(s => s.Status == true).ToList();
            var receitaDto = _mapper.Map<ReceitaDTO>(receita);
            return View(receitaDto);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receita = _uof.ReceitaRepository.GetById(c => c.ReceitaId == id);
            var receitaDTO = _mapper.Map<ReceitaDTO>(receita);
            if (receitaDTO == null)
            {
                return NotFound();
            }

            return View(receitaDTO);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var receita = _uof.ReceitaRepository.DeletarBoleano(id);
            receita.Status = false;
            _uof.Commit();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult AddMorePartialView()
        {
            ViewBag.Categorias = _uof.CategoriaRepository.Get().Where(s => s.Status == true).ToList();
            ViewBag.Ingredientes = _uof.IngredienteRepository.Get().Include(c => c.UnidadeDeMedida).Where(s => s.Status == true).ToList();

            ReceitaIngrediente model = new ReceitaIngrediente();
            return PartialView("_ReceitaPartial", model);
        }
    }
}