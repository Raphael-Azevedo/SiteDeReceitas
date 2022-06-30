using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_mvc.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Receita> ReceitaPreferidos { get; set; }
    }
}