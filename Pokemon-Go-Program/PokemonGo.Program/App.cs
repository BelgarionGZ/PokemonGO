using PokemonGo.Program.Logic;
using PokemonGo.RocketAPI;

namespace PokemonGo.Program
{
    class App
    {
        public static async void run()
        {
            var client = new Client(new Settings());
            await client.Login.DoGoogleLogin(client.Settings.GoogleUsername, client.Settings.GooglePassword);
            ListPokemons.ByIV(client);
        }
    }
}
