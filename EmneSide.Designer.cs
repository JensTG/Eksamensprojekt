namespace Eksamensprojekt
{
    partial class VælgEmne
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
            pictureBox1 = new PictureBox();
            beskrivelselabel = new Label();
            VidereKnap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(11, 14);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(343, 424);
            listBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(376, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 241);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // beskrivelselabel
            // 
            beskrivelselabel.Location = new Point(376, 262);
            beskrivelselabel.Name = "beskrivelselabel";
            beskrivelselabel.Size = new Size(401, 124);
            beskrivelselabel.TabIndex = 2;
            beskrivelselabel.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud e";
            // 
            // VidereKnap
            // 
            VidereKnap.Location = new Point(376, 415);
            VidereKnap.Name = "VidereKnap";
            VidereKnap.Size = new Size(75, 23);
            VidereKnap.TabIndex = 3;
            VidereKnap.Text = "Videre";
            VidereKnap.UseVisualStyleBackColor = true;
            VidereKnap.Click += button1_Click;
            // 
            // VælgEmne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VidereKnap);
            Controls.Add(beskrivelselabel);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Name = "VælgEmne";
            Text = "Vælg Emne/Opgave";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Label beskrivelselabel;
        private Button VidereKnap;
    }
}