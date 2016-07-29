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
                Pokemon aux = new Pokemon(item.PokemonId.ToString(), item.IndividualAttack, item.IndividualDefense, item.IndividualStamina);
                ordered.Add(aux);
            }

            ordered.Sort();

            return ordered;
        }

        private static void Print(List<Pokemon> l)
        {
            foreach (var item in l)
            {
                Console.WriteLine(item.Name + ": " + item.Attack + " - " + item.Defense + " - " + item.Stamina + " (" + item.Iv + "%)");
            }
        }
    }
}
