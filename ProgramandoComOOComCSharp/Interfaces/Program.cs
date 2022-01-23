using System;
using Interfaces.Models;

namespace Interfaces 
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora c = new Calculadora();

            Console.WriteLine(c.Somar(10, 5));
        }
    }
}
