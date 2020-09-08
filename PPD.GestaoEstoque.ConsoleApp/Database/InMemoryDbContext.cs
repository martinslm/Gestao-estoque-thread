using PPD.GestaoEstoque.ConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PPD.GestaoEstoque.ConsoleApp.Database
{
    public sealed class InMemoryDbContext
    {
        public List<Filial> Filiais { get; set; }
        public List<Venda> Vendas { get; set; }

        public InMemoryDbContext()
        {
            Filiais = ObterListagemFiliais();
            Vendas = ObterListagemVendas();
        }

        private List<Venda> ObterListagemVendas()
        {
            return new List<Venda>
            {
                new Venda(1, ObterProdutosVenda1(), 1),
                new Venda(2, ObterProdutosVenda2(), 1),
                new Venda(3, ObterProdutosVenda3(), 1)
            };
        }
        private List<Filial> ObterListagemFiliais()
        {
            return new List<Filial>()
            {
                new Filial(1, "Filial da Larissa", ObterEstoqueFilial1())
            };
        }
        private List<Produto> ObterEstoqueFilial1()
        {
            return new List<Produto>()
            {
                new Produto(1, 3, 10),
                new Produto(2, 10, 15),
                new Produto(3, 200, 5),
                new Produto(4, 3, 2),
                new Produto(5, 0, 1.5m)
            };
        }
        private List<Produto> ObterProdutosVenda1()
        {
            return new List<Produto>()
            {
                new Produto(1, 1, 10),
                new Produto(3, 1, 5),
                new Produto(4, 3, 2)
            };
        }
        private List<Produto> ObterProdutosVenda2()
        {
            return new List<Produto>()
            {
                new Produto(1, 1, 10),
                new Produto(2, 5, 15),
                new Produto(5, 1, 1.5m)
            };
        }
        private List<Produto> ObterProdutosVenda3()
        {
            return new List<Produto>()
            {
                new Produto(1, 1, 10),
                new Produto(2, 3, 15),
                new Produto(4, 1, 1.5m)
            };
        }
    }
}
