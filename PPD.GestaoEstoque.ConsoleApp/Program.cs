using PPD.GestaoEstoque.ConsoleApp.Database;
using PPD.GestaoEstoque.ConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PPD.GestaoEstoque.ConsoleApp
{
    public class Program
    {
        public static InMemoryDbContext inMemoryDatabase = new InMemoryDbContext();

        public static void RegistrarVenda(object obj)
        {
            var venda = (Venda)obj;
            Console.WriteLine($"Registrando venda Número: {venda.Numero}");

            foreach (var item in venda.Itens)
            {
                Console.WriteLine($"Validando estoque para o item {item.Codigo} | Venda {venda.Numero}");
            }

            Console.WriteLine($"Venda {venda.Numero} registrada com sucesso! Valor total: {venda.GetValorTotal()}");
        }

        static void Main(string[] args)
        {
            //incluir semaforo
            foreach (var venda in inMemoryDatabase.Vendas)
            {
                var thread = new Thread(new ParameterizedThreadStart(RegistrarVenda));
                thread.Start(venda);
            }

            Console.ReadKey();
        }
    }
}
