using System;
using System.Collections.Generic;

namespace FastEval
{
	public enum RuleTypes
	{
		Limit, PotLimit, NoLimit 
	}

	public class Rules
	{
		private int potSize;
		private int smallBlind;
		private int bigBlind;
		private const int maxNumOfPlayers = 10;

		private RuleTypes ruleType;
		private Dictionary<int, Player> players;
		private List<string> deck;
		private string flop;
		private string turn;
		private string river;

		private static Rules instance;

		public RuleTypes RuleTypeValue
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

		public static Rules GetInstance ()
		{
			if (instance == null)
			{
				instance = new Rules ();
			}
			return instance;
		}

		public Rules ()
		{
			InitData ();
			InitDeck ();
		}

		private void InitData ()
		{
			players = new Dictionary<int, Player> ();
			for (int i = 0; i < maxNumOfPlayers; ++i)
			{
				players.Add (i, null);
			}
		}

		private void InitDeck ()
		{
			if (deck == null)
				deck = new List<string> ();
			else
				deck.Clear ();
				
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

		public void Shuffle ()
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

		public int SitDown (Player player)
		{
			foreach (KeyValuePair<int, Player> kv in players)
			{
				if (kv.Value == null)
				{
					kv.Value = player;
					return kv.Key;
				}
			}
		}

		public int GetNumOfPlayer ()
		{
			int count = 0;
			foreach (KeyValuePair<int, Player> kv in players)
			{
				if (kv.Value != null)
					++count;
			}
			return count;
		}
	}
}

