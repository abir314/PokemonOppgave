using PokemonOppgave;

class Program
{
    static void Main(string[] args)
    {
        var wildPokemons = new List<IPokemon>(){
            new Pikachu(200,50, "Pikachu", "Thunderbolt"),
            new Charmender(300,70, "Charmender", "Fireball")};
        var attackedPokemon = new Magikarp(400, 30, "Magikarp", "Splash");
        while (attackedPokemon.Health > 0)
        {
            Console.Clear();
            var chosenPokemon = GetWildPokemon(wildPokemons);
            Console.WriteLine($"Now {chosenPokemon.Name} will attack {attackedPokemon.Name}");
            chosenPokemon.Attack(attackedPokemon);
            Console.WriteLine();
            Console.WriteLine($"{chosenPokemon.Name} has used {chosenPokemon.AttackName} with ability power {chosenPokemon.AttackForce} to attack {attackedPokemon.Name}.");
            Console.WriteLine();
            Console.WriteLine($"{attackedPokemon.Name}'s health: {attackedPokemon.Health}");
            Console.WriteLine();
            Thread.Sleep(4500);
            
        }
    }

    private static IPokemon GetWildPokemon(List<IPokemon> wildPokemons)
    {
        var index = new Random().Next(0, wildPokemons.Count);
        return wildPokemons[index];
    }
}