// See https://aka.ms/new-console-template for more information
//Point d'entrée de mon application
using MonJeu;

namespace MonApplication
{
static class Program
{
    static void Main(string[] args)
    {
        Character hero = new Character("Héros", 100, 20, 5);
        Character villain = new Character("Vilain", 80, 15, 5);

        Combat combat = new Combat(hero, villain);
        combat.StartFight();
    }
}
}

