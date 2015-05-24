using System;

namespace FastEval
{
	public static class GameEventManager
	{
		public delegate void GameEvent ();
		public delegate void RaiseEvent (float raiseTo);
		public delegate void AllInEvent (float total);

		public static event GameEvent Preflop, Flop, Turn, River;
		public static event GameEvent Call;
		public static event RaiseEvent Raise;
		public static event AllInEvent AllIn;

		public static void TriggerPreflop ()
		{
			if (Preflop != null)
				Preflop ();
		}

		public static void TriggerFlop ()
		{
			if (Flop != null)
				Flop ();
		}

		public static void TriggerTurn ()

		{
			if (Turn != null)
				Turn ();
		}

		public static void TriggerRiver ()
		{
			if (River != null)
				River ();
		}

		public static void TriggerCall ()
		{
			if (Call != null)
				Call ();
		}

		public static void TriggerRaise (float raiseTO)
		{
			if (Raise != null)
				Raise (raiseTO);
		}

		public static void TriggerAllIn (float total)
		{
			if (AllIn != null)
				AllIn (total);
		}
	}
}

