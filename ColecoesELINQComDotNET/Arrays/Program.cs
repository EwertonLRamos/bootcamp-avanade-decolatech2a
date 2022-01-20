using System;
using Arrays.Helper;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArrays op = new OperacoesArrays();
            int[] array = new int[] {9, 6, 7, 2, 8, 1};
            int[] arrayCopia = new int[10];
            string[] arrayString = op.ConverterParaString(array);

            foreach (var item in arrayString)
            {
                Console.WriteLine(item);
            }

            //int valor = 0;

            // Console.WriteLine("Capacidade original do array {0}", array.Length);

            // op.RedimensionarArray(ref array, array.Length * 2);

            // Console.WriteLine("Nova capacidade do array {0}", array.Length);
            
            // int indice = op.BuscarIndice(array,valor);
            // if(indice > -1)
            //     Console.WriteLine("O n° {0} tem o índice {1}", valor, indice);
            // else    
            //     Console.WriteLine("O n° {0} não está no array", valor);

            // if(op.BuscarValor(array, valor) != 0)
            //     Console.WriteLine("O n° {0} está no array", valor);
            // else    
            //     Console.WriteLine("O n° {0} não está no array", valor);

            // if(op.VerificaArrayCompleto(array, valor))
            //     Console.WriteLine("Todos são maiores que {0}", valor);
            // else    
            //     Console.WriteLine("Nem todos são maiores que {0}", valor);

            // if(op.VeriifcarExistencia(array, valor))
            //     Console.WriteLine("Existe");
            // else    
            //     Console.WriteLine("Não existe");

            // Console.WriteLine("Array antes da cópia:");
            // op.ImprimirArray(arrayCopia);

            // op.Copia(ref array, ref arrayCopia);

            // Console.WriteLine("Array depois da cópia");
            // op.ImprimirArray(arrayCopia);

            // Console.WriteLine("Array original:");
            // op.ImprimirArray(array);

            // op.OrdenarBubbleSort(ref array);
            // op.Ordenar(ref array);

            // Console.WriteLine("Array ordenado:");
            // op.ImprimirArray(array);

            // int[] arrayInt = new int[3];
            
            // int valor = 0;
            // // arrayInt[0] = 10;
            // // arrayInt[1] = 20;
            // // arrayInt[2] = 30;

            // int[,] matrizInt = new int[,]
            // {
            //     {5, 4, 3},
            //     {6, 7, 8}
            // };

            // for (int i = 0; i < matrizInt.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matrizInt.GetLength(1); j++)
            //     {
            //         Console.Write($"{matrizInt[i , j]} ");   
            //     }
            //     Console.WriteLine();
            // }

            // for(int i = 0; i < arrayInt.Length; i++)
            // {
            //     valor += 10;
            //     arrayInt[i] = valor;
            //     // Console.WriteLine(arrayInt[i]);
            // }
            
            // foreach (var item in arrayInt)
            // {
            //     Console.WriteLine(item);
            // }
        }
    }
}
