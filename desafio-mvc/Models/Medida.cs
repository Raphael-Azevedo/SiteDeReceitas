using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_mvc.Models
{
    public class Medida
    {
        public int MedidaId { get; set; }
        public string Nome { get; set; }
        public string Simbolo { get; set; }
        public bool Status { get; set; }

    }
}