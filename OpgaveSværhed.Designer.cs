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
            Tilbage.Location = new Point(41, 376);
            Tilbage.Name = "Tilbage";
            Tilbage.Size = new Size(94, 29);
            Tilbage.TabIndex = 1;
            Tilbage.Text = "Tilbage";
            Tilbage.UseVisualStyleBackColor = true;
            Tilbage.Click += Tilbage_Click;
            // 
            // LetKnap
            // 
            Let.Location = new Point(409, 376);
            Let.Name = "Let";
            Let.Size = new Size(94, 29);
            Let.TabIndex = 2;
            Let.Text = "Let";
            Let.UseVisualStyleBackColor = true;
            Let.Click += Let_Click;
            // 
            // MellemKnap
            // 
            Mellem.Location = new Point(523, 376);
            Mellem.Name = "Mellem";
            Mellem.Size = new Size(94, 29);
            Mellem.TabIndex = 3;
            Mellem.Text = "Mellem";
            Mellem.UseVisualStyleBackColor = true;
            Mellem.Click += Mellem_Click;
            // 
            // SværKnap
            // 
            Svær.Location = new Point(637, 376);
            Svær.Name = "Svær";
            Svær.Size = new Size(94, 29);
            Svær.TabIndex = 4;
            Svær.Text = "Svær";
            Svær.UseVisualStyleBackColor = true;
            Svær.Click += Svær_Click;
            // 
            // label1
            // 
            label1.Location = new Point(390, 70);
            label1.Name = "label1";
            label1.Size = new Size(284, 140);
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