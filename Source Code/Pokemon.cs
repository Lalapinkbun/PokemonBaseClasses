namespace LalaPokemon
{
    public class Pokemon
    {
        private string Name;
        private int Level;
        private string PokemonID;
        private int PokemonEXP;
        //Pokemon ability
        private int HealPoint;
        private int Attack;
        private int Defend;
        private int SpecialAttack;
        private int SpecialDefend;
        private int Speed;
        private string Type;
        private string Type2;
        private string Ability;

        private int needExpToLevelUp = 10;

        private bool haslevelup = false;
        private List<Move> moves = new List<Move>();


        public Pokemon(string name, int level, string pokemonID, int pokemonEXP, int hP, int aT, int sT, int dF, int sF, int sP, string type, string type2, string ability)
        {
            Name = name;
            Level = level;
            PokemonID = pokemonID;
            PokemonEXP = pokemonEXP;
            HealPoint = hP;
            Attack = aT;
            SpecialAttack = sT;
            Defend = dF;
            SpecialDefend = sF;
            Speed = sP;
            Type = type;
            Type2 = type2;
            Ability = ability;
        }


        public Pokemon(string name, int level, string pokemonID, int pokemonEXP, int hP, int aT, int dF, int sT, int sF, int sP, string type, string ability)
        {
            Name = name;
            Level = level;
            PokemonID = pokemonID;
            PokemonEXP = pokemonEXP;
            HealPoint = hP;
            Attack = aT;
            SpecialAttack = sT;
            Defend = dF;
            SpecialDefend = sF;
            Speed = sP;
            Type = type;
            Ability = ability;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetLevel()
        {
            return Level;
        }

        public string GetPokemonID() 
        {
            return PokemonID;
        }

        public int GetPokemonEXP()
        {
            return PokemonEXP;
        }

        public int GetHealPoint()
        {
            return HealPoint;
        }

        public void UpHealPoint(int hp)
        {
            HealPoint += hp;
        }

        public void DownHealPoint(int hp)
        {
            HealPoint -= hp;
        }

        public int GetAttack()
        {
            return Attack;
        }

        public void UpAttack(int at)
        {
            Attack += at;
        }

        public void DownAttack(int at)
        {
            Attack -= at;
        }

        public int GetDefend()
        {
            return Defend;
        }

        public void UpDefend(int df)
        {
            Defend += df;
        }

        public void DownDefend(int df)
        {
            Defend -= df;
        }

        public int GetSpecialAttack()
        {
            return SpecialAttack;
        }

        public void UpSpecialAttack(int st)
        {
            SpecialAttack += st;
        }

        public void DownSpecialAttack(int st)
        {
            SpecialAttack -= st;
        }

        public int GetSpecialDefend()
        {
            return SpecialDefend;
        }

        public void UpSpecialDefend(int sf)
        {
            SpecialDefend += sf;
        }

        public void DowmSpecialDefend(int sf)
        {
            SpecialDefend -= sf;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public void UpSpeed(int sp)
        {
            SpecialAttack += sp;
        }

        public void DownSpeed(int sp)
        {
            SpecialAttack -= sp;
        }

        public string GetPokemonType()
        {
            return Type;
        }

        public string GetPokemonTypeTwo()
        {
            return Type2;
        }

        public string GetAbility()
        {
            return Ability;
        }
    }
}