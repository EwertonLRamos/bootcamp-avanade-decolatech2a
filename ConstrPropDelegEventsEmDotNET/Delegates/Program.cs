using System;
using Delegates.Models;

namespace Delegates
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            //Operacao op = new Operacao(Calculadora.Somar);
            Operacao op = Calculadora.Somar;
            op += Calculadora.Subtrair;

            //op(10, 10);
            op.Invoke(10, 10);
        }
    }
}
