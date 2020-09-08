namespace PPD.GestaoEstoque.ConsoleApp.Entities
{
    public sealed class Produto
    {
        public long Codigo { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }

        public Produto(long codigo, int quantidade, decimal valor)
        {
            this.Codigo = codigo;
            this.Quantidade = quantidade;
            this.Valor = valor;
        }
    }
}
