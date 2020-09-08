using System.Collections.Generic;

namespace PPD.GestaoEstoque.ConsoleApp.Entities
{
    public sealed class Filial
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public List<Produto> Estoque { get; set; }

        public Filial(long codigo, string nome, List<Produto> estoque)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Estoque = estoque;
        }
    }
}
