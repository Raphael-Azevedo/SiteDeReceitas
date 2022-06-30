using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_mvc.Models
{
    public class ReceitaPreferidaViewModel
    {
        public IEnumerable<Receita> Receitas { get; set; }
        public string CategoriaAtual { get; set; }
    }
}