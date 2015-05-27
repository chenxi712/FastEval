using System;

namespace FastEval
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			InitPlayers ();
			Rules.GetInstance ().Shuffle ();
		}

		private void InitPlayers ()
		{
			int count = 6;
			for (int i = 0; i < count; ++i)
			{
				Player player = new Player (5000);
				player.SeatId = Rules.GetInstance ().SitDown (player);
			}
		}
	}
}
