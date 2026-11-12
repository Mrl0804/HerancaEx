using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaEx
{
    public class Relatorio : Iimprimivel, IExportavel
    {
        public void Imprimir()
        {
            Console.WriteLine("A imprimir Relatório Mensal...");
        }

        public void Exportar()
        {
            Console.WriteLine("A exportar Relatório Mensal ...");
        }
    }
}