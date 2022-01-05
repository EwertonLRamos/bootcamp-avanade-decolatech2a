using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    interface IAnimal
    {
        void CorrigeNome(string novoNome);
        void CorrigeIdade(int novaIdade);
        void CorrigeDono(string novoNomeDono);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Dono { get; set; }

        public void CorrigeNome(string novoNome)
        {
            Nome = novoNome;
        }

        public void CorrigeIdade(int novaIdade)
        {
            Idade = novaIdade;
        }

        public void CorrigeDono(string novoNomeDono)
        {
            Dono = novoNomeDono;
        }

    }

}
