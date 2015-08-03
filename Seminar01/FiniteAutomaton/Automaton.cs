using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteAutomaton
{
	public class Automaton
	{
		#region Initializing

		public Automaton()
		{
			FailedState = new FailedState(this);

			_states.Add(FailedState);
			_initialState = FailedState;
			CurrentState = FailedState;
		}

		#endregion

		#region States

		private readonly List<State> _states = new List<State>();

		private State _initialState = null;

		public State InitialState
		{
			get
			{
				return _initialState;
			}
			set
			{
				if (value == null)
					return;

				AddState(value);
				_initialState = value;
				CurrentState = _initialState;
			}
		}

		public FailedState FailedState { get; private set; }

		public State CurrentState { get; private set; }

		public void AddState(State state)
		{
			if (!_states.Contains(state))
				_states.Add(state);
		}

		public State Transit(char symbol)
		{
			CurrentState = CurrentState.Transit(symbol);
			return CurrentState;
		}

		public void ResetState()
		{
			CurrentState = InitialState??FailedState;
		}

		public bool IsFailed
		{
			get { return CurrentState == FailedState; }
		}

		public bool IsSuccess
		{
			get { return CurrentState != FailedState && CurrentState.Terminal; }
		}

		#endregion

	}
}
