using System;

namespace ZombieGame_2S.Classes
{
	public class Zombie
	{
		public event Action Roared;

		public void Roar()
		{
			if (Roared != null)   // кто-то подписан на событие
			{
				Roared();
			}
		}
	}
}

