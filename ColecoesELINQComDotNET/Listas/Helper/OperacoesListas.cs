namespace Listas.Helper
{
    public class OperacoesListas
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Indice {0} | Valor {1}", i, lista[i]);
            }
        }
    }
}