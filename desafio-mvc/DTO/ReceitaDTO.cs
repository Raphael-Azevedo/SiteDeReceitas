using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Models;

namespace desafio_mvc.DTO
{
    public class ReceitaDTO
    {
        [Key]
        public int ReceitaId { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da Receita")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o tempo de preparo")]
        public float? TempoDePreparo { get; set; }
        [StringLength(250, ErrorMessage = "O tamanho máximo é 250 caracteres")]
        public string ImagemUrl { get; set; }
        [StringLength(4000, ErrorMessage = "O tamanho máximo é 4000 caracteres")]
        [Required(ErrorMessage = "Informe o mode de preparo")]
        public string ModoDePreparo { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        public string NomeDoAutor { get; set; }
        [Required(ErrorMessage = "Informe o rendimento")]
        public int? Rendimento { get; set; }
        [Required(ErrorMessage = "Informe a dificuldade")]
        [Range(0,2)]
        public int Dificuldade { get; set; }
        public bool IsPreferido { get; set; }
        public int CategoriaId { get; set; }
    }
}