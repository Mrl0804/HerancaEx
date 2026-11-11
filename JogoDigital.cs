namespace HerancaEx
{
    public class JogoDigital : Jogo
    {
        public int TamanhoArquivo { get; set; }

        public JogoDigital(string nome, string plataforma, int tamanhoArquivo) : base(nome, plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
            TamanhoArquivo = tamanhoArquivo;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Jogo Digital: {Nome} | Plataforma: {Plataforma} | Tamanho do Arquivo: {TamanhoArquivo}gb");
        }
    }
}