namespace HerancaEx
{
    public class JogoFisico : Jogo
    {
        public int Peso { get; set; }

        public JogoFisico(string nome, string plataforma, int peso) : base(nome, plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
            Peso = peso;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Jogo Físico: {Nome} | Plataforma: {Plataforma} | Peso: {Peso}g");
        }
        
    }
}