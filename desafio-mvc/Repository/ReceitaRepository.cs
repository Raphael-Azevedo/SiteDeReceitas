using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using desafio_mvc.Context;
using desafio_mvc.Models;
using desafio_mvc.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace desafio_mvc.Repository
{
    public class ReceitaRepository : Repository<Receita>, IReceitaRepository
    {
        public ReceitaRepository(ApplicationDbContext context) : base(context)
        {
        }
        public Receita DeletarBoleano(int id)
        {
            var receita = GetById(c => c.ReceitaId == id);
            receita.Status = false;
            return receita;
        }
        public Receita GetByIdComCategorias(Expression<Func<Receita,bool>> predicate)
        {
            return _context.Set<Receita>().Include(c => c.Categoria).Include(i => i.Ingrediente).SingleOrDefault(predicate);
        }
    }
}