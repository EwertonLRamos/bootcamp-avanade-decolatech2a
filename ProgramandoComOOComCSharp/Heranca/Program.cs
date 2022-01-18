using System;
using Heranca.Models;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.Nome = "Ewerton";
            a.Idade = 21;
            a.Nota = 9;

            Professor p = new Professor();
            p.Nome = "João";
            p.Idade = 35;
            p.Salario = 2000;

            a.Apresentar();
            p.Apresentar();
        }
    }
}

