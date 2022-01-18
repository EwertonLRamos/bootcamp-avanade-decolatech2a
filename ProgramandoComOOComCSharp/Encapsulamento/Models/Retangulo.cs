namespace Encapsulamento.Models
{
    public class Retangulo
    {
        private bool _valido; 

        private double Comprimento { get; set; }
        private double Largura { get; set; }

        public void DefinirMedidas(double comprimento, double largura)
        {   
            if(comprimento >= 0 && largura >= 0)
            {
                Comprimento = comprimento;
                Largura = largura;
                _valido = true;
            }
            else
            {
                Console.WriteLine("Os valores devem ser positivos!");
            }
            
        }

        public double ObterArea()
        {
            if(_valido)
                return Comprimento * Largura;
            else
            {
                System.Console.WriteLine("Preencha valroes válidos");
                return 0;
            }
        }
    }
}