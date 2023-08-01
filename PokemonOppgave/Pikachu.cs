namespace PokemonOppgave;

public class Pikachu : IPokemon
{
    public int Health { get; set; }
    public int AttackForce { get; set; }
    public string Name { get; set; }
    public string AttackName { get; set; }


    public Pikachu(int health, int attackForce)
    {
        Health = health;
        AttackForce = attackForce;
    }

    public Pikachu(int health, int attackForce, string name, string attackName)
    {
        Health = health;
        AttackForce = attackForce;
        Name = name;
        AttackName = attackName;
    }

    public void Attack(IPokemon pokemon)
    {
       pokemon.LooseHealth(AttackForce); 
    }

    public void LooseHealth(int attackForce)
    {
        Health = Math.Max(0, (Health - attackForce));
    }
}