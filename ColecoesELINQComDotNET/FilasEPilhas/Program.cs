using System;
using System.Collections.Generic;

namespace FilasEPilhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilhaLivros = new Stack<string>();

            pilhaLivros.Push("Livro 1");
            pilhaLivros.Push("Livro 2");
            pilhaLivros.Push("Livro 3");

            Console.WriteLine("Livros na pilha: {0}", pilhaLivros.Count);

            while(pilhaLivros.Count > 0)
            {
                Console.WriteLine("Próximo livro para a leitura: {0}", pilhaLivros.Peek());
                Console.WriteLine("{0} lido com sucesso", pilhaLivros.Pop());
            }

            Console.WriteLine("Livros na pilha: {0}", pilhaLivros.Count);

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Nome1");
            // fila.Enqueue("Nome2");
            // fila.Enqueue("Nome3");

            // Console.WriteLine("Pessoas na fila: {0}", fila.Count);

            // while(fila.Count > 0)
            // {
            //     Console.WriteLine($"Vez de {fila.Peek()}");
            //     Console.WriteLine($"{fila.Dequeue()} foi atendido");
            // }

            // Console.WriteLine("Pessoas na fila: {0}", fila.Count);
        }
    }
}
