using PPD.GestaoEstoque.ConsoleApp.Database;
using PPD.GestaoEstoque.ConsoleApp.Entities;
using System;
using System.Linq;
using System.Threading;

namespace PPD.GestaoEstoque.ConsoleApp
{
    public class Program
    {
        public static InMemoryDbContext inMemoryDatabase = new InMemoryDbContext();
        public static Semaphore pool = new Semaphore(1, 1);

        public static void RegistrarVenda(object obj)
        {
            var venda = (Venda)obj;
            var filialVenda = inMemoryDatabase.Filiais.Where(f => f.Codigo == venda.Filial).FirstOrDefault();
            var todosProdutosTemEstoque = true;
            Console.WriteLine($"\nRegistrando venda Número: {venda.Numero}");

            pool.WaitOne();
            foreach (var item in venda.Itens)
            {
                var produtoFilial = filialVenda.Estoque.Where(e => e.Codigo == item.Codigo).FirstOrDefault();
                todosProdutosTemEstoque &= produtoFilial.Quantidade >= item.Quantidade;
                Console.WriteLine($"\nValidando estoque para o item {item.Codigo} | Venda {venda.Numero}");
            }

            if (!todosProdutosTemEstoque)
                Console.WriteLine($"\nNão será possível efetuar a venda {venda.Numero} pois não há estoque suficiente para um dos itens.");
            else
            {
                foreach (var item in venda.Itens)
                {
                    var produtoFilial = filialVenda.Estoque.Where(e => e.Codigo == item.Codigo).FirstOrDefault();
                    produtoFilial.Quantidade -= item.Quantidade;
                    Console.WriteLine($"\nAtualizando estoque da filial para o item {item.Codigo} | Venda {venda.Numero}");
                }

                Console.WriteLine($"\nVenda {venda.Numero} registrada com sucesso! Valor total: {venda.GetValorTotal()}");
            }

            pool.Release();
        }

        static void Main(string[] args)
        {
            foreach (var venda in inMemoryDatabase.Vendas)
            {
                var thread = new Thread(new ParameterizedThreadStart(RegistrarVenda));
                thread.Start(venda);
            }

            Console.ReadKey();
        }
    }
}
