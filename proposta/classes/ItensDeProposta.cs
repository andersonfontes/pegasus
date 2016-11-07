using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProposta
{
    class ItensDeProposta
    {
        public List<ItemDeProposta> lista = new List<ItemDeProposta>();

        public List<ItemDeProposta> ListaItem(int PropostaID)
        {
            return this.lista;
        }

        public void Insere(ItemDeProposta item)
        {
            this.lista.Add(item);
        }

        public void Deleta(ItemDeProposta item)
        {
            this.lista.Remove(item);
        }
    }
}
