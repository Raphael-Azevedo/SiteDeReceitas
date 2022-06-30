using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Context;
using desafio_mvc.Models;
using desafio_mvc.Repository.Interfaces;

namespace desafio_mvc.Repository
{
    public class IngredienteRepository : Repository<Ingrediente>, IIngredienteRepository
    {
        public IngredienteRepository(ApplicationDbContext context) : base(context)
        {
        }
        public Ingrediente DeletarBoleano(int id)
        {
            var ingrediente = GetById(c => c.IngredienteId == id);
            ingrediente.Status = false;
            return ingrediente;
        }
    }
}