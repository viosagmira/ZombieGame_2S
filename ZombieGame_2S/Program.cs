using ZombieGame_2S.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player();
        Zombie zombie = new Zombie();

        // подписка на событие
        zombie.Roared += player.ReactionOnZombieRoar;
        zombie.Ran += player.ReactionOnZombieRun;
        zombie.Stoped += player.ReactionOnZombieStop;

        zombie.Roar();
        zombie.Run();
        zombie.Stop();

        Console.ReadLine();   // pause
    }
}