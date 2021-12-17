namespace Edness_fight
{
	public static class Enemy
	{
		private static int Gold = 0;
		private static int Streight = 1;
		private static int Health = 10000;
		private static int Armor = 0;
		private static int PowerMining = 7;

		public static class MaxValues
		{
			public static int MaxHealth = 10000;
		}

		// Контроли значений
		public static int gold
		{
			get
			{
				return Gold;
			}
			set
			{
				if (value > int.MaxValue)
				{
					Gold = int.MaxValue;
					return;
				}
				if (value < 0)
				{
					Gold = 0;
					return;
				}

				Gold = value;
			}
		}

		public static int streight
		{
			get
			{
				return Streight;
			}
			set
			{
				if (value > int.MaxValue)
				{
					Streight = int.MaxValue;
					return;
				}
				if (value < 0)
				{
					Streight = 0;
					return;
				}

				Streight = value;
			}
		}

		public static int health
		{
			get
			{
				return Health;
			}
			set
			{
				if (value > MaxValues.MaxHealth)
				{
					Health = MaxValues.MaxHealth;
					return;
				}
				if (value < 0)
				{
					Health = 0;
					return;
				}

				Health = value;
			}
		}

		public static int armor
		{
			get
			{
				return Armor;
			}
			set
			{
				if (value > int.MaxValue)
				{
					Armor = int.MaxValue;
					return;
				}
				if (value < 0)
				{
					Armor = 0;
					return;
				}

				Armor = value;
			}
		}

		public static int powerMining
		{
			get
			{
				return PowerMining;
			}
			set
			{
				if (value > int.MaxValue)
				{
					PowerMining = int.MaxValue;
					return;
				}
				if (value < 0)
				{
					PowerMining = 0;
				}

				PowerMining = value;
			}
		}
	}
}
