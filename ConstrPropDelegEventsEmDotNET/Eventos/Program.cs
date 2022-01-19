using System;
using Eventos.Models;

namespace Eventos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Matematica math = new Matematica(10, 20);
            math.Somar();
        }
    }
}
