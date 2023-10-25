using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LalaPokemon
{
    public class TypeChart
    {
        private Dictionary<string, List<string>> typeChartEffective;
        private Dictionary<string, List<string>> typeChartIneffective;

        public TypeChart()
        {
            typeChartEffective = new Dictionary<string, List<string>>();
            typeChartIneffective = new Dictionary<string, List<string>>();
            ReadTypeChart();
        }

        
        private void ReadTypeChart()
        {
            //The Type Was Effective x2
            typeChartEffective["Normal"] = new List<string>();
            typeChartEffective["Fighting"] = new List<string> { "Normal", "Rock", "Steel", "Ice", "Dark" };
            typeChartEffective["Flying"] = new List<string> { "Fighting", "Bug", "Grass" };
            typeChartEffective["Poison"] = new List<string> { "Grass", "Fairy" };
            typeChartEffective["Ground"] = new List<string> { "Poison", "Rock", "Steel", "Fire", "Electric" };
            typeChartEffective["Rock"] = new List<string> { "Flying", "Bug", "Fire", "Ice" };
            typeChartEffective["Bug"] = new List<string> { "Grass", "Psychic", "Dark" };
            typeChartEffective["Ghost"] = new List<string> { "Ghost", "Psychic", "Dark" };
            typeChartEffective["Steel"] = new List<string> { "Rock", "Ice", "Fairy" };
            typeChartEffective["Fire"] = new List<string> { "Bug", "Grass", "Steel", "Ice" };
            typeChartEffective["Water"] = new List<string> { "Rock", "Ground", "Fire" };
            typeChartEffective["Grass"] = new List<string> { "Rock", "Ground", "Water" };
            typeChartEffective["Electric"] = new List<string> { "Flying", "Water" };
            typeChartEffective["Psychic"] = new List<string> { "Fighting", "Poison" };
            typeChartEffective["Ice"] = new List<string> { "Flying", "Ground", "Grass", "Dragon" };
            typeChartEffective["Dragon"] = new List<string> { "Dragon" };
            typeChartEffective["Dark"] = new List<string> { "Ghost", "Psychic" };
            typeChartEffective["Fairy"] = new List<string> { "Fighting", "Dragon", "Dark" };
            //The Type Was Not Effective x0.5
            typeChartIneffective["Normal"] = new List<string> { "Rock", "Steel" };
            typeChartIneffective["Fighting"] = new List<string> { "Flying", "Posion", "Bug", "Psychic", "Fairy" };
            typeChartIneffective["Flying"] = new List<string> { "Rock", "Steel", "Electric" };
            typeChartIneffective["Poison"] = new List<string> { "Poison", "Ground", "Rock", "Ghost" };
            typeChartIneffective["Ground"] = new List<string> { "Bug", "Grass" };
            typeChartIneffective["Rock"] = new List<string> { "Fighting", "Ground", "Steel" };
            typeChartIneffective["Bug"] = new List<string> { "Fighting", "Flying", "Poison", "Ghost", "Steel", "Fire", "Fairy" };
            typeChartIneffective["Ghost"] = new List<string> { "Dark" };
            typeChartIneffective["Steel"] = new List<string> { "Steel", "Fire", "Water", "Electric" };
            typeChartIneffective["Fire"] = new List<string> { "Rock", "Fire", "Water", "Dragon" };
            typeChartIneffective["Water"] = new List<string> { "Water", "Grass", "Dragon" };
            typeChartIneffective["Grass"] = new List<string> { "Flying", "Poison", "Bug", "Steel", "Fire", "Grass", "Dragon" };
            typeChartIneffective["Electric"] = new List<string> { "Grass", "Electric", "Dragon" };
            typeChartIneffective["Psychic"] = new List<string> { "Steel", "Psychic" };
            typeChartIneffective["Ice"] = new List<string> { "Steel", "Fire", "Water", "Ice" };
            typeChartIneffective["Dragon"] = new List<string> { "Steel" };
            typeChartIneffective["Dark"] = new List<string> { "Fighting", "Dark", "Fairy" };
            typeChartIneffective["Fairy"] = new List<string> { "Posion", "Steel", "Fire" };
        }

        public float IsTypeEffectiveAndCountPlusDamage(Pokemon attackerType, Pokemon defenderType)
        {
            float plusDamage = 0f;

            if (typeChartEffective.ContainsKey(defenderType.GetPokemonType()))
            {
                plusDamage = 2f;
                if (!(defenderType.GetPokemonTypeTwo() == "No Second Type"))
                {
                    if (typeChartEffective.ContainsKey(defenderType.GetPokemonTypeTwo()))
                    {
                        plusDamage += 2f;
                    }
                }
            }
            else if (typeChartIneffective.ContainsKey(defenderType.GetPokemonType()))
            {
                plusDamage = 0.5f;
                if (!(defenderType.GetPokemonTypeTwo() == "No Second Type"))
                {
                    if (typeChartEffective.ContainsKey(defenderType.GetPokemonTypeTwo()))
                    {
                        plusDamage  = 0.25f;
                    }
                }
            }
            else
            {
                plusDamage = 1f;
            }

            return plusDamage;

        }
    }
}
