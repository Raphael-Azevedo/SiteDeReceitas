using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Context;
using desafio_mvc.Models;
using desafio_mvc.Repository.Interfaces;

namespace desafio_mvc.Repository
{
    public class MedidaRepository : Repository<Medida>, IMedidaRepository
    {
        public MedidaRepository(ApplicationDbContext context) : base(context)
        {
        }
        public Medida DeletarBoleano(int id)
        {
            var medida = GetById(c => c.MedidaId == id);
            medida.Status = false;
            return medida;
        }
    }
}