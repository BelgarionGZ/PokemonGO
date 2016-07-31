using System;

namespace PokemonGo.Program.Entities
{
    class Pokemon : IComparable
    {
        public Pokemon(string name, double cp, double attack, double defense, double stamina)
        {
            this.Name = name;
            this.Cp = cp;
            this.Attack = attack;
            this.Defense = defense;
            this.Stamina = stamina;
            this.Iv = Math.Round(attack * (20.0 / 9.0) + defense * (20.0 / 9.0) + stamina * (20.0 / 9.0));
        }

        public string Name { get; set; }

        public double Cp { get; set; }

        public double Attack { get; set; }

        public double Defense { get; set; }

        public double Stamina { get; set; }

        public double Iv { get; set; }

        public int CompareTo(Pokemon p)
        {
            return this.Iv.CompareTo(p.Iv);
        }

        public int CompareTo(object obj)
        {
            Pokemon p = obj as Pokemon;
            return this.Iv.CompareTo(p.Iv);
        }
    }
}