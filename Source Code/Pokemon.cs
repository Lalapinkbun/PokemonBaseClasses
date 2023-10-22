namespace LalaPokemon
{
    public class Pokemon
    {
        private string Name;
        private int Level;
        private string PokemonID;
        private int PokemonEXP;
        //Pokemon ability
        private int HealPointC;
        private int HealLevelM;
        private int AttackC;
        private int AttackM;
        private int DefendC;
        private int DefendM;
        private int SpecialAttackC;
        private int SpecialAttackM;
        private int SpecialDefendC;
        private int SpecialDefendM;
        private int SpeedC;
        private int SpeedM;
        private string Type;
        private string? Type2;
        private string Ability;

        private int needExpToLevelUp = 10;

        private bool haslevelup = false;
        private List<Move> moves = new List<Move>();

        //Two Type
        public Pokemon(string name, int level, string pokemonID, int pokemonEXP, int hP, int aT, int sT, int dF, int sF, int sP, string type, string type2, string ability)
        {
            Name = name;
            Level = level;
            PokemonID = pokemonID;
            PokemonEXP = pokemonEXP;
            HealPointC = hP;
            HealLevelM = hP;
            AttackC = aT;
            AttackM = aT;
            SpecialAttackC = sT;
            SpecialAttackM = sT;
            DefendC = dF;
            DefendM = dF;
            SpecialDefendC = sF;
            SpecialDefendM = sF;
            SpeedC = sP;
            SpeedM = sP;
            Type = type;
            Type2 = type2;
            Ability = ability;
        }

        //One Type
        public Pokemon(string name, int level, string pokemonID, int pokemonEXP, int hP, int aT, int dF, int sT, int sF, int sP, string type, string ability)
        {
            Name = name;
            Level = level;
            PokemonID = pokemonID;
            PokemonEXP = pokemonEXP;
            HealPointC = hP;
            HealLevelM = hP;
            AttackC = aT;
            AttackM = aT;
            SpecialAttackC = sT;
            SpecialAttackM = sT;
            DefendC = dF;
            DefendM = dF;
            SpecialDefendC = sF;
            SpecialDefendM = sF;
            SpeedC = sP;
            SpeedM = sP;
            Type = type;
            Ability = ability;
        }

        //One Type
        public void Evolution(string name, string pokemonID, string type, string ability)
        {
            Name = name;
            PokemonID = pokemonID;
            Type = type;
            Ability = ability;
        }
        
        //Two Type
        public void Evolution(string name, string pokemonID, string type, string type2, string ability)
        {
            Name = name;
            PokemonID = pokemonID;
            Type = type;
            Type2 = type2;
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
            return HealPointC;
        }

        public void UpHealPoint(int hp)
        {
            HealPointC += hp;
        }

        public void DownHealPoint(int hp)
        {
            HealPointC -= hp;
        }

        public int GetAttack()
        {
            return AttackC;
        }

        public void UpAttack(int at)
        {
            AttackC += at;
        }

        public void DownAttack(int at)
        {
            AttackC -= at;
        }

        public int GetDefend()
        {
            return DefendC;
        }

        public void UpDefend(int df)
        {
            DefendC += df;
        }

        public void DownDefend(int df)
        {
            DefendC -= df;
        }

        public int GetSpecialAttack()
        {
            return SpecialAttackC;
        }

        public void UpSpecialAttack(int st)
        {
            SpecialAttackC += st;
        }

        public void DownSpecialAttack(int st)
        {
            SpecialAttackC -= st;
        }

        public int GetSpecialDefend()
        {
            return SpecialDefendC;
        }

        public void UpSpecialDefend(int sf)
        {
            SpecialDefendC += sf;
        }

        public void DowmSpecialDefend(int sf)
        {
            SpecialDefendC -= sf;
        }

        public int GetSpeed()
        {
            return SpeedC;
        }

        public void UpSpeed(int sp)
        {
            SpecialAttackC += sp;
        }

        public void DownSpeed(int sp)
        {
            SpecialAttackC -= sp;
        }

        public string GetPokemonType()
        {
            return Type;
        }

        public string GetPokemonTypeTwo()
        {
            return Type2 ?? Name + "No Second Type";
        }

        public string GetAbility()
        {
            return Ability;
        }

        public void BackToDefault()
        {
            HealPointC = HealLevelM;
            DefendC = DefendM;
            SpecialAttackC = SpecialDefendM;
            SpecialDefendC = SpecialDefendM;
            SpeedC = SpeedM;
        }

        public void LevelUp()
        {
            Level++;
        }
    }
}