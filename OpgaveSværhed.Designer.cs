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
            TilbageKnap = new Button();
            LetKnap = new Button();
            MellemKnap = new Button();
            SværKnap = new Button();
            label1 = new Label();
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
            // TilbageKnap
            // 
            TilbageKnap.Location = new Point(12, 303);
            TilbageKnap.Name = "TilbageKnap";
            TilbageKnap.Size = new Size(75, 23);
            TilbageKnap.TabIndex = 9;
            // 
            // LetKnap
            // 
            LetKnap.Location = new Point(437, 197);
            LetKnap.Name = "LetKnap";
            LetKnap.Size = new Size(75, 23);
            LetKnap.TabIndex = 8;
            // 
            // MellemKnap
            // 
            MellemKnap.Location = new Point(518, 197);
            MellemKnap.Name = "MellemKnap";
            MellemKnap.Size = new Size(75, 23);
            MellemKnap.TabIndex = 7;
            // 
            // SværKnap
            // 
            SværKnap.Location = new Point(599, 197);
            SværKnap.Name = "SværKnap";
            SværKnap.Size = new Size(75, 23);
            SværKnap.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new Point(390, 44);
            label1.Name = "label1";
            label1.Size = new Size(284, 150);
            label1.TabIndex = 5;
            label1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud e";
            label1.Click += label1_Click;
            // 
            // OpgaveSværhed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(SværKnap);
            Controls.Add(MellemKnap);
            Controls.Add(LetKnap);
            Controls.Add(TilbageKnap);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OpgaveSværhed";
            Text = "OpgaveSværhed";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button TilbageKnap;
        private Button LetKnap;
        private Button MellemKnap;
        private Button SværKnap;
        private Label label1;
    }
}