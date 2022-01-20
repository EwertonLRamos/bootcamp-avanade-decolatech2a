using System;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {5, 4, 2, 0, 3, 9, 10, 10, 5, 0};

            var minimo = array.Min();
            var maximo = array.Max();
            var medio = array.Average();
            var soma = array.Sum();
            var unicos = array.Distinct().ToArray();

            Console.WriteLine("Minimo: {0} | Máximo: {1} | Médio: {2}", minimo, maximo, medio);
            Console.WriteLine("Soma: {0}", soma);
            Console.WriteLine("Array original: {0}", string.Join(", ", array));
            Console.WriteLine("Array modificado: {0}", string.Join(", ", unicos));

            // var linqQuery = 
            //     from num in array
            //     where num % 2 == 0
            //     orderby num
            //     select num;
            
            // var linqMetodo = array.Where( i => i % 2 == 0).OrderBy(i => i).ToList();

            // Console.WriteLine("Query " + string.Join(", ", linqQuery));
            // Console.WriteLine("Método " + string.Join(", ", linqMetodo));
        }
    }
}
