﻿using ZombieGame_2S.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player();
        Zombie zombie = new Zombie();

        // подписка на событие
        zombie.Roared += player.ReactionOnZombieRoar;

        zombie.Roar();

        Console.ReadLine();   // pause
    }
}