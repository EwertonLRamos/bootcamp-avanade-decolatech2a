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

            Console.WriteLine("Hello World!");
        }
    }
}
