using PokemonGo.Program.Entities;
using PokemonGo.RocketAPI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonGo.Program.Logic
{
    class ListPokemons
    {
        public static async void ByIV(Client client)
        {
            var inventory = await client.Inventory.GetInventory();
            var disorderedPokemons = inventory.InventoryDelta.InventoryItems.Select(i => i.InventoryItemData?.PokemonData).Where(p => p != null && p?.PokemonId > 0);
            List<Pokemon> sortedPokemons = ReadAndOrder(disorderedPokemons);
            Print(sortedPokemons);
        }

        private static List<Pokemon> ReadAndOrder(IEnumerable<POGOProtos.Data.PokemonData> disordered)
        {
            List<Pokemon> ordered = new List<Pokemon>();

            foreach (var item in disordered)
            {
                Pokemon aux = new Pokemon(item.PokemonId.ToString(), item.Cp, item.IndividualAttack, item.IndividualDefense, item.IndividualStamina);
                ordered.Add(aux);
            }

            ordered.Sort();

            return ordered;
        }

        private static void Print(List<Pokemon> l)
        {
            foreach (var item in l)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Name: " + item.Name.PadRight(15));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("CP: " + item.Cp.ToString().PadRight(10));
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Attack: " + item.Attack.ToString().PadRight(5));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Defense: " + item.Defense.ToString().PadRight(5));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Stamina: " + item.Stamina.ToString().PadRight(5));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("IV: " + item.Iv.ToString() + "%");
                Console.WriteLine();
            }
        }
    }
}
