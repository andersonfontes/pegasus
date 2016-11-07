using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProposta
{
    class ItemDeProposta:IDisposable
    {
        public int ItemPropostaID { get; set; }
        public string ProdutoNome { get; set; }

        public string Moeda { get; set; }
        public string Preco { get; set; }
        public string Condicao { get; set; }
        public string Imagem { get; set; }
        public string Volume { get; set; }
        public string Periodo { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
