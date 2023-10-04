using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LalaPokemon
{
    public class TypeChart
    {
        private Dictionary<string, List<string>> typeChart;

        public TypeChart()
        {
            typeChart = new Dictionary<string, List<string>>();
            ReadTypeChart();
        }

        private void ReadTypeChart()
        {
            typeChart["Normal"] = new List<string>();
            typeChart["Fighting"] = new List<string> { "Normal", "Rock", "Steel", "Ice", "Dark" };
            typeChart["Flying"] = new List<string> { "Fighting", "Bug", "Grass" };
            typeChart["Poison"] = new List<string> { "Grass", "Fairy" };
            typeChart["Ground"] = new List<string> { "Poison", "Rock", "Steel", "Fire", "Electric" };
            typeChart["Rock"] = new List<string> { "Flying", "Bug", "Fire", "Ice" };
            typeChart["Bug"] = new List<string> { "Grass", "Psychic", "Dark" };
            typeChart["Ghost"] = new List<string> { "Ghost", "Psychic", "Dark" };
            typeChart["Steel"] = new List<string> { "Rock", "Ice", "Fairy" };
            typeChart["Fire"] = new List<string> { "Rock", "Grass", "Steel", "Ice" };
            typeChart["Water"] = new List<string> { "Rock", "Ground", "Fire" };
            typeChart["Grass"] = new List<string> { "Rock", "Ground", "Water" };
            typeChart["Electric"] = new List<string> { "Flying", "Water" };
            typeChart["Psychic"] = new List<string> { "Fighting", "Poison" };
            typeChart["Ice"] = new List<string> { "Flying", "Ground", "Grass", "Dragon" };
            typeChart["Dragon"] = new List<string> { "Dragon" };
            typeChart["Dark"] = new List<string> { "Ghost", "Psychic" };
            typeChart["Fairy"] = new List<string> { "Fighting", "Dragon", "Dark" };
        }
        public bool IsTypeEffective(string attackerType, string defenderType)
        {
            if (typeChart.ContainsKey(attackerType))
            {
                return typeChart[attackerType].Contains(defenderType);
            }
            return false;
        }
    }
}
