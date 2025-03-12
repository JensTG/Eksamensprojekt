namespace Eksamensprojekt
{
    partial class Loginside
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Brugernavn = new Label();
            Adgangskode = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(362, 396);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(170, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 236);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(347, 302);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(347, 346);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // Brugernavn
            // 
            Brugernavn.AutoSize = true;
            Brugernavn.Location = new Point(240, 305);
            Brugernavn.Name = "Brugernavn";
            Brugernavn.Size = new Size(87, 20);
            Brugernavn.TabIndex = 4;
            Brugernavn.Text = "Brugernavn:";
            Brugernavn.Click += Brugernavn_Click;
            // 
            // Adgangskode
            // 
            Adgangskode.AutoSize = true;
            Adgangskode.Location = new Point(240, 349);
            Adgangskode.Name = "Adgangskode";
            Adgangskode.Size = new Size(104, 20);
            Adgangskode.TabIndex = 5;
            Adgangskode.Text = "Adgangskode:";
            // 
            // Loginside
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Adgangskode);
            Controls.Add(Brugernavn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Loginside";
            Text = "Form1";
            Load += this.Loginside_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Brugernavn;
        private Label Adgangskode;
    }
}
