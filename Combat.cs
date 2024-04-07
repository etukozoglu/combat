namespace MonJeu;

public class Combat
{
    public Character Fighter1 { get; set; }
    public Character Fighter2 { get; set; }

    public Combat(Character fighter1, Character fighter2)
    {
        Fighter1 = fighter1;
        Fighter2 = fighter2;
    }

    public void StartFight()
    {
        Console.WriteLine("Le combat commence !");
        
        while (Fighter1.IsAlive() && Fighter2.IsAlive())
        {
            Fighter1.Attack(Fighter2);
            if (!Fighter2.IsAlive())
            {
                Console.WriteLine($"{Fighter1.Name} a gagné !");
                break;
            }

            Fighter2.Attack(Fighter1);
            if (!Fighter1.IsAlive())
            {
                Console.WriteLine($"{Fighter2.Name} a gagné !");
                break;
            }
        }
    }
}
