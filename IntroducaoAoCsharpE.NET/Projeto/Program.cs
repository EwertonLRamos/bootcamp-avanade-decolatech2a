using System;
using Namespace1;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var classe1 = new Classe1();
            var classe2 = new Classe2();
            var classe3 = new Namespace2.Classe3();
            var classe4 = new Namespace2.Classe4();
            
            Console.WriteLine("Hello World!");
        }
    }
}
