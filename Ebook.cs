namespace HerancaEx
{
    public class Ebook : ProdutoDigital
    {
       public int QuantidadePaginas { get; set; }

        public Ebook (string nome, int preco, int quantidadePaginas) : base(nome, preco)
        {
            QuantidadePaginas = quantidadePaginas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade de páginas: {QuantidadePaginas}");
        }
        
    }
}