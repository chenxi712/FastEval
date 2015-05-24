using System;

namespace FastEval
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			string board = "4d 5d 6c jc jd";
//			Hand player1 = new Hand("ac as", board);
//			Hand player2 = new Hand("ad ks", board);
//
//			// Print out a hand description: in this case both hands are
//			// A straight, six high
//			Console.WriteLine("Player1 Hand: {0}", player1.Description);
//			Console.WriteLine("Player2 Hand: {0}", player2.Description);
//
//			// Compare hands
//			if (player1 == player2)
//			{
//				Console.WriteLine("player1's hand is" + 
//					" equal to player2's hand");
//			} 
//			else if (player1 > player2)
//			{
//				Console.WriteLine("player1's hand is " + 
//					"greater than player2's hand");
//			}
//			else
//			{
//				Console.WriteLine("player2's hand is greater" + 
//					" than or equal player1's hand");
//			}

			/*
			int[] deck = new int[52];
			for (int i = 0; i < 52; ++i) 
			{
				deck [i] = i;
			}
			Shuffle (deck);
			for (int i = 0; i < 52; ++i) 
			{
				Console.Write ("{0}, ", deck[i]);
			}
			*/

		}

		public static void Shuffle (int[] deck)
		{
			Random r = new Random (DateTime.Now.Millisecond);
			for (int i = 0; i < deck.Length; ++i) 
			{
				int tmp = r.Next (i, 52);
				int t = deck [tmp];
				deck [tmp] = deck [i];
				deck [i] = t;
			}

		}
	}
}
