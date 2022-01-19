using System;
using GetSet.Models;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            data.Mes = 2;
            data.ApresentarMes();
        }
    }
}
