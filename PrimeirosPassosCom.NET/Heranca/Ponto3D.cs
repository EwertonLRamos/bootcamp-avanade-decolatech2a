namespace PrimeirosPassosCom.NET.Herança
{
    public class Ponto3D : Ponto
    {
        public int z;

        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia1();
        }
        
        public static void Calcular()
        {
            //Faz algo...
        }
        public override void CalcularDistancia3()
        {
            //Faz algo...
        }
    }
}