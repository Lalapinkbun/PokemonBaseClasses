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

        //Items for outdoor use
        public void Repel()
        {
            //The Pokemon Will Not Appear a short period of time
            //Using Timer
            //Update Later
        }

        public void Flute(Pokemon pokemon, PokemonDataType.StatCondition statCondition)
        {
            //Can solve Status condition and other uses
            //Update Later
        }

        public void Mulch()
        {
            //Fertilizer for growing fruit trees. But it is completely unsuitable for the soil in the Hoenn region, so it has no effect.
            //Update Later
        }

        public void Nectar()
        {
            //Can Change what some Pokémon look like
            //Update Later
        }

        //Items for training Pokémon
        public void Enhancer()
        {
            //Increase The Move PP and Pokemon Statistic Base Point
            //Update Later
        }

        public void Wing(Pokemon pokemon, PokemonDataType.StatType statType, int Length)
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

        public void Mint()
        {
            //Give Pokemono smelling The mint can make the Pokémon easier or harder(one of each) to increase the Pokémon's Stat.
            //Update Later
        }

        public void Grit()
        {
            //Can Increases The Pokemon Effort level.
            //Update Layer
        }

        public void Mochi()
        {
            //Can Increases The Pokemon 1 of Base Points.
            //Update Later
        }

        //Evolution Items
        public void EvolutionStone(Pokemon pokemon, string name, string pokemonID, string type, string ability)
        {
            pokemon.Evolution(name, pokemonID, type, ability);
        }

        public void EvulotionOther()
        {
            //Other Item For Evulotion
            //Update Later
        }

        //Apricorn Items
        public void Apricorn()
        {
            //Apricorn that Pokémon can eat
            //Update Later
        }

        //Tera Shard Items
        public void Tera_Shard()
        {
            //When a Terastal Pokémon is defeated, there is a very low chance that the broken Terastal Gem will crystallize into this object. Just sell it
            //Updata Later
        }

        //Carry Items
        public void NormalCarry()
        {
            //Generally, there are no series of Items
            //Update Later
        }

        public void CarryBerry()
        {
            //Recover Hp, Status condition and PP
            //Update Later
        }

        public void Incense()
        {
            //Various increases
            //Upadate Later
        }

        public void Plate()
        {
            //Increases The Type Damage
            //Update Later
        }

        public void Power()
        {
            //Can make the Pokémon to increase the Pokémon's Type Damage
            //Update Later
        }

        public void Drive()
        {
            //Can Make Genesect of Techno Blast Skill Type Change
            //Update Later
        }

        public void Gem()
        {
            //Increases The Type Damage, But Just Once
            //Update Later
        }

        public void MegaStone()
        {
            //Can Make Some of Pokemon Mega Evulotion
            //Update Later
        }

        public void Seed()
        {
            //In a specific field, the defense and special defense of your Pokémon will be Increase.
            //Update Later
        }

        public void Memory()
        {
            //For Type: Null or Silvally To Chang They Type.
            //Update Later
        }

        public void Sweet()
        {
            //For Milcery.
            //Update Later
        }
        
        //Mail Items
        public void Mail()
        {
            //I don't Know What It Does
            //Update Later
        }

        //Candy Items
        public void Candy()
        {
            //Get Exp or Up Lavel or increase the Pokémon's Stat.
            //Update Later
        }

        //PokeBall
        public void PokeBall()
        {
            //Used to catch Pokemon
            //Update Later
        }

        //Valuable Item
        public void Valuable()
        {
            //You Can Use To Sell Something?
            //Update Later
        }

        //Fossil Item
        public void Fossil()
        {
            //Maybe some Pokémon can be hatched?
            //Update Later
        }

        //Combat Item
        public void Combat()
        {
            //Use For Battle
            //Update Later
        }

        //Technical Items
        public void Technical()
        {
            //Learn Something
            //Update Later
        }

        //Recover Items
        public void Posion(Pokemon pokemon, int RecoverHp)
        {
            pokemon.UpHealPoint(RecoverHp);
        }

        //Z Items
        public void PokemonZ()
        {
            //To Let Pokemon Use The Z Move
            //Update Later
        }

        //Berry Items
        public void Berry()
        {
            //Almighty Barry
            //Update Later
        }
    }
}
