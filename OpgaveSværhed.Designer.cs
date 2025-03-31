namespace Eksamensprojekt
{
    partial class OpgaveSværhed
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
            pictureBox1 = new PictureBox();
            ForrigeOpgaveKnap = new Button();
            LetKnap = new Button();
            MellemKnap = new Button();
            SværKnap = new Button();
            label1 = new Label();
            NæsteOpgaveKnap = new Button();
            MenuKnap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 44);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 176);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ForrigeOpgaveKnap
            // 
            ForrigeOpgaveKnap.Location = new Point(12, 303);
            ForrigeOpgaveKnap.Name = "ForrigeOpgaveKnap";
            ForrigeOpgaveKnap.Size = new Size(75, 23);
            ForrigeOpgaveKnap.TabIndex = 9;
            ForrigeOpgaveKnap.Text = "Forrige";
            ForrigeOpgaveKnap.Click += ForrigeOpgaveKnap_Click;
            // 
            // LetKnap
            // 
            LetKnap.Location = new Point(437, 197);
            LetKnap.Name = "LetKnap";
            LetKnap.Size = new Size(75, 23);
            LetKnap.TabIndex = 8;
            LetKnap.Text = "Let";
            LetKnap.Click += Let_Click;
            // 
            // MellemKnap
            // 
            MellemKnap.Location = new Point(518, 197);
            MellemKnap.Name = "MellemKnap";
            MellemKnap.Size = new Size(75, 23);
            MellemKnap.TabIndex = 7;
            MellemKnap.Text = "Mellem";
            MellemKnap.Click += Mellem_Click;
            // 
            // SværKnap
            // 
            SværKnap.Location = new Point(599, 197);
            SværKnap.Name = "SværKnap";
            SværKnap.Size = new Size(75, 23);
            SværKnap.TabIndex = 6;
            SværKnap.Text = "Svær";
            SværKnap.Click += Svær_Click;
            // 
            // label1
            // 
            label1.Location = new Point(390, 44);
            label1.Name = "label1";
            label1.Size = new Size(284, 150);
            label1.TabIndex = 5;
            label1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud e";
            // 
            // NæsteOpgaveKnap
            // 
            NæsteOpgaveKnap.Location = new Point(613, 303);
            NæsteOpgaveKnap.Name = "NæsteOpgaveKnap";
            NæsteOpgaveKnap.Size = new Size(75, 23);
            NæsteOpgaveKnap.TabIndex = 10;
            NæsteOpgaveKnap.Text = "Næste";
            NæsteOpgaveKnap.Click += NæsteOpgaveKnap_Click;
            // 
            // MenuKnap
            // 
            MenuKnap.Location = new Point(321, 303);
            MenuKnap.Name = "MenuKnap";
            MenuKnap.Size = new Size(75, 23);
            MenuKnap.TabIndex = 11;
            MenuKnap.Text = "Menu";
            MenuKnap.Click += MenuKnap_Click;
            // 
            // OpgaveSværhed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(MenuKnap);
            Controls.Add(NæsteOpgaveKnap);
            Controls.Add(label1);
            Controls.Add(SværKnap);
            Controls.Add(MellemKnap);
            Controls.Add(LetKnap);
            Controls.Add(ForrigeOpgaveKnap);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OpgaveSværhed";
            Text = "OpgaveSværhed";
            Load += OpgaveSværhed_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button ForrigeOpgaveKnap;
        private Button LetKnap;
        private Button MellemKnap;
        private Button SværKnap;
        private Label label1;
        private Button NæsteOpgaveKnap;
        private Button MenuKnap;
    }
}