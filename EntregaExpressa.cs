using System.Security.Cryptography.X509Certificates;

namespace HerancaEx
{
    public class EntregaExpressa : Entrega
    {
       
    public EntregaExpressa(double distancia) : base(distancia) { }

    public override decimal CalcularFrete()
    {
        return ((decimal)Distancia * 1.50m) + 15.00m;
    }
}
    }
