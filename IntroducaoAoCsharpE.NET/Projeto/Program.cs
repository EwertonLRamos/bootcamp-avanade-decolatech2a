using System;
using Namespace1;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testando Namespaces
            var classe1 = new Classe1();
            var classe2 = new Classe2();
            var classe3 = new Namespace2.Classe3();
            var classe4 = new Namespace2.Classe4();

            //Testando Classe
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Ewerton";
            pessoa1.CPF = "123.456.789-10";
            pessoa1.Idade = 21;

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Irineu";
            pessoa2.CPF = "987.654.321-00";
            pessoa2.Idade = 18;

            //Testando Interface
            Animal animal = new Animal();

            animal.Nome = "Macaco";
            animal.Idade = 15;
            animal.Dono = "João;";
            
            animal.CorrigeNome("Chimpanzé");
            animal.CorrigeIdade(20);
            animal.CorrigeDono("Jorge");

            //Testando Enum
            var pessoa = (Pessoas)0;
            Pessoas person = Pessoas.Ewerton;
            Pessoas pessoas = (Pessoas)1;

            Console.WriteLine("Olá mundo!");
        }
    }
}
