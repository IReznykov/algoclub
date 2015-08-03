using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteAutomaton
{
	public class State
	{
		#region Initializing

		private State()
		{
		}

		public State(Automaton automaton)
		{
			Automaton = automaton;
		}

		public State(string name, Automaton automaton)
			: this(automaton)
		{
			Name = name;
		}

		public string Name { get; set; }

		public override string ToString()
		{
			return Name ?? "Null state";
		}

		#endregion

		#region Automaton

		public Automaton Automaton { get; private set; }

		internal protected State Transit(char symbol)
		{
			if (transitions.ContainsKey(symbol))
			{
				return transitions[symbol];
			}
			else
			{
				return Automaton.FailedState;
			}
		}

		#endregion

		#region Transitions

		private Dictionary<char, State> transitions = new Dictionary<char, State>();

		protected virtual void InnerSetTransition(char symbol, State state)
		{
			transitions[symbol] = state;
		}

		public void SetTransition(char symbol, State state)
		{
			if (state == null || state.Automaton != Automaton)
				throw new ArgumentException("State belongs to another automaton");
			InnerSetTransition(symbol, state);
		}

		public void SetTransition(char[] symbols, State state)
		{
			if (state == null || state.Automaton != Automaton)
				throw new ArgumentException("State belongs to another automaton");
			foreach (var symbol in symbols)
				InnerSetTransition(symbol, state);
		}

		public void SetTransition(string symbols, State state)
		{
			if (state == null || state.Automaton != Automaton)
				throw new ArgumentException("State belongs to another automaton");
			foreach (var symbol in symbols)
				InnerSetTransition(symbol, state);
		}

		public bool Terminal { get; set; }

		#endregion
	}
}
