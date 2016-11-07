using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProposta
{
    class Proposta:ItensDeProposta
    {
        public string Cliente { get; set; }
        public string CodCliente { get; set; }
        public string Contato { get; set; }
        public string Representante { get; set; }
        public DateTime Data { get; set; }

    }
}
