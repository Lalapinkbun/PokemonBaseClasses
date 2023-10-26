namespace LalaPokemon
{
    public class Move
    {
        private string Name;
        private string Type;
        private int Power;
        private int Accuracy;
        private string Soft;
        private int PP;

        private TypeChart typeChart = new TypeChart();

        private Random random = new Random();

        public Move(string name, string type, int power, int accuracy, string soft, int pP)
        {
            Name = name;
            Type = type;
            Power = power;
            Accuracy = accuracy;
            Soft = soft;
            PP = pP;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetMoveType()
        {
            return Type;
        }

        public int GetPower()
        {
            return Power;
        }

        public int GetAccuracy()
        {
            return Accuracy;
        }

        public string GetSoft()
        {
            return Soft;
        }

        public int GetMovePP()
        {
            return PP;
        }
        public void UpPP(Move move,int num)
        {
            move.PP += num;
        }
        public int CalculateDamage(Pokemon attacker, Pokemon defender)
        {
            float FinaleDamage = 0;
            int Damage = 0;
            if (Type == "Physical")
                Damage = attacker.GetAttack() - (int)(Power / 10);
            else if (Type == "Special")
                Damage = attacker.GetSpecialAttack() - (int)(Power / 10);
            int randomValue = random.Next(1, 100);

            // Physical, Special or Status
            if (PP >= 0)
            {
                if (randomValue <= Accuracy)
                {
                    if (Soft == "Physical")
                    {
                        FinaleDamage = (Damage * typeChart.IsTypeEffectiveAndCountPlusDamage(attacker, defender)) - (int)(defender.GetDefend() / 2);
                    }
                    else if (Soft == "Special")
                    {
                        FinaleDamage = (Damage * typeChart.IsTypeEffectiveAndCountPlusDamage(attacker, defender)) - (int)(defender.GetSpecialDefend() / 2);
                    }
                    else if (Soft == "Status")
                    {
                        Status(attacker, defender);
                    }
                }
                else
                {
                    FinaleDamage = 0;
                }
            }


            return (int)FinaleDamage;
        }

        private void Status(Pokemon attacker, Pokemon defender)
        {
            switch (Name)
            {
                case "Agility":
                    attacker.UpSpeed(5 * 2);
                    break;
                case "Leer":
                    defender.DownDefend(5);
                    break;
                case "Howl":
                    attacker.DownAttack(5);
                    break;
                case "Growl":
                    defender.DownAttack(5);
                    break;
                case "Charm":
                    defender.DownAttack(5);
                    break;
                case "Scary Face":
                    defender.DownSpeed(5 * 2);
                    break;
                case "Dragon Dance":
                    attacker.UpAttack(5);
                    attacker.UpSpeed(5);
                    break;
                case "Work Up":
                    attacker.UpAttack(5);
                    attacker.UpSpecialAttack(5);
                    break;
                case "Tail Whip":
                    defender.DownDefend(5);
                    break;
                case "Play Nice":
                    attacker.DownAttack(5);
                    break;
                case "Baby-Doll Eyes":
                    attacker.DownAttack(5);
                    break;
                case "Screech":
                    defender.DownDefend(5 * 2);
                    break;
                case "Iron Defense":
                    attacker.UpDefend(5 * 2);
                    break;
                default:
                    break;
            }
        }
    }
}
