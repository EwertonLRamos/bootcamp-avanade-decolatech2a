using System;
using Abstracionismo.Models;

namespace Abstracionismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Corrente c = new Corrente();

            c.Creditar(100);
            c.ExibirSaldo();
        }
    }
}
