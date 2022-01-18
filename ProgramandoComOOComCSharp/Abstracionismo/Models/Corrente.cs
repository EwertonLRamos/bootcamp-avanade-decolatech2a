namespace Abstracionismo.Models
{
    public sealed class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.Saldo = valor;
        }
    }
}