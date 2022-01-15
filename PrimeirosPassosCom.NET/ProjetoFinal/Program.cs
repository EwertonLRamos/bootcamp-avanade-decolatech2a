using System;

namespace ProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcao = PegarEscolhaUsuario();
            int indice = 0;

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        Aluno aluno = new Aluno();

                        if(indice < 5)
                        {
                            Console.WriteLine("CADASTRAR NOVO ALUNO");
                        
                            Console.Write("Informe o nome: ");
                            aluno.Nome = Console.ReadLine();

                            Console.Write("Informe a nota:");
                            if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                                aluno.Nota = nota;
                            else
                                throw new ArgumentException("A nota deve ser decimal");

                            alunos[indice] = aluno;
                            indice++;
                        }
                        else
                            Console.WriteLine("Limite de alunos atingido!");
                        break;

                    case "2":
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.Write($"Aluno: {a.Nome}");
                                Console.WriteLine($"  Nota: {a.Nota}");
                            }
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        int nmrALunos = 0;

                        for(int i = 0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal += alunos[i].Nota;
                                nmrALunos++;
                            }
                        }
                        var mediaGeral = notaTotal / nmrALunos;
                        Console.WriteLine($"A média geral dos alunos é: {mediaGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = PegarEscolhaUsuario();
            }
        }

        private static string PegarEscolhaUsuario()
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine(" 1 - Cadastrar novo aluno");
            Console.WriteLine(" 2 - Listar alunos");
            Console.WriteLine(" 3 - Calcular média geral");
            Console.WriteLine(" X - Sair");
            Console.Write("\n Sua escolha: ");

            string opcao = Console.ReadLine();
            return opcao;
        }
    }
}
