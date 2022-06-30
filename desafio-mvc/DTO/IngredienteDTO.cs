using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Models;

namespace desafio_mvc.DTO
{
    public class IngredienteDTO
    {
        [Key]
        public int IngredienteId { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome do Ingrediente")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Unida de medida do ingrediente é obrigatório")]
        public int MedidaId { get; set; }
    }
}