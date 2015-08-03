namespace NumberRecnogition
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.buttonCheck = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxAutomaton3 = new System.Windows.Forms.CheckBox();
			this.checkBoxReGex3 = new System.Windows.Forms.CheckBox();
			this.checkBoxAutomaton2 = new System.Windows.Forms.CheckBox();
			this.checkBoxReGex2 = new System.Windows.Forms.CheckBox();
			this.labelPattern3 = new System.Windows.Forms.Label();
			this.checkBoxAutomaton1 = new System.Windows.Forms.CheckBox();
			this.labelPattern2 = new System.Windows.Forms.Label();
			this.checkBoxReGex1 = new System.Windows.Forms.CheckBox();
			this.labelPattern1 = new System.Windows.Forms.Label();
			this.buttonReset = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input";
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(118, 12);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(418, 26);
			this.textBoxInput.TabIndex = 0;
			this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
			// 
			// buttonCheck
			// 
			this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCheck.Location = new System.Drawing.Point(12, 195);
			this.buttonCheck.Name = "buttonCheck";
			this.buttonCheck.Size = new System.Drawing.Size(96, 42);
			this.buttonCheck.TabIndex = 2;
			this.buttonCheck.Text = "Check";
			this.buttonCheck.UseVisualStyleBackColor = true;
			this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxAutomaton3);
			this.groupBox1.Controls.Add(this.checkBoxReGex3);
			this.groupBox1.Controls.Add(this.checkBoxAutomaton2);
			this.groupBox1.Controls.Add(this.checkBoxReGex2);
			this.groupBox1.Controls.Add(this.labelPattern3);
			this.groupBox1.Controls.Add(this.checkBoxAutomaton1);
			this.groupBox1.Controls.Add(this.labelPattern2);
			this.groupBox1.Controls.Add(this.checkBoxReGex1);
			this.groupBox1.Controls.Add(this.labelPattern1);
			this.groupBox1.Location = new System.Drawing.Point(12, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(524, 148);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Results";
			// 
			// checkBoxAutomaton3
			// 
			this.checkBoxAutomaton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxAutomaton3.AutoSize = true;
			this.checkBoxAutomaton3.Checked = true;
			this.checkBoxAutomaton3.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.checkBoxAutomaton3.Enabled = false;
			this.checkBoxAutomaton3.Location = new System.Drawing.Point(401, 85);
			this.checkBoxAutomaton3.Name = "checkBoxAutomaton3";
			this.checkBoxAutomaton3.Size = new System.Drawing.Size(114, 24);
			this.checkBoxAutomaton3.TabIndex = 1;
			this.checkBoxAutomaton3.Text = "Automaton";
			this.checkBoxAutomaton3.UseVisualStyleBackColor = true;
			// 
			// checkBoxReGex3
			// 
			this.checkBoxReGex3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxReGex3.AutoSize = true;
			this.checkBoxReGex3.Checked = true;
			this.checkBoxReGex3.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.checkBoxReGex3.Enabled = false;
			this.checkBoxReGex3.Location = new System.Drawing.Point(310, 85);
			this.checkBoxReGex3.Name = "checkBoxReGex3";
			this.checkBoxReGex3.Size = new System.Drawing.Size(85, 24);
			this.checkBoxReGex3.TabIndex = 1;
			this.checkBoxReGex3.Text = "ReGex";
			this.checkBoxReGex3.UseVisualStyleBackColor = true;
			// 
			// checkBoxAutomaton2
			// 
			this.checkBoxAutomaton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxAutomaton2.AutoSize = true;
			this.checkBoxAutomaton2.Checked = true;
			this.checkBoxAutomaton2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.checkBoxAutomaton2.Enabled = false;
			this.checkBoxAutomaton2.Location = new System.Drawing.Point(401, 55);
			this.checkBoxAutomaton2.Name = "checkBoxAutomaton2";
			this.checkBoxAutomaton2.Size = new System.Drawing.Size(114, 24);
			this.checkBoxAutomaton2.TabIndex = 1;
			this.checkBoxAutomaton2.Text = "Automaton";
			this.checkBoxAutomaton2.UseVisualStyleBackColor = true;
			// 
			// checkBoxReGex2
			// 
			this.checkBoxReGex2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxReGex2.AutoSize = true;
			this.checkBoxReGex2.Checked = true;
			this.checkBoxReGex2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.checkBoxReGex2.Enabled = false;
			this.checkBoxReGex2.Location = new System.Drawing.Point(310, 55);
			this.checkBoxReGex2.Name = "checkBoxReGex2";
			this.checkBoxReGex2.Size = new System.Drawing.Size(85, 24);
			this.checkBoxReGex2.TabIndex = 1;
			this.checkBoxReGex2.Text = "ReGex";
			this.checkBoxReGex2.UseVisualStyleBackColor = true;
			// 
			// labelPattern3
			// 
			this.labelPattern3.Location = new System.Drawing.Point(7, 86);
			this.labelPattern3.Name = "labelPattern3";
			this.labelPattern3.Size = new System.Drawing.Size(307, 49);
			this.labelPattern3.TabIndex = 0;
			this.labelPattern3.Text = "Pattern ^(\\s*)[-+]?\\d*\\.\\d+([eE][+-]?\\d+)?$";
			// 
			// checkBoxAutomaton1
			// 
			this.checkBoxAutomaton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxAutomaton1.AutoSize = true;
			this.checkBoxAutomaton1.Checked = true;
			this.checkBoxAutomaton1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.checkBoxAutomaton1.Enabled = false;
			this.checkBoxAutomaton1.Location = new System.Drawing.Point(401, 25);
			this.checkBoxAutomaton1.Name = "checkBoxAutomaton1";
			this.checkBoxAutomaton1.Size = new System.Drawing.Size(114, 24);
			this.checkBoxAutomaton1.TabIndex = 1;
			this.checkBoxAutomaton1.Text = "Automaton";
			this.checkBoxAutomaton1.UseVisualStyleBackColor = true;
			// 
			// labelPattern2
			// 
			this.labelPattern2.Location = new System.Drawing.Point(7, 56);
			this.labelPattern2.Name = "labelPattern2";
			this.labelPattern2.Size = new System.Drawing.Size(252, 23);
			this.labelPattern2.TabIndex = 0;
			this.labelPattern2.Text = "Pattern ^\\d*\\.\\d+$";
			// 
			// checkBoxReGex1
			// 
			this.checkBoxReGex1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxReGex1.AutoSize = true;
			this.checkBoxReGex1.Checked = true;
			this.checkBoxReGex1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.checkBoxReGex1.Enabled = false;
			this.checkBoxReGex1.Location = new System.Drawing.Point(310, 25);
			this.checkBoxReGex1.Name = "checkBoxReGex1";
			this.checkBoxReGex1.Size = new System.Drawing.Size(85, 24);
			this.checkBoxReGex1.TabIndex = 1;
			this.checkBoxReGex1.Text = "ReGex";
			this.checkBoxReGex1.UseVisualStyleBackColor = true;
			// 
			// labelPattern1
			// 
			this.labelPattern1.Location = new System.Drawing.Point(7, 26);
			this.labelPattern1.Name = "labelPattern1";
			this.labelPattern1.Size = new System.Drawing.Size(252, 23);
			this.labelPattern1.TabIndex = 0;
			this.labelPattern1.Text = "Pattern ^\\d+$";
			// 
			// buttonReset
			// 
			this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonReset.Location = new System.Drawing.Point(440, 195);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(96, 42);
			this.buttonReset.TabIndex = 3;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonCheck;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonReset;
			this.ClientSize = new System.Drawing.Size(548, 249);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.buttonCheck);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Number recognition";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Button buttonCheck;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBoxAutomaton3;
		private System.Windows.Forms.CheckBox checkBoxReGex3;
		private System.Windows.Forms.CheckBox checkBoxAutomaton2;
		private System.Windows.Forms.CheckBox checkBoxReGex2;
		private System.Windows.Forms.Label labelPattern3;
		private System.Windows.Forms.CheckBox checkBoxAutomaton1;
		private System.Windows.Forms.Label labelPattern2;
		private System.Windows.Forms.CheckBox checkBoxReGex1;
		private System.Windows.Forms.Label labelPattern1;
		private System.Windows.Forms.Button buttonReset;
	}
}

