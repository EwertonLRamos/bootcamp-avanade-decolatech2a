using System;
using UtilizandoArquivos.Helper;

namespace UtilizandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Users\\Ewerton Lucas\\source\\repos\\BootcampAvanade\\ProgramandoComOOComCSharp\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Arquivo Teste.txt");
            var novoCaminho = Path.Combine(caminho, "Pasta Teste 2", "Arquivo Teste Stream.txt");
            var caminhoCopia = Path.Combine(caminho, "Arquivo Teste Copia.txt");

            var listaString = new List<string> {"Linha1", "Linha2", "Linha3"};
            var listaStringContinuacao = new List<string> {"Linha4", "Linha5", "Linha6"};
            
            FileHelper helper = new FileHelper();

            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivotexto(caminhoPathCombine, "Olá arquivo texto");
            //helper.CriarArquivotextoStream(caminhoPathCombine, listaString); 
            //helper.AdicionarArquivotextoStream(caminhoPathCombine, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoPathCombine);
            //helper.MoverArquivos(caminhoPathCombine, novoCaminho, false);
            //helper.CopiarArquivo(caminhoPathCombine, caminhoCopia, false);
            helper.DeletarArquivo(caminhoCopia);
        }
    }
}
