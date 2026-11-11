using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaEx
{
    public abstract class ProdutoDigital
    {
        public string Nome { get; set; }

        public int Preco { get; set; }

        public ProdutoDigital(string nome, int preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
        }
    }
}