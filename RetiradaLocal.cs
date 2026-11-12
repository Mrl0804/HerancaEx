using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaEx
{
    public class RetiradaLocal : Entrega
    {
        public RetiradaLocal(double distancia = 0) : base(distancia) { }

        public override decimal CalcularFrete()
        {
            return 0.00m;
        }
    }
}