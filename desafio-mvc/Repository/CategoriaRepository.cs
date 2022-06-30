using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Context;
using desafio_mvc.Models;
using desafio_mvc.Repository.Interfaces;

namespace desafio_mvc.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Categoria DeletarBoleano(int id)
        {
            var categoria = GetById( c => c.CategoriaId == id);
            categoria.Status = false;
            return categoria;
        }
    }
}