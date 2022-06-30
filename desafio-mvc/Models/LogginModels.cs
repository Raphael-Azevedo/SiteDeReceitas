using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_mvc.Models
{
    public class LogginModels
    {
        public int Id { get; set; }
        public int QuantidadeDeAcesso { get; set; }    
        public int? ReceitaId { get; set; }
    }
}