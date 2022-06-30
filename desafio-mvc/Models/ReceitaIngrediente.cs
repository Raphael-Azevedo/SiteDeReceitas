using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_mvc.Models
{
    public class ReceitaIngrediente
    {
        public int IngredienteId { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public double QuantidadeDeIngrediente { get; set; }
        public int ReceitaId { get; set; }
        public Receita Receita { get; set; }
        public List<ReceitaIngrediente> ReceitaIngredientes { get; set; }
    }
}