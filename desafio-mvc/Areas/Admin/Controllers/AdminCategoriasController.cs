using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using desafio_mvc.Context;
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
    [Authorize(Policy = "AcessoAdmin")]
    public class AdminCategoriasController : Controller
    {
        private readonly IUnitOfWork _uof;
        private readonly IMapper _mapper;

        public AdminCategoriasController(IUnitOfWork context, IMapper mapper)
        {
            _uof = context;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View(_uof.CategoriaRepository.Get().Where(s => s.Status == true).ToList());
        }
        public IActionResult GetById(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = _uof.CategoriaRepository.GetById(c => c.CategoriaId == id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CategoriaId,Nome,Descricao")] CategoriaDTO categoriaDTO)
        {
            var categoria = _mapper.Map<Categoria>(categoriaDTO);
            if (ModelState.IsValid)
            {
                categoria.Status = true;
                _uof.CategoriaRepository.Add(categoria);
                _uof.Commit();
                return RedirectToAction(nameof(Index));
            }
            var categoriaDto = _mapper.Map<CategoriaDTO>(categoria);
            return View(categoriaDto);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = _uof.CategoriaRepository.GetById(c => c.CategoriaId == id);
            var categoriaDTO = _mapper.Map<CategoriaDTO>(categoria);
            if (categoriaDTO == null)
            {
                return NotFound();
            }
            return View(categoriaDTO);
        }
        [HttpPost("{id:int}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("CategoriaId,Nome,Descricao")] CategoriaDTO categoriaDTO, int id)
        {
            if (id != categoriaDTO.CategoriaId)
            {
                return NotFound();
            }

            var categoria = _mapper.Map<Categoria>(categoriaDTO);
            categoria.Status = true;
            if (ModelState.IsValid)
            {
                try
                {
                    _uof.CategoriaRepository.Update(categoria);
                    _uof.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction("Index", "AdminCategorias");
            }
            var categoriaDto = _mapper.Map<CategoriaDTO>(categoria);
            return View(categoriaDto);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = _uof.CategoriaRepository.GetById(c => c.CategoriaId == id);
            var categoriaDTO = _mapper.Map<CategoriaDTO>(categoria);
            if (categoriaDTO == null)
            {
                return NotFound();
            }

            return View(categoriaDTO);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var categoria = _uof.CategoriaRepository.DeletarBoleano(id);
            categoria.Status = false;
            _uof.Commit();
            return RedirectToAction(nameof(Index));
        }
    }
}