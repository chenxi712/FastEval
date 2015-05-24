using System;

namespace FastEval
{
	public enum PlayerState
	{
		Check, Fold, Call, Raise, AllIn
	}

	public class Player
	{
		private string name;
		private float cash;
		private PlayerState state;
		private int seatIdx;
		private Hand hand;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public float Cash
		{
			get { return cash; }
			set { cash = value; }
		}

		public PlayerState State
		{
			get { return state; }
			set { state = value; }
		}

		public int ChairIndex
		{
			get { return seatIdx; }
			set { seatIdx = value; }
		}

		public Hand HandValue
		{
			get { return hand; }
			set { hand = value; }
		}
	}
}

