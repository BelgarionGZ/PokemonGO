using System;

namespace PokemonGo.Program.Entities
{
    class Pokemon : IComparable
    {
        private string name;
        private double attack;
        private double defense;
        private double stamina;
        private double iv;

        public Pokemon(string name, double attack, double defense, double stamina)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defense = defense;
            this.Stamina = stamina;

            iv = Math.Round(attack * (20.0 / 9.0) + defense * (20.0 / 9.0) + stamina * (20.0 / 9.0));
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Attack
        {
            get
            {
                return attack;
            }

            set
            {
                attack = value;
            }
        }

        public double Defense
        {
            get
            {
                return defense;
            }

            set
            {
                defense = value;
            }
        }

        public double Stamina
        {
            get
            {
                return stamina;
            }

            set
            {
                stamina = value;
            }
        }

        public double Iv
        {
            get
            {
                return iv;
            }

            set
            {
                iv = value;
            }
        }

        public int CompareTo(Pokemon p)
        {
            return this.iv.CompareTo(p.iv);
        }

        public int CompareTo(object obj)
        {
            Pokemon p = obj as Pokemon;
            return this.iv.CompareTo(p.iv);
        }
    }
}
