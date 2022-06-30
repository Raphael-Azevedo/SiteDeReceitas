using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Models;

namespace desafio_mvc.DTO
{
    public class CategoriaDTO
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        public string Nome { get; set; }
        [StringLength(450, ErrorMessage = "O tamanho máximo é 450 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<Receita> Receitas { get; set; }
    }
}