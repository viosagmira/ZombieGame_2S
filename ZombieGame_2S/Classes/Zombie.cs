using System;

namespace ZombieGame_2S.Classes
{
	public class Zombie
	{
		public event Action Roared;
		public event Action<string> Ran;

		public void Run()
		{
			if (Ran != null)
			{
				Ran("jokey");
			}
		}

		public void Roar()
		{
			if (Roared != null)   // кто-то подписан на событие
			{
				Roared();
			}
		}
	}
}

