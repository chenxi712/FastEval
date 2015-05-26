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
		private int pot;
		private int smallBlind;
		private int bigBlind;
		private int numOfPlayers;

		private RuleTypes ruleType;
		private Dictionary<int, Player> players;
		private List<string> deck;
		private string board;

		public RuleTypes GameType
		{
			get { return ruleType; }
			set { ruleType = value; }
		}

		public int NumOfPlayer 
		{
			get { return players.Count; }
		}

		public string Board
		{
			get { return board; }
			set { board = value; }
		}

		public LocalGame ()
		{
			InitDeck ();
		}

		private void InitData ()
		{
			players = new Dictionary<int, Player> ();
			deck = new List<string> ();
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

		private void GameStart ()
		{

		}

		private void GameOver ()
		{
			NextRound ();
		}

		private void NextRound ()
		{

		}

		private void EndCalcAccount ()
		{
			GameEventManager.TriggerGameOver ();
		}

		private void Call (int seatId, int money)
		{

		}

		private void Raise (int seatId, int raiseTo)
		{

		}
			
		private void AllIn (int seatId, int money)
		{

		}

		private void Check (int seatId)
		{

		}

		private void Fold (int seatId)
		{

		}
	}
}

