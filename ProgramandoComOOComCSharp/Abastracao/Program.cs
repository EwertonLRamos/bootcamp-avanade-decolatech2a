using System;
using Abastracao.Models;

namespace Abastracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Ewerton", 21);

            p1.Apresentar();
        }
    }
}

