using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteAutomaton
{
	public class FailedState : State
	{
		#region Initializing

		public FailedState(Automaton automaton)
			: base("Failed", automaton)
		{
			Terminal = true;
		}

		#endregion

		#region Transitions

		protected override void InnerSetTransition(char symbol, State state)
		{
			// nothing to do;
		}

		#endregion
	}
}
