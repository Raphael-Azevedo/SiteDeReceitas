using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using desafio_mvc.Models;

namespace desafio_mvc.Repository.Interfaces
{
    public interface IReceitaRepository : IRepository<Receita>
    {
       Receita DeletarBoleano(int id);
       Receita GetByIdComCategorias(Expression<Func<Receita,bool>> predicate);
    }
}