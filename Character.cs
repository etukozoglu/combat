namespace MonJeu;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackStrength { get; set; }
    public int DefenseStrength { get; set; }

    public Character(string name, int health, int attackStrength, int defenseStrength)
    {
        Name = name;
        Health = health;
        AttackStrength = attackStrength;
        DefenseStrength = defenseStrength;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void Attack(Character target)
    {
        int damage = AttackStrength - target.DefenseStrength;
        if (damage < 0) damage = 0; // Assurez-vous que les points de dommage ne soient pas négatifs.
        target.Health -= damage;
        Console.WriteLine($"{Name} attaque {target.Name} et inflige {damage} points de dégâts.");
        if (!target.IsAlive())
        {
            Console.WriteLine($"{target.Name} est mort.");
        }
    }
}
