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
                new Venda(2, ObterProdutosVenda2(), 2),
                new Venda(3, ObterProdutosVenda3(), 3),
                new Venda(4, ObterProdutosVenda4(), 4),
                new Venda(5, ObterProdutosVenda5(), 5),

                new Venda(6, ObterProdutosVenda1(), 6),
                new Venda(7, ObterProdutosVenda2(), 7),
                new Venda(8, ObterProdutosVenda3(), 8),
                new Venda(9, ObterProdutosVenda4(), 9),
                new Venda(10, ObterProdutosVenda5(), 10),

                new Venda(11, ObterProdutosVenda1(), 10),
                new Venda(12, ObterProdutosVenda2(), 9),
                new Venda(13, ObterProdutosVenda3(),8),
                new Venda(14, ObterProdutosVenda4(), 7),
                new Venda(15, ObterProdutosVenda5(), 6),

                 new Venda(16, ObterProdutosVenda1(), 5),
                new Venda(17, ObterProdutosVenda2(), 4),
                new Venda(18, ObterProdutosVenda3(), 3),
                new Venda(19, ObterProdutosVenda4(), 2),
                new Venda(20, ObterProdutosVenda5(), 1),

                new Venda(21, ObterProdutosVenda1(), 2),
                new Venda(22, ObterProdutosVenda2(), 1),
                new Venda(23, ObterProdutosVenda3(), 4),
                new Venda(24, ObterProdutosVenda4(), 3),
                new Venda(25, ObterProdutosVenda5(), 6),

                 new Venda(26, ObterProdutosVenda1(), 5),
                new Venda(27, ObterProdutosVenda2(), 7),
                new Venda(28, ObterProdutosVenda3(), 8),
                new Venda(29, ObterProdutosVenda4(), 10),
                new Venda(30, ObterProdutosVenda5(), 9),

                new Venda(31, ObterProdutosVenda1(), 1),
                new Venda(32, ObterProdutosVenda2(), 2),
                new Venda(33, ObterProdutosVenda3(), 3),
                new Venda(34, ObterProdutosVenda4(), 4),
                new Venda(35, ObterProdutosVenda5(), 5),

                 new Venda(36, ObterProdutosVenda1(), 6),
                new Venda(37, ObterProdutosVenda2(), 7),
                new Venda(38, ObterProdutosVenda3(), 8),
                new Venda(39, ObterProdutosVenda4(), 9),
                new Venda(40, ObterProdutosVenda5(), 10),

                new Venda(41, ObterProdutosVenda1(), 10),
                new Venda(42, ObterProdutosVenda2(), 9),
                new Venda(43, ObterProdutosVenda3(), 8),
                new Venda(44, ObterProdutosVenda4(), 7),
                new Venda(45, ObterProdutosVenda5(), 6),

                new Venda(46, ObterProdutosVenda1(), 5),
                new Venda(47, ObterProdutosVenda2(), 4),
                new Venda(48, ObterProdutosVenda3(), 3),
                new Venda(49, ObterProdutosVenda4(), 2),
                new Venda(50, ObterProdutosVenda5(), 1)
            };
        }
        private List<Filial> ObterListagemFiliais()
        {
            return new List<Filial>()
            {
                new Filial(1, "Filial 1", ObterEstoqueFilial1()),
                new Filial(2, "Filial 2", ObterEstoqueFilial2()),
                new Filial(3, "Filial 3", ObterEstoqueFilial3()),
                new Filial(4, "Filial 4", ObterEstoqueFilial4()),
                new Filial(5, "Filial 5", ObterEstoqueFilial5()),
                new Filial(6, "Filial 6", ObterEstoqueFilial6()),
                new Filial(7, "Filial 7", ObterEstoqueFilial7()),
                new Filial(8, "Filial 8", ObterEstoqueFilial8()),
                new Filial(9, "Filial 9", ObterEstoqueFilial9()),
                new Filial(10, "Filial 10", ObterEstoqueFilial10())
            };
        }
        private List<Produto> ObterEstoqueFilial1()
        {
            return new List<Produto>()
            {
                new Produto(1, 30, 10),
                new Produto(2, 100, 15),
                new Produto(3, 2000, 5),
                new Produto(4, 30, 2),
                new Produto(5, 80, 1.5m),
                new Produto(6, 500, 2),
                new Produto(7, 700, 5),
                new Produto(8, 900, 8),
                new Produto(9, 1500, 11),
                new Produto(10, 500, 15)
            };
        }

        private List<Produto> ObterEstoqueFilial2()
        {
            return new List<Produto>()
            {
                new Produto(1, 30, 10),
                new Produto(2, 100, 15),
                new Produto(3, 200, 5),
                new Produto(4, 30, 2),
                new Produto(5, 80, 1.5m),
                new Produto(6, 500, 2),
                new Produto(7, 700, 5),
                new Produto(8, 900, 8),
                new Produto(9, 150, 11),
                new Produto(10, 500, 15)
            };
        }

        private List<Produto> ObterEstoqueFilial3()
        {
            return new List<Produto>()
            {
                new Produto(1, 30, 10),
                new Produto(2, 100, 15),
                new Produto(3, 200, 5),
                new Produto(4, 30, 2),
                new Produto(5, 80, 1.5m),
                new Produto(6, 500, 2),
                new Produto(7, 700, 5),
                new Produto(8, 900, 8),
                new Produto(9, 150, 11),
                new Produto(10, 500, 15)
            };
        }

        private List<Produto> ObterEstoqueFilial4()
        {
            return new List<Produto>()
            {
                new Produto(1, 3, 10),
                new Produto(2, 10, 15),
                new Produto(3, 200, 5),
                new Produto(4, 3, 2),
                new Produto(5, 8, 1.5m),
                new Produto(6, 50, 2),
                new Produto(7, 70, 5),
                new Produto(8, 90, 8),
                new Produto(9, 150, 11),
                new Produto(10, 50, 15)
            };
        }

        private List<Produto> ObterEstoqueFilial5()
        {
            return new List<Produto>()
            {
                new Produto(1, 3, 10),
                new Produto(2, 10, 15),
                new Produto(3, 200, 5),
                new Produto(4, 3, 2),
                new Produto(5, 8, 1.5m),
                new Produto(6, 50, 2),
                new Produto(7, 70, 5),
                new Produto(8, 90, 8),
                new Produto(9, 150, 11),
                new Produto(10, 50, 15)
            };
        }

        private List<Produto> ObterEstoqueFilial6()
        {
            return new List<Produto>()
            {
                new Produto(1, 3, 10),
                new Produto(2, 10, 15),
                new Produto(3, 200, 5),
                new Produto(4, 3, 2),
                new Produto(5, 8, 1.5m),
                new Produto(6, 50, 2),
                new Produto(7, 70, 5),
                new Produto(8, 90, 8),
                new Produto(9, 150, 11),
                new Produto(10, 50, 15)
            };
        }

        private List<Produto> ObterEstoqueFilial7()
        {
            return new List<Produto>()
            {
                new Produto(1, 3, 10),
                new Produto(2, 10, 15),
                new Produto(3, 200, 5),
                new Produto(4, 3, 2),
                new Produto(5, 8, 1.5m),
                new Produto(6, 50, 2),
                new Produto(7, 70, 5),
                new Produto(8, 90, 8),
                new Produto(9, 150, 11),
                new Produto(10, 50, 15)
            };
        }

        private List<Produto> ObterEstoqueFilial8()
        {
            return new List<Produto>()
            {
                new Produto(1, 3, 10),
                new Produto(2, 10, 15),
                new Produto(3, 200, 5),
                new Produto(4, 3, 2),
                new Produto(5, 8, 1.5m),
                new Produto(6, 50, 2),
                new Produto(7, 70, 5),
                new Produto(8, 90, 8),
                new Produto(9, 150, 11),
                new Produto(10, 50, 15)
            };
        }

        private List<Produto> ObterEstoqueFilial9()
        {
            return new List<Produto>()
            {
                new Produto(1, 3, 10),
                new Produto(2, 10, 15),
                new Produto(3, 200, 5),
                new Produto(4, 3, 2),
                new Produto(5, 8, 1.5m),
                new Produto(6, 50, 2),
                new Produto(7, 70, 5),
                new Produto(8, 90, 8),
                new Produto(9, 150, 11),
                new Produto(10, 50, 15)
            };
        }

        private List<Produto> ObterEstoqueFilial10()
        {
            return new List<Produto>()
            {
                new Produto(1, 3, 10),
                new Produto(2, 10, 15),
                new Produto(3, 200, 5),
                new Produto(4, 3, 2),
                new Produto(5, 8, 1.5m),
                new Produto(6, 50, 2),
                new Produto(7, 70, 5),
                new Produto(8, 90, 8),
                new Produto(9, 150, 11),
                new Produto(10, 50, 15)
            };
        }
        private List<Produto> ObterProdutosVenda1()
        {
            return new List<Produto>()
            {
               new Produto(1, 3, 10),
               new Produto(2, 10, 15),
               new Produto(3, 200, 5),
               new Produto(4, 3, 2),
               new Produto(5, 8, 1.5m)
            };
        }
        private List<Produto> ObterProdutosVenda2()
        {
            return new List<Produto>()
            {
                new Produto(6, 50, 2),
                new Produto(7, 70, 5),
                new Produto(8, 90, 8),
                new Produto(9, 150, 11),
                new Produto(10, 50, 15)
            };
        }
        private List<Produto> ObterProdutosVenda3()
        {
            return new List<Produto>()
            {
               new Produto(1, 3, 10),
               new Produto(2, 10, 15),
               new Produto(3, 200, 5),
               new Produto(4, 3, 2),
               new Produto(5, 8, 1.5m)
            };
        }
        private List<Produto> ObterProdutosVenda4()
        {
            return new List<Produto>()
            {
                new Produto(6, 50, 2),
                new Produto(7, 70, 5),
                new Produto(8, 90, 8),
                new Produto(9, 150, 11),
                new Produto(10, 50, 15)
            };
        }
        private List<Produto> ObterProdutosVenda5()
        {
            return new List<Produto>()
            {
                new Produto(6, 50, 2),
                new Produto(7, 70, 5),
                new Produto(8, 90, 8),
                new Produto(9, 150, 11),
                new Produto(10, 50, 15)
            };
        }
    }
}
