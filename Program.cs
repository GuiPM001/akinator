namespace Akinator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listaAnimais = GerarListaAnimais();

            Console.WriteLine("Pense em um animal dentre as opções abaixo: \n");
            
            foreach(var animal in listaAnimais)
                Console.WriteLine(animal.Nome.ToUpper());

            Console.WriteLine("\n----------------------------\n");
            Console.WriteLine("Responda 0 para Não e 1 para Sim\n");

            FazerPerguntas(listaAnimais);
        }

        public static void FazerPerguntas(List<Animal> listaAnimais)
        {
            PerguntarClassificacao(listaAnimais);
            PerguntarQuadrupede(listaAnimais);
            PerguntarAnimalDomestico(listaAnimais);
            PerguntarPorte(listaAnimais);
            PerguntarHabitat(listaAnimais);
        }

        public static List<Animal> GerarListaAnimais()
        {
            return new List<Animal> 
            {
                new Animal("Gato", Classificacao.Mamifero, 4, Porte.Pequeno, Habitat.Terrestre, true),
                new Animal("Leão", Classificacao.Mamifero, 4, Porte.Grande, Habitat.Terrestre, false),
                new Animal("Capivara", Classificacao.Mamifero, 4, Porte.Medio, Habitat.Terrestre, false),
                new Animal("Cavalo", Classificacao.Mamifero, 4, Porte.Grande, Habitat.Terrestre, true),
                new Animal("Baleia", Classificacao.Mamifero, 0, Porte.Grande, Habitat.Aquatico, false),
                new Animal("Leão Marinho", Classificacao.Mamifero, 0, Porte.Grande, Habitat.Terrestre_Aquatico, false),
                new Animal("Foca", Classificacao.Mamifero, 0, Porte.Medio, Habitat.Terrestre_Aquatico, false),
                new Animal("Calopsita", Classificacao.Ave, 2, Porte.Pequeno, Habitat.Terrestre, true),
                new Animal("Arara", Classificacao.Ave, 2, Porte.Pequeno, Habitat.Terrestre, false),
                new Animal("Garça", Classificacao.Ave, 2, Porte.Grande, Habitat.Terrestre, false),
                new Animal("Cobra Coral", Classificacao.Reptil, 0, Porte.Pequeno, Habitat.Terrestre, false),
                new Animal("Jacaré", Classificacao.Reptil, 4, Porte.Grande, Habitat.Terrestre_Aquatico, false),
                new Animal("Camaleão", Classificacao.Reptil, 4, Porte.Pequeno, Habitat.Terrestre, false),
                new Animal("Peixe", Classificacao.Peixe, 0, Porte.Pequeno, Habitat.Aquatico, true)
            };
        }

        #region Perguntas
        public static void PerguntarClassificacao(List<Animal> listaAnimais)
        {
            var resposta = "";
            do
            {
                Console.Write("O animal é mamifero? ");
                resposta = Console.ReadLine();

                if (resposta == "1")
                    listaAnimais.RemoveAll(a => a.Classificacao != Classificacao.Mamifero);

                else if (resposta == "0")
                    listaAnimais.RemoveAll(a => a.Classificacao == Classificacao.Mamifero);

            } while (resposta != "0" && resposta != "1");
            AdivinhouAnimal(listaAnimais);
        }

        public static void PerguntarQuadrupede(List<Animal> listaAnimais)
        {
            var resposta = "";
            do
            {
                Console.Write("O animal é quadrúpede? ");
                resposta = Console.ReadLine();

                if (resposta == "1")
                    listaAnimais.RemoveAll(a => a.NumeroPatas != 4);

                else if (resposta == "0")
                    listaAnimais.RemoveAll(a => a.NumeroPatas == 4);

            } while (resposta != "0" && resposta != "1");
            AdivinhouAnimal(listaAnimais);
        }

        public static void PerguntarAnimalDomestico(List<Animal> listaAnimais)
        {
            var resposta = "";
            do
            {
                Console.Write("O animal pode ser domesticado? ");
                resposta = Console.ReadLine();

                if (resposta == "1")
                    listaAnimais.RemoveAll(a => a.Domesticado != true);
                
                else if (resposta == "0")
                    listaAnimais.RemoveAll(a => a.Domesticado == true);
            
            } while (resposta != "0" && resposta != "1");
            AdivinhouAnimal(listaAnimais);
        }

        public static void PerguntarPorte(List<Animal> listaAnimais)
        {
            var resposta = "";
            do
            {
                Console.Write("O animal é de porte grande? ");
                resposta = Console.ReadLine();

                if (resposta == "1")
                    listaAnimais.RemoveAll(a => a.Porte != Porte.Grande);
                
                else if (resposta == "0")
                    listaAnimais.RemoveAll(a => a.Porte == Porte.Grande);
            
            } while (resposta != "0" && resposta != "1");
            AdivinhouAnimal(listaAnimais);
        }

        public static void PerguntarHabitat(List<Animal> listaAnimais)
        {
            var resposta = "";
            do
            {
                Console.Write("O animal é aquático? ");
                resposta = Console.ReadLine();

                if (resposta == "1")
                    listaAnimais.RemoveAll(a => a.Habitat != Habitat.Aquatico);
                
                else if (resposta == "0")
                    listaAnimais.RemoveAll(a => a.Habitat == Habitat.Aquatico);
            
            } while (resposta != "0" && resposta != "1");
            AdivinhouAnimal(listaAnimais);
        }

        #endregion

        public static void AdivinhouAnimal(List<Animal> listaAnimais)
        {
            if (listaAnimais.Count == 1)
            {
                Console.WriteLine($"\nO animal escolhido foi: {listaAnimais[0].Nome.ToUpper()}");
                Environment.Exit(Environment.ExitCode);
            }
        }
    }
}