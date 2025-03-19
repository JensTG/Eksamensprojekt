namespace Eksamensprojekt
{
    partial class LærerSide
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
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            beskrivelselabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(52, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(328, 304);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 32);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 1;
            label1.Text = "Eksisterende opgaver";
            label1.Click += this.label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(52, 382);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 2;
            button1.Text = "Ændre opgaver";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(232, 382);
            button2.Name = "button2";
            button2.Size = new Size(148, 29);
            button2.TabIndex = 3;
            button2.Text = "Vis besvarelser";
            button2.UseVisualStyleBackColor = true;
            // 
            // beskrivelselabel
            // 
            beskrivelselabel.Location = new Point(421, 243);
            beskrivelselabel.Name = "beskrivelselabel";
            beskrivelselabel.Size = new Size(331, 116);
            beskrivelselabel.TabIndex = 4;
            beskrivelselabel.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud e";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(421, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 168);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LærerSide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(beskrivelselabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "LærerSide";
            Text = "Form1";
            Load += this.LærerSide_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label beskrivelselabel;
        private PictureBox pictureBox1;
    }
}