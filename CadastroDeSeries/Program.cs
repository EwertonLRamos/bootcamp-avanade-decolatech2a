using System;

namespace CadastroDeSeries
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        private struct DadosSerie
        {
            public int entradaGenero;
            public string entradaTitulo;
            public int entradaAno;
            public string entradaDescricao;
        }
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1" :
                        ListarSeries();
                        Console.ReadKey();
                        break;
                    case "2" :
                        InserirSerie();
                        break;
                    case "3" :
                        AtualizarSerie();
                        break;
                    case "4" :
                        ExcluirSerie();
                        break;
                    case "5" :
                        VisualizarSerie();
                        break;
                    default :
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.Clear();
            Console.WriteLine("Obrigado por usar o nosso sistema!");
            Console.ReadKey();
        }
        private static void ListarSeries()
        {
            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("\nNenhuma série cadastrada.");
                return;
            }

            EscreverTitulo("LISTA DAS SÉRIES\n");

            foreach (var item in lista)
            {
                if(!item.RetornaExclusao())
                    Console.WriteLine("ID {0} - {1}", item.RetornaId(), item.RetornaTitulo());
            } 
        }
        private static void InserirSerie()
        {
            EscreverTitulo("INSERIR NOVA SÉRIE");

            MostrarGeneros();
            
            DadosSerie dadosSerie = LerDadosSerie(false);

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)dadosSerie.entradaGenero,
                                        titulo: dadosSerie.entradaTitulo,
                                        ano: dadosSerie.entradaAno,
                                        descricao: dadosSerie.entradaDescricao);

            repositorio.Insere(novaSerie);
        }
        private static void AtualizarSerie()
        {
            if(repositorio.ProximoId() == 0)
            {
                Console.WriteLine("\nNenhuma série cadastrada.");
                Console.ReadKey();
                return;
            }

            EscreverTitulo("ATUALIZAR DADOS");

            ListarSeries();

            int indiceSerie = LerId(false);

            MostrarGeneros();

            DadosSerie dadosSerie = LerDadosSerie(false);

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                            genero: (Genero)dadosSerie.entradaGenero,
                                            titulo: dadosSerie.entradaTitulo,
                                            ano: dadosSerie.entradaAno,
                                            descricao: dadosSerie.entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
        private static void ExcluirSerie()
        {
            if(repositorio.ProximoId() == 0)
            {
                Console.WriteLine("\nNenhuma série cadastrada.");
                Console.ReadKey();
                return;
            }

            EscreverTitulo("EXCLUIR SÉRIE");

            ListarSeries();

            int indiceSerie = LerId(false);

            repositorio.Exclui(indiceSerie);
        }
        public static void VisualizarSerie()
        {
            if(repositorio.ProximoId() == 0)
            {
                Console.WriteLine("\nNenhuma série cadastrada.");
                Console.ReadKey();
                return;
            }

            ListarSeries();

            int indiceSerie = LerId(false);

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
            Console.ReadKey();
        }
        private static string ObterOpcaoUsuario()
        {
            Console.Clear();
            Console.WriteLine("*****CADASTRO DE SÉRIES*****\n");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine(" 1 - Listar séries");
            Console.WriteLine(" 2 - Inserir nova série");
            Console.WriteLine(" 3 - Atualizar série");
            Console.WriteLine(" 4 - Excluir série");
            Console.WriteLine(" 5 - Visualizar série");
            Console.WriteLine(" X - Sair\n");

            Console.Write("Sua escolha: ");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            
            return opcaoUsuario;
        }
        private static int LerId(bool ativaRecursao)
        {
            if(ativaRecursao)
                ListarSeries();

            Console.Write("\nDigite o id da série: ");
            int numId = int.Parse(Console.ReadLine());

            if(numId < 0 || numId > repositorio.ProximoId()-1)
            {
                Console.WriteLine("Escolha uma opção válida.");
                Console.ReadKey();
                return LerId(true);
            }
            else
            {
                ativaRecursao = false;
                return numId;
            }
        }
        private static void MostrarGeneros()
        {
            Console.WriteLine("\nEscolha um gênero:");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                if(i < 10)
                    Console.Write(" ");

                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine();
        }
        private static DadosSerie LerDadosSerie(bool ativaRecursao)
        {
            DadosSerie dadosSerie = new DadosSerie();

            if(ativaRecursao)
            {
                EscreverTitulo("INFORME OS DADOS");
                MostrarGeneros();
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int numGenero = int.Parse(Console.ReadLine());
            
            if(numGenero < 1 || numGenero > 13)
            {
                Console.WriteLine("Escolha uma opção válida.");
                Console.ReadKey();
                return LerDadosSerie(true);
            }
            else
            {
                dadosSerie.entradaGenero = numGenero;
                ativaRecursao = false;
            }

            Console.Write("Digite o título da série: ");
            dadosSerie.entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de inicio da série: ");
            dadosSerie.entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            dadosSerie.entradaDescricao = Console.ReadLine();

            return dadosSerie;
        }
        private static void EscreverTitulo(string titulo)
        {
            Console.Clear();
            Console.WriteLine(titulo);
        }
    }
}