namespace HerancaEx
{
    public class EntregaEconomica : Entrega
    {
        public EntregaEconomica(double distancia) : base(distancia) { }

    public override decimal CalcularFrete()
    {
        return (decimal)Distancia * 0.80m;
    }
    }
}