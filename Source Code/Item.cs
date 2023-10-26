using LalaPokemon.DataTypes;

namespace LalaPokemon
{

    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Id { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }

        public Item(string name, int quantity, string id, string context, string type)
        {
            Name = name;
            Quantity = quantity;
            Id = id;
            Content = context;
            Type = type;
        }

        public void Posion(Pokemon pokemon, int RecoverHp)
        {
            pokemon.UpHealPoint(RecoverHp);
        }

        public void Repel()
        {
            //The Pokemon Will Not Appear a short period of time
            //Update Later
        }

        public void PP(Pokemon pokemon, int Move, int Length)
        {
            pokemon.ReadMove(Move).UpPP(pokemon.ReadMove(Move), Length);
        }

        public void Statistic(Pokemon pokemon, PokemonDataType.StatType statType, int Length)
        {
            if (pokemon == null)
            {
                throw new ArgumentNullException("ErrorItem001 Pokemon Must Not Be Null", "Pokemon");
            }

            if (Length < 0)
            {
                throw new ArgumentOutOfRangeException("ErrorItem002 Length must be non-negative.", "Length");
            }

            switch (statType)
            {
                case PokemonDataType.StatType.HealPoints:
                    pokemon.UpHealPoint(Length);
                    break;
                case PokemonDataType.StatType.Attack:
                    pokemon.UpAttack(Length);
                    break;
                case PokemonDataType.StatType.Defense:
                    pokemon.UpDefend(Length);
                    break;
                case PokemonDataType.StatType.SpecialAttack: 
                    pokemon.UpSpecialAttack(Length); 
                    break;
                case PokemonDataType.StatType.SpecialDefense:
                    pokemon.UpSpecialDefend(Length);
                    break;
                case PokemonDataType.StatType.Speed: 
                    pokemon.UpSpeed(Length);
                    break;
                default:
                    throw new ArgumentException("ErrorItem003 statType is out of range.", "statType");
            }
        }

        public void Ability(Pokemon pokemon, string ability)
        {
            pokemon.SetAbility(ability);
        }

        public void PokeBall()
        {
            //Used to catch Pokemon
            //Update Later
        }

        public void Mint()
        {
            //Give Pokemono smelling The mint can make the Pokémon easier or harder(one of each) to increase the Pokémon's Stat.
            //Update Later
        }

        public void EvolutionStone(Pokemon pokemon, string name, string pokemonID, string type, string ability)
        {
            pokemon.Evolution(name, pokemonID, type, ability);
        }


    }
}
