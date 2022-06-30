using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Models;

namespace desafio_mvc.Repository.Interfaces
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        Categoria DeletarBoleano(int id);
    }
}