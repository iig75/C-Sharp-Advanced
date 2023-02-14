using System.Data;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; set; }


        public void Calculate(string command)
        {           
            if (Pokemons.Any(x=>x.Element == command))
            {
                Badges++;
            }
            else
            {
                for(int i=0; i<Pokemons.Count; i++)
                {
                    Pokemon currentPokemon = Pokemons[i];
                    
                    currentPokemon.Health -= 10;

                    if (currentPokemon.Health <= 0)
                    {
                        Pokemons.Remove(currentPokemon);
                    }
                }
            }

        }

        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Count()}";
        }
    }

}