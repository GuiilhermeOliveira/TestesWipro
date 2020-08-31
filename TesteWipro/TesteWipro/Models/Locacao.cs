using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteWipro.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }

    }
}
