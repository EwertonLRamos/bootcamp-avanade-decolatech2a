namespace PrimeirosPassosCom.NET.Herança
{
    public class Ponto
    {
        public int x, y;
        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void CalcularDistancia1()
        {
            //Faz algo...
        }

        protected void CalcularDistancia2()
        {
            //Faz algo...
        }

        public virtual void CalcularDistancia3()
        {
            //Faz algo...
        }
    }
}