using System.Collections.Generic;
using System.Linq;

namespace PPD.GestaoEstoque.ConsoleApp.Entities
{
    public sealed class Venda
    {
        public long Numero { get; set; }
        public List<Produto> Itens { get; set; }
        public long Filial { get; set; }
        public decimal GetValorTotal()
        {
            return Itens.Select(item => item.Valor).Sum();
        }

        public Venda(long numero, List<Produto> itens, long filial)
        {
            this.Numero = numero;
            this.Filial = filial;
            this.Itens = itens;
        }

    }
}
