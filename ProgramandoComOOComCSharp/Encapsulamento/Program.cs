using System;
using Encapsulamento.Models;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            r.DefinirMedidas(3.5, 2);

            Console.WriteLine($"A área é {r.ObterArea()}");
        }
    }
}


