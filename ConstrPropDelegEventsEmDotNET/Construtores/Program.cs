using System;
using Construtores.Models;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Ewerton", "Lucas", "Matemática");
            aluno.Apresentar();
            
            // Log log1 = Log.GetInstance();
            // log1.PropTeste = "Texto de teste";

            // Log log2 = Log.GetInstance();
            // Console.WriteLine(log2.PropTeste);

            // Pessoa p1 = new Pessoa();
            // Pessoa p2 = new Pessoa("Ewerton", "Ramos");

            // p1.Apresentar();
            // p2.Apresentar();
        }
    }
}

