namespace PokemonBackend_WebApi
{
    public class PokemonRepository
    {
        private static List<Pokemon> _pokemons = new List<Pokemon>();

        public static void Initialize()
        {
            _pokemons.Add(new Pokemon
{
    Name = "Pikachu",
    Type = "Electric",
    Height = 0.4F,
    Weight = 6.0F
});

_pokemons.Add(new Pokemon
{
    Name = "Bulbasaur",
    Type = "Grass/Poison",
    Height = 0.7F,
    Weight = 6.9F
});

_pokemons.Add(new Pokemon
{
    Name = "Charmander",
    Type = "Fire",
    Height = 0.6F,
    Weight = 8.5F
});

_pokemons.Add(new Pokemon
{
    Name = "Squirtle",
    Type = "Water",
    Height = 0.5F,
    Weight = 9.0F
});

_pokemons.Add(new Pokemon
{
    Name = "Jigglypuff",
    Type = "Normal/Fairy",
    Height = 0.5F,
    Weight = 5.5F
});

_pokemons.Add(new Pokemon
{
    Name = "Meowth",
    Type = "Normal",
    Height = 0.4F,
    Weight = 4.2F
});

_pokemons.Add(new Pokemon
{
    Name = "Psyduck",
    Type = "Water",
    Height = 0.8F,
    Weight = 19.6F
});

_pokemons.Add(new Pokemon
{
    Name = "Machop",
    Type = "Fighting",
    Height = 0.8F,
    Weight = 19.5F
});

_pokemons.Add(new Pokemon
{
    Name = "Geodude",
    Type = "Rock/Ground",
    Height = 0.4F,
    Weight = 20.0F
});

_pokemons.Add(new Pokemon
{
    Name = "Eevee",
    Type = "Normal",
    Height = 0.3F,
    Weight = 6.5F
});

        }

        public static List<Pokemon> GetPokemonList()
        {
            if (_pokemons == null || _pokemons.Count == 0)
            {
                Initialize();
            }
            return _pokemons;
        }

        public static void AddPokemon(Pokemon pokemon)
        {
            _pokemons.Add(pokemon);
        }
    }
}