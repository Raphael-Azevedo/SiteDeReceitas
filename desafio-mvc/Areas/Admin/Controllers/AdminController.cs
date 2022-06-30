using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Models;
using desafio_mvc.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace desafio_mvc.Areas.Admin.Controllers
{

    public class AdminController : Controller
    {
        private readonly IUnitOfWork _uof;

        public AdminController(IUnitOfWork uof)
        {
            _uof = uof;
        }
        [Area("Admin")]
        [Authorize(Policy = "AcessoAdmin")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RelatorioUsuario()
        {
            var logs = _uof.LogginRepository.Get().ToList();

            List<LogginModels> lstAgrupado = logs
                .GroupBy(i => i.ReceitaId)
                .Select(j => new LogginModels()
                {
                    ReceitaId = j.First().ReceitaId,
                    QuantidadeDeAcesso = j.Sum(ij => ij.QuantidadeDeAcesso)
                })
                .ToList();
            return Ok(lstAgrupado);
        }
    }
}