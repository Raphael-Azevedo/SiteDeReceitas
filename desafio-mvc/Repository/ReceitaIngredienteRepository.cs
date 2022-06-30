using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Context;
using desafio_mvc.Models;
using desafio_mvc.Repository.Interfaces;

namespace desafio_mvc.Repository
{
    public class ReceitaIngredienteRepository : Repository<ReceitaIngrediente>, IReceitaIngredienteRepository
    {
        public ReceitaIngredienteRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void DeletarReceitas(List<ReceitaIngrediente> entity)
        {
            _context.Set<ReceitaIngrediente>().RemoveRange(entity);
        }
        public void AddReceitas(List<ReceitaIngrediente> entity)
        {
            _context.Set<ReceitaIngrediente>().AddRange(entity);
        }
    }
}