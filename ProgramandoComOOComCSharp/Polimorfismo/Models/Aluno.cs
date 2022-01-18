namespace Polimorfismo.Models
{
    public class Aluno : Pessoa
    {   
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}. Sou um aluno com nota {Nota}");
        }
    }
}