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
            pictureBox1 = new PictureBox();
            OpgaveTekst = new Label();
            Svarknap1 = new Button();
            Svarknap2 = new Button();
            Svarknap3 = new Button();
            Svarknap4 = new Button();
            SvarBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 37);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(856, 276);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // OpgaveTekst
            // 
            OpgaveTekst.Location = new Point(30, 317);
            OpgaveTekst.Name = "OpgaveTekst";
            OpgaveTekst.Size = new Size(856, 99);
            OpgaveTekst.TabIndex = 1;
            OpgaveTekst.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud e";
            // 
            // Svarknap1
            // 
            Svarknap1.Location = new Point(162, 420);
            Svarknap1.Margin = new Padding(3, 4, 3, 4);
            Svarknap1.Name = "Svarknap1";
            Svarknap1.Size = new Size(216, 55);
            Svarknap1.TabIndex = 2;
            Svarknap1.Text = "A";
            Svarknap1.UseVisualStyleBackColor = true;
            // 
            // Svarknap2
            // 
            Svarknap2.Location = new Point(534, 420);
            Svarknap2.Margin = new Padding(3, 4, 3, 4);
            Svarknap2.Name = "Svarknap2";
            Svarknap2.Size = new Size(216, 55);
            Svarknap2.TabIndex = 3;
            Svarknap2.Text = "B";
            Svarknap2.UseVisualStyleBackColor = true;
            // 
            // Svarknap3
            // 
            Svarknap3.Location = new Point(162, 509);
            Svarknap3.Margin = new Padding(3, 4, 3, 4);
            Svarknap3.Name = "Svarknap3";
            Svarknap3.Size = new Size(216, 55);
            Svarknap3.TabIndex = 4;
            Svarknap3.Text = "C";
            Svarknap3.UseVisualStyleBackColor = true;
            // 
            // Svarknap4
            // 
            Svarknap4.Location = new Point(534, 509);
            Svarknap4.Margin = new Padding(3, 4, 3, 4);
            Svarknap4.Name = "Svarknap4";
            Svarknap4.Size = new Size(216, 55);
            Svarknap4.TabIndex = 5;
            Svarknap4.Text = "D";
            Svarknap4.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(914, 600);
            Controls.Add(SvarBox);
            Controls.Add(Svarknap4);
            Controls.Add(Svarknap3);
            Controls.Add(Svarknap2);
            Controls.Add(Svarknap1);
            Controls.Add(OpgaveTekst);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OpgaveSide";
            Text = "OpgaveSide";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label OpgaveTekst;
        private Button Svarknap1;
        private Button Svarknap2;
        private Button Svarknap3;
        private Button Svarknap4;
        private RichTextBox SvarBox;
    }
}