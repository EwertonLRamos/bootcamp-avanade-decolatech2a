using System;
using System.Collections.Generic;
using Listas.Helper;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesListas opLista = new OperacoesListas();
            List<string> estados = new List<string>();
            string[] estadosArray = new string[] {"RJ", "BA"};

            estados.Add("SP");
            estados.Add("PE");
            estados.Add("SE");

            Console.WriteLine("Quantidade de elementos na lista: {0}", estados.Count);

            opLista.ImprimirListaString(estados);
            //estados.AddRange(estadosArray);
            //estados.Remove("SP");
            estados.Insert(1, "RJ");
            opLista.ImprimirListaString(estados);
        }
    }
}
