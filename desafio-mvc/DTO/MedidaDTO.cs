using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_mvc.DTO
{
    public class MedidaDTO
    {
        [Key]
        public int MedidaId { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da Medida")]
        public string Nome { get; set; }
        [StringLength(50, ErrorMessage = "O tamanho máximo é 50 caracteres")]
        [Required(ErrorMessage = "Informe o simbolo da Medida")]
        public string Simbolo { get; set; }
    }
}