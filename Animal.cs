using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akinator
{
    internal class Animal
    {
        public Animal(string nome, Classificacao classificacao, int numeroPatas, Porte porte, Habitat habitat, bool domesticado)
        {
            Nome = nome;
            Classificacao = classificacao;
            NumeroPatas = numeroPatas;
            Porte = porte;
            Habitat = habitat;
            Domesticado = domesticado;
        }

        public string Nome { get; private set; }
        public Classificacao Classificacao { get; private set; }
        public int NumeroPatas { get; private set; }
        public Porte Porte { get; private set; }
        public bool Domesticado { get; private set; }
        public Habitat Habitat { get; private set; }
    }

    internal enum Classificacao
    {
        Mamifero,
        Ave,
        Reptil,
        Peixe
    }

    internal enum Porte
    {
        Pequeno,
        Medio,
        Grande
    }

    internal enum Habitat
    {
        Terrestre,
        Aquatico,
        Terrestre_Aquatico
    }
}
