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
    public class AdminMedidasController : Controller
    {
        private readonly IUnitOfWork _uof;
        private readonly IMapper _mapper;

        public AdminMedidasController(IUnitOfWork context, IMapper mapper)
        {
            _uof = context;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View(_uof.MedidaRepository.Get().Where(s => s.Status == true).ToList());
        }
        public IActionResult GetById(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medida = _uof.MedidaRepository.GetById(c => c.MedidaId == id);
            if (medida == null)
            {
                return NotFound();
            }

            return View(medida);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("MedidaId,Nome,Simbolo")] MedidaDTO medidaDTO)
        {
            var medida = _mapper.Map<Medida>(medidaDTO);
            if (ModelState.IsValid)
            {
                medida.Status = true;
                _uof.MedidaRepository.Add(medida);
                _uof.Commit();
                return RedirectToAction(nameof(Index));
            }
            var medidaDto = _mapper.Map<MedidaDTO>(medida);
            return View(medidaDto);
        }
        public IActionResult EditMedida(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medida = _uof.MedidaRepository.GetById(c => c.MedidaId == id);
            var medidaDTO = _mapper.Map<MedidaDTO>(medida);
            if (medidaDTO == null)
            {
                return NotFound();
            }
            return View(medidaDTO);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditMedida([Bind("MedidaId,Nome,Simbolo")] MedidaDTO medidaDTO, int id)
        {
            if (id != medidaDTO.MedidaId)
            {
                return NotFound();
            }

            var medida = _mapper.Map<Medida>(medidaDTO);
            medida.Status = true;
            if (ModelState.IsValid)
            {
                try
                {
                    _uof.MedidaRepository.Update(medida);
                    _uof.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            var medidaDto = _mapper.Map<MedidaDTO>(medida);
            return View(medidaDto);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medida = _uof.MedidaRepository.GetById(c => c.MedidaId == id);
            var medidaDTO = _mapper.Map<MedidaDTO>(medida);
            if (medidaDTO == null)
            {
                return NotFound();
            }

            return View(medidaDTO);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var medida = _uof.MedidaRepository.DeletarBoleano(id);
            medida.Status = false;
            _uof.Commit();
            return RedirectToAction(nameof(Index));
        }
    }
}