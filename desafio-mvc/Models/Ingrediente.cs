using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_mvc.Models
{
    public class Ingrediente
    {
        public int IngredienteId { get; set; }
        public string Nome { get; set; }
        public Medida UnidadeDeMedida { get; set; }
        public bool Status { get; set; }
        public ICollection<ReceitaIngrediente> Receitas { get; set;}

    }
}