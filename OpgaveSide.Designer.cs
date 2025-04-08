namespace Eksamensprojekt
{
	partial class OpgaveSide
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
            OpgaveBillede = new PictureBox();
            OpgaveTekst = new Label();
            SvarknapA = new Button();
            SvarknapB = new Button();
            SvarknapC = new Button();
            SvarknapD = new Button();
            MenuKnap = new Button();
            NæsteOpgaveKnap = new Button();
            ForrigeOpgaveKnap = new Button();
            SvarFelt = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)OpgaveBillede).BeginInit();
            SuspendLayout();
            // 
            // OpgaveBillede
            // 
            OpgaveBillede.Location = new Point(12, 11);
            OpgaveBillede.Margin = new Padding(3, 2, 3, 2);
            OpgaveBillede.Name = "OpgaveBillede";
            OpgaveBillede.Size = new Size(676, 163);
            OpgaveBillede.TabIndex = 0;
            OpgaveBillede.TabStop = false;
            // 
            // OpgaveTekst
            // 
            OpgaveTekst.Location = new Point(12, 183);
            OpgaveTekst.Name = "OpgaveTekst";
            OpgaveTekst.Size = new Size(329, 101);
            OpgaveTekst.TabIndex = 1;
            OpgaveTekst.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud e";
            // 
            // SvarknapA
            // 
            SvarknapA.Location = new Point(352, 183);
            SvarknapA.Margin = new Padding(3, 2, 3, 2);
            SvarknapA.Name = "SvarknapA";
            SvarknapA.Size = new Size(165, 70);
            SvarknapA.TabIndex = 2;
            SvarknapA.Text = "A";
            SvarknapA.UseVisualStyleBackColor = true;
            // 
            // SvarknapB
            // 
            SvarknapB.Location = new Point(352, 257);
            SvarknapB.Margin = new Padding(3, 2, 3, 2);
            SvarknapB.Name = "SvarknapB";
            SvarknapB.Size = new Size(165, 70);
            SvarknapB.TabIndex = 3;
            SvarknapB.Text = "B";
            SvarknapB.UseVisualStyleBackColor = true;
            // 
            // SvarknapC
            // 
            SvarknapC.Location = new Point(523, 183);
            SvarknapC.Margin = new Padding(3, 2, 3, 2);
            SvarknapC.Name = "SvarknapC";
            SvarknapC.Size = new Size(165, 70);
            SvarknapC.TabIndex = 4;
            SvarknapC.Text = "C";
            SvarknapC.UseVisualStyleBackColor = true;
            // 
            // SvarknapD
            // 
            SvarknapD.Location = new Point(523, 257);
            SvarknapD.Margin = new Padding(3, 2, 3, 2);
            SvarknapD.Name = "SvarknapD";
            SvarknapD.Size = new Size(165, 70);
            SvarknapD.TabIndex = 5;
            SvarknapD.Text = "D";
            SvarknapD.UseVisualStyleBackColor = true;
            // 
            // MenuKnap
            // 
            MenuKnap.Location = new Point(144, 303);
            MenuKnap.Margin = new Padding(3, 2, 3, 2);
            MenuKnap.Name = "MenuKnap";
            MenuKnap.Size = new Size(66, 24);
            MenuKnap.TabIndex = 6;
            MenuKnap.Text = "Menu";
            MenuKnap.UseVisualStyleBackColor = true;
            MenuKnap.Click += MenuKnap_Click;
            // 
            // NæsteOpgaveKnap
            // 
            NæsteOpgaveKnap.Location = new Point(275, 303);
            NæsteOpgaveKnap.Margin = new Padding(3, 2, 3, 2);
            NæsteOpgaveKnap.Name = "NæsteOpgaveKnap";
            NæsteOpgaveKnap.Size = new Size(66, 24);
            NæsteOpgaveKnap.TabIndex = 7;
            NæsteOpgaveKnap.Text = "Næste";
            NæsteOpgaveKnap.UseVisualStyleBackColor = true;
            // 
            // ForrigeOpgaveKnap
            // 
            ForrigeOpgaveKnap.Location = new Point(12, 303);
            ForrigeOpgaveKnap.Margin = new Padding(3, 2, 3, 2);
            ForrigeOpgaveKnap.Name = "ForrigeOpgaveKnap";
            ForrigeOpgaveKnap.Size = new Size(66, 24);
            ForrigeOpgaveKnap.TabIndex = 8;
            ForrigeOpgaveKnap.Text = "Forrige";
            ForrigeOpgaveKnap.UseVisualStyleBackColor = true;
            // 
            // SvarFelt
            // 
            SvarFelt.Cursor = Cursors.SizeNS;
            SvarFelt.Location = new Point(347, 183);
            SvarFelt.Margin = new Padding(3, 2, 3, 2);
            SvarFelt.Name = "SvarFelt";
            SvarFelt.Size = new Size(341, 144);
            SvarFelt.TabIndex = 6;
            SvarFelt.Text = "";
            // 
            // OpgaveSide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(SvarknapA);
            Controls.Add(ForrigeOpgaveKnap);
            Controls.Add(NæsteOpgaveKnap);
            Controls.Add(MenuKnap);
            Controls.Add(SvarknapD);
            Controls.Add(SvarknapC);
            Controls.Add(SvarknapB);
            Controls.Add(OpgaveTekst);
            Controls.Add(OpgaveBillede);
            Controls.Add(SvarFelt);
            Name = "OpgaveSide";
            Text = "OpgaveSide";
            Load += OpgaveSide_Load;
            ((System.ComponentModel.ISupportInitialize)OpgaveBillede).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox OpgaveBillede;
		private Label OpgaveTekst;
		private Button SvarknapA;
		private Button SvarknapB;
		private Button SvarknapC;
		private Button SvarknapD;
		private Button MenuKnap;
		private Button NæsteOpgaveKnap;
		private Button ForrigeOpgaveKnap;
		private RichTextBox SvarFelt;
	}
}