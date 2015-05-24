using System;
using System.Collections.Generic;

namespace FastEval
{
	public enum RuleTypes
	{
		Limit, PotLimit, NoLimit 
	}

	public class LocalGame
	{
		private float pot;
		private float smallBlind;
		private float bigBlind;
		private int numOfPlayers;

		private RuleTypes ruleType;
		private List<Player> players;
		private List<string> deck = new List<string> ();

		public RuleTypes GameType
		{
			get { return ruleType; }
			set { ruleType = value; }
		}

		public LocalGame ()
		{
			InitDeck ();
		}

		private void InitDeck ()
		{
			string[] suits = { "s", "h", "c", "d" };
			string[] ranks = {"a", "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k"};
			for (int i = 0; i < suits.Length; ++i) 
			{
				for (int j = 0; j < ranks.Length; ++j) 
				{
					deck.Add (ranks[j] + suits[i]);
				}
			}
		}

		private void Shuffle ()
		{
			Random r = new Random (DateTime.Now.Millisecond);
			for (int i = 0; i < deck.Count; ++i) 
			{
				int tmp = r.Next (i, 52);
				string t = deck[tmp];
				deck[tmp] = deck[i];
				deck[i] = t;
			}
		}

		private void RegisteListener ()
		{

		}

		private void UnregisterListener ()
		{

		}


	}
}

