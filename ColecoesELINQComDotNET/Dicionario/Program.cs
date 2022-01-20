using System;

namespace Dicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP", "São Paulo");
            estados.Add("RJ", "Rio de Janeiro");
            estados.Add("PE", "Pernambuco");

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     Console.WriteLine("Chave {0} | Valor {1}", item.Key, item.Value);
            // }

            string valor = "PE";

            if(estados.TryGetValue(valor, out string estado))
                Console.WriteLine(estado);
            else
                Console.WriteLine("Chave inexistente");

            // Console.WriteLine("\nRemovendo {0}\n", valor);
            // estados.Remove(valor);

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     Console.WriteLine("Chave {0} | Valor {1}", item.Key, item.Value);
            // }

            // Console.Write("Valor original: ");
            // Console.WriteLine(estados[valor]);

            // estados[valor] = "Novo valor";

            // Console.Write("Valor atualizado: ");
            // Console.WriteLine(estados[valor]);
        }
    }
}
