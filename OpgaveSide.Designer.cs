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
            OpgaveBilled = new PictureBox();
            OpgaveTekst = new Label();
            SvarknapA = new Button();
            SvarknapB = new Button();
            SvarknapC = new Button();
            SvarknapD = new Button();
            button1 = new Button();
            NæsteOpgaveKnap = new Button();
            ForigeOpgaveKnap = new Button();
            ((System.ComponentModel.ISupportInitialize)OpgaveBilled).BeginInit();
            SuspendLayout();
            // 
            // OpgaveBilled
            // 
            OpgaveBilled.Location = new Point(26, 28);
            OpgaveBilled.Name = "OpgaveBilled";
            OpgaveBilled.Size = new Size(749, 207);
            OpgaveBilled.TabIndex = 0;
            OpgaveBilled.TabStop = false;
            // 
            // OpgaveTekst
            // 
            OpgaveTekst.Location = new Point(30, 317);
            OpgaveTekst.Name = "OpgaveTekst";
            OpgaveTekst.Size = new Size(856, 99);
            OpgaveTekst.TabIndex = 1;
            OpgaveTekst.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud e";
            // 
            // SvarknapA
            // 
            SvarknapA.Location = new Point(142, 315);
            SvarknapA.Name = "SvarknapA";
            SvarknapA.Size = new Size(189, 41);
            SvarknapA.TabIndex = 2;
            SvarknapA.Text = "A";
            SvarknapA.UseVisualStyleBackColor = true;
            // 
            // SvarknapB
            // 
            SvarknapB.Location = new Point(467, 315);
            SvarknapB.Name = "SvarknapB";
            SvarknapB.Size = new Size(189, 41);
            SvarknapB.TabIndex = 3;
            SvarknapB.Text = "B";
            SvarknapB.UseVisualStyleBackColor = true;
            // 
            // SvarknapC
            // 
            SvarknapC.Location = new Point(142, 382);
            SvarknapC.Name = "SvarknapC";
            SvarknapC.Size = new Size(189, 41);
            SvarknapC.TabIndex = 4;
            SvarknapC.Text = "C";
            SvarknapC.UseVisualStyleBackColor = true;
            // 
            // SvarknapD
            // 
            SvarknapD.Location = new Point(467, 382);
            SvarknapD.Name = "SvarknapD";
            SvarknapD.Size = new Size(189, 41);
            SvarknapD.TabIndex = 5;
            SvarknapD.Text = "D";
            SvarknapD.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(26, 324);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Tilbage";
            button1.UseVisualStyleBackColor = true;
            // 
            // NæsteOpgaveKnap
            // 
            NæsteOpgaveKnap.Location = new Point(687, 324);
            NæsteOpgaveKnap.Name = "NæsteOpgaveKnap";
            NæsteOpgaveKnap.Size = new Size(75, 23);
            NæsteOpgaveKnap.TabIndex = 7;
            NæsteOpgaveKnap.Text = "Næste Opgave";
            NæsteOpgaveKnap.UseVisualStyleBackColor = true;
            // 
            // ForigeOpgaveKnap
            // 
            ForigeOpgaveKnap.Location = new Point(26, 391);
            ForigeOpgaveKnap.Name = "ForigeOpgaveKnap";
            ForigeOpgaveKnap.Size = new Size(75, 23);
            ForigeOpgaveKnap.TabIndex = 8;
            ForigeOpgaveKnap.Text = "Forige Opgave";
            ForigeOpgaveKnap.UseVisualStyleBackColor = true;
            // 
            // SvarBox
            // 
            SvarBox.Cursor = Cursors.SizeNS;
            SvarBox.Location = new Point(70, 373);
            SvarBox.Name = "SvarBox";
            SvarBox.Size = new Size(792, 191);
            SvarBox.TabIndex = 6;
            SvarBox.Text = "";
            SvarBox.TextChanged += SvarBox_TextChanged;
            // 
            // OpgaveSide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ForigeOpgaveKnap);
            Controls.Add(NæsteOpgaveKnap);
            Controls.Add(button1);
            Controls.Add(SvarknapD);
            Controls.Add(SvarknapC);
            Controls.Add(SvarknapB);
            Controls.Add(SvarknapA);
            Controls.Add(OpgaveTekst);
            Controls.Add(OpgaveBilled);
            Name = "OpgaveSide";
            Text = "OpgaveSide";
            ((System.ComponentModel.ISupportInitialize)OpgaveBilled).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox OpgaveBilled;
        private Label OpgaveTekst;
        private Button SvarknapA;
        private Button SvarknapB;
        private Button SvarknapC;
        private Button SvarknapD;
        private Button button1;
        private Button NæsteOpgaveKnap;
        private Button ForigeOpgaveKnap;
        private RichTextBox SvarBox;
    }
}