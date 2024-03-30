using System;

namespace ZombieGame_2S.Classes
{
	public class Player
	{

		// обработчики событий
		public void ReactionOnZombieRoar()
		{
			Console.WriteLine("[Player] Ой! Кто-то порычал!");
		}

		public void ReactionOnZombieRun(string zombieType)
		{
			Console.WriteLine($"[Player] Он бежит! Тип зомби {zombieType}");
		}

		public void ReactionOnZombieStop(Zombie zombie)
		{
			Console.WriteLine("[Player] Зомби остановился!");
		}

    }
}

