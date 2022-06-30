using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Context;
using desafio_mvc.Models;
using desafio_mvc.Repository.Interfaces;

namespace desafio_mvc.Repository
{
    public class LogginRepository : Repository<LogginModels>, ILogginRepository
    {
        public LogginRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}