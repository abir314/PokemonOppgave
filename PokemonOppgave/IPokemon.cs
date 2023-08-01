namespace PokemonOppgave;

public interface IPokemon
{
    int Health { get; set; }
    int AttackForce { get; set; }
    string Name { get; set; }
    string AttackName { get; set; }
    
    void Attack(IPokemon pokemon);

    void LooseHealth(int attackForce);
}