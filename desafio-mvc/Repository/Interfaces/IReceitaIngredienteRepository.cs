using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Models;

namespace desafio_mvc.Repository.Interfaces
{
    public interface IReceitaIngredienteRepository : IRepository<ReceitaIngrediente>
    {
        void DeletarReceitas(List<ReceitaIngrediente> entity);
        void AddReceitas(List<ReceitaIngrediente> entity);
    }
}