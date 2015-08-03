using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiniteAutomaton;

namespace NumberRecnogition
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			InitAutomata();
		}

		private void textBoxInput_TextChanged(object sender, EventArgs e)
		{
			Reset(false);
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			Reset(true);

		}

		private void buttonCheck_Click(object sender, EventArgs e)
		{
			var input = textBoxInput.Text;
			if (string.IsNullOrEmpty(input))
			{
				Reset(false);
				return;
			}

			checkBoxReGex1.CheckState = CheckPattern(_pattern1, input) ? CheckState.Checked : CheckState.Unchecked;
			checkBoxReGex2.CheckState = CheckPattern(_pattern2, input) ? CheckState.Checked : CheckState.Unchecked;
			checkBoxReGex3.CheckState = CheckPattern(_pattern3, input) ? CheckState.Checked : CheckState.Unchecked;

			checkBoxAutomaton1.CheckState = CheckAutomaton(_automaton1, input) ? CheckState.Checked : CheckState.Unchecked;
			checkBoxAutomaton2.CheckState = CheckAutomaton(_automaton2, input) ? CheckState.Checked : CheckState.Unchecked;
			checkBoxAutomaton3.CheckState = CheckAutomaton(_automaton3, input) ? CheckState.Checked : CheckState.Unchecked;

		}

		private void Reset(bool resetInput)
		{
			if (resetInput)
				textBoxInput.Text = string.Empty;

			checkBoxReGex1.CheckState = CheckState.Indeterminate;
			checkBoxReGex2.CheckState = CheckState.Indeterminate;
			checkBoxReGex3.CheckState = CheckState.Indeterminate;

			checkBoxAutomaton1.CheckState = CheckState.Indeterminate;
			checkBoxAutomaton2.CheckState = CheckState.Indeterminate;
			checkBoxAutomaton3.CheckState = CheckState.Indeterminate;
		}

		#region Recognition

		private readonly Regex _pattern1 = new Regex(@"^\d+$");
		private readonly Regex _pattern2 = new Regex(@"^\d*\.\d+$");
		private readonly Regex _pattern3 = new Regex(@"^(\s*)[-+]?\d*\.\d+([eE][+-]?\d+)?$");

		static bool CheckPattern(Regex pattern, string input)
		{
			return pattern.IsMatch(input);
		}

		private Automaton _automaton1;
		private Automaton _automaton2;
		private Automaton _automaton3;

		private void InitAutomata()
		{
			{
				// pattern ^\d+$
				_automaton1 = new Automaton();
				var initialState = new State("Initial", _automaton1);
				var digitState = new State("Digit", _automaton1);

				initialState.SetTransition("0123456789", digitState);

				digitState.SetTransition("0123456789", digitState);
				digitState.Terminal = true;
				 
				_automaton1.InitialState = initialState;
				_automaton1.AddState(digitState);
			}

			{
				// pattern ^\d*\.\d+$
				_automaton2 = new Automaton();
				var initialState = new State("Initial", _automaton2);
				var dotState = new State("Dot", _automaton2);
				var digitState = new State("Digit", _automaton2);

				initialState.SetTransition("0123456789", initialState);
				initialState.SetTransition(".", dotState);

				dotState.SetTransition("0123456789", digitState);

				digitState.SetTransition("0123456789", digitState);
				digitState.Terminal = true;

				_automaton2.InitialState = initialState;
				_automaton2.AddState(dotState);
				_automaton2.AddState(digitState);
			}


			{
				// pattern ^(\s*)[-+]?\d*\.\d+([eE][+-]?\d+)$
				_automaton3 = new Automaton();

				var initialState = new State("Initial", _automaton3);
				var q1State = new State("q1", _automaton3);
				var q2State = new State("q2", _automaton3);
				var q3State = new State("q3", _automaton3);
				var q4State = new State("q4", _automaton3);
				var q5State = new State("q5", _automaton3);
				var q6State = new State("q6", _automaton3);

				initialState.SetTransition(" \t", initialState);
				initialState.SetTransition("-+0123456789", q1State);
				initialState.SetTransition(".", q2State);

				q1State.SetTransition("0123456789", q1State);
				q1State.SetTransition(".", q2State);

				q2State.SetTransition("0123456789", q3State);

				q3State.SetTransition("0123456789", q3State);
				q3State.SetTransition("eE", q4State);
				q3State.Terminal = true;

				q4State.SetTransition("0123456789", q6State);
				q4State.SetTransition("-+", q5State);

				q5State.SetTransition("0123456789", q6State);

				q6State.SetTransition("0123456789", q6State);
				q6State.Terminal = true;

				_automaton3.InitialState = initialState;
				_automaton3.AddState(q1State);
				_automaton3.AddState(q2State);
				_automaton3.AddState(q3State);
				_automaton3.AddState(q4State);
				_automaton3.AddState(q5State);
				_automaton3.AddState(q6State);
			}
		}

		static bool CheckAutomaton(Automaton automaton, string input)
		{
			automaton.ResetState();
			foreach (var symbol in input)
			{
				automaton.Transit(symbol);
				if (automaton.IsFailed)
					return false;
			}
			return automaton.IsSuccess;
		}

		#endregion

	}
}
