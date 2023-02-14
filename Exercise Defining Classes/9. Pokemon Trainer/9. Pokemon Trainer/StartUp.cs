namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Tournament")
            {

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Trainer trainer = trainers.FirstOrDefault(x => x.Name == tokens[0]);

                if(trainer == null)
                {
                    trainer = new Trainer(tokens[0]);

                    Pokemon pokemon = new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3]));

                    trainer.Pokemons.Add(pokemon);

                    trainers.Add(trainer);
                }
                else
                {
                    Pokemon pokemon = new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3]));

                    trainer.Pokemons.Add(pokemon);
                }

            }



            while ((command = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    trainer.Calculate(command);
                }
            }



            foreach (Trainer trainer in trainers.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine(trainer.ToString());
            }



        }

    }
}