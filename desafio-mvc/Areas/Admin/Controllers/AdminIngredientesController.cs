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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace desafio_mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[Controller]/[Action]/{id?}")]
    [Authorize(Policy = "AcessoAdmin")]
    public class AdminIngredientesController : Controller
    {
        private readonly IUnitOfWork _uof;
        private readonly IMapper _mapper;

        public AdminIngredientesController(IUnitOfWork context, IMapper mapper)
        {
            _uof = context;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View(_uof.IngredienteRepository.Get().Include(i => i.UnidadeDeMedida).Where(s => s.Status == true).ToList());
        }
        public IActionResult GetById(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingrediente = _uof.IngredienteRepository.GetById(c => c.IngredienteId == id);
            if (ingrediente == null)
            {
                return NotFound();
            }

            return View(ingrediente);
        }
        public IActionResult Create()
        {
            ViewBag.UnidadesDeMedida = _uof.MedidaRepository.Get().Where(s => s.Status == true).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("IngredienteId,Nome,MedidaId")] IngredienteDTO ingredienteDTO)
        {
            var ingrediente = _mapper.Map<Ingrediente>(ingredienteDTO);
            if (ModelState.IsValid)
            {
                ingrediente.UnidadeDeMedida = _uof.MedidaRepository.GetById(m => m.MedidaId == ingredienteDTO.MedidaId);
                ingrediente.Status = true;
                _uof.IngredienteRepository.Add(ingrediente);
                _uof.Commit();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.UnidadesDeMedida = _uof.MedidaRepository.Get().Where(s => s.Status == true).ToList();
            var ingredienteDto = _mapper.Map<IngredienteDTO>(ingrediente);
            return View(ingredienteDto);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ingrediente = _uof.IngredienteRepository.GetById(c => c.IngredienteId == id);
            var ingredienteDTO = _mapper.Map<IngredienteDTO>(ingrediente);
            if (ingredienteDTO == null)
            {
                return NotFound();
            }
            ViewBag.UnidadesDeMedida = _uof.MedidaRepository.Get().Where(s => s.Status == true).ToList();
            return View(ingredienteDTO);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("IngredienteId,Nome,MedidaId")] IngredienteDTO ingredienteDTO, int id)
        {
            if (id != ingredienteDTO.IngredienteId)
            {
                return NotFound();
            }

            var ingrediente = _mapper.Map<Ingrediente>(ingredienteDTO);
            ingrediente.Status = true;
            if (ModelState.IsValid)
            {
                try
                {
                    ingrediente.UnidadeDeMedida = _uof.MedidaRepository.GetById(m => m.MedidaId == ingredienteDTO.MedidaId);
                    _uof.IngredienteRepository.Update(ingrediente);
                    _uof.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.UnidadesDeMedida = _uof.MedidaRepository.Get().Where(s => s.Status == true).ToList();
            var ingredienteDto = _mapper.Map<IngredienteDTO>(ingrediente);
            return View(ingredienteDto);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingrediente = _uof.IngredienteRepository.GetById(c => c.IngredienteId == id);
            var ingredienteDTO = _mapper.Map<IngredienteDTO>(ingrediente);
            if (ingredienteDTO == null)
            {
                return NotFound();
            }

            return View(ingredienteDTO);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var ingrediente = _uof.IngredienteRepository.DeletarBoleano(id);
            ingrediente.Status = false;
            _uof.Commit();
            return RedirectToAction(nameof(Index));
        }
    }
}