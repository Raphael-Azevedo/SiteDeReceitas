using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_mvc.Models
{
    public class Receita
    {
        public int ReceitaId { get; set; }
        public string Nome { get; set; }
        public float TempoDePreparo { get; set; }
        public string ImagemUrl { get; set; }
        public string ModoDePreparo { get; set; }
        public string NomeDoAutor { get; set; }
        public int Rendimento { get; set; }
        public int Dificuldade { get; set; }
        public bool IsPreferido { get; set; }
        public bool Status { get; set; }
        public ICollection<ReceitaIngrediente> Ingrediente { get; set; }
        public Categoria Categoria { get; set; }
        
    }
}