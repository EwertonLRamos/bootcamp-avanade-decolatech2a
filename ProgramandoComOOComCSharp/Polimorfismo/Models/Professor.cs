namespace Polimorfismo.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}. Sou um professor e ganho {Salario}");
        }
    }
}
