namespace Arrays.Helper
{
    public class OperacoesArrays
    {
        public void OrdenarBubbleSort(ref int[] array)
        {
            int aux;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < (array.Length-1); j++)
                {
                    if(array[j] > array[j+1])
                    {
                        aux = array[j+1];
                        array[j+1] = array[j];
                        array[j] = aux;
                    }
                }    
            }
        }
        public void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine(" ");
        }
        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }
        public void Copia( ref int[] array, ref int[] arrayCopia)
        {
            Array.Copy(array, arrayCopia, array.Length);
        }
        public bool VeriifcarExistencia(int[] array, int valor)
        {
            return Array.Exists(array, i => i == valor);
        }
        public bool VerificaArrayCompleto(int[] array, int valor)
        {
            return Array.TrueForAll(array, i => i > valor);
        }
        public int BuscarValor(int[] array, int valor)
        {
            return Array.Find(array, i => i == valor);
        }
        public int BuscarIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }
        public void RedimensionarArray(ref int[] array, int novaCapacidade)
        {
            Array.Resize(ref array, novaCapacidade);
        }
        public string[] ConverterParaString(int[] array)
        {
            return Array.ConvertAll(array, i => i.ToString());
        }
    }
}