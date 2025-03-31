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
            LogIndKnap = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Brugernavn = new Label();
            Adgangskode = new Label();
            OpretBrugerKnap = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogIndKnap
            // 
            LogIndKnap.Location = new Point(304, 275);
            LogIndKnap.Margin = new Padding(3, 2, 3, 2);
            LogIndKnap.Name = "LogIndKnap";
            LogIndKnap.Size = new Size(109, 22);
            LogIndKnap.TabIndex = 0;
            LogIndKnap.Text = "Log in";
            LogIndKnap.UseVisualStyleBackColor = true;
            LogIndKnap.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(149, 26);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 177);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 212);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 245);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 3;
            // 
            // Brugernavn
            // 
            Brugernavn.AutoSize = true;
            Brugernavn.Location = new Point(210, 214);
            Brugernavn.Name = "Brugernavn";
            Brugernavn.Size = new Size(71, 15);
            Brugernavn.TabIndex = 4;
            Brugernavn.Text = "Brugernavn:";
            Brugernavn.Click += Brugernavn_Click;
            // 
            // Adgangskode
            // 
            Adgangskode.AutoSize = true;
            Adgangskode.Location = new Point(210, 248);
            Adgangskode.Name = "Adgangskode";
            Adgangskode.Size = new Size(83, 15);
            Adgangskode.TabIndex = 5;
            Adgangskode.Text = "Adgangskode:";
            // 
            // OpretBrugerKnap
            // 
            OpretBrugerKnap.Location = new Point(304, 302);
            OpretBrugerKnap.Margin = new Padding(3, 2, 3, 2);
            OpretBrugerKnap.Name = "OpretBrugerKnap";
            OpretBrugerKnap.Size = new Size(109, 22);
            OpretBrugerKnap.TabIndex = 6;
            OpretBrugerKnap.Text = "Opret bruger";
            OpretBrugerKnap.UseVisualStyleBackColor = true;
            OpretBrugerKnap.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(294, 108);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 7;
            button1.Text = "Indlæs programdata";
            button1.UseVisualStyleBackColor = true;
            button1.Click += IndlæsDataKnap;
            // 
            // Loginside
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(OpretBrugerKnap);
            Controls.Add(Adgangskode);
            Controls.Add(Brugernavn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(LogIndKnap);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Loginside";
            Text = "Form1";
            Load += Loginside_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogIndKnap;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Brugernavn;
        private Label Adgangskode;
        private Button OpretBrugerKnap;
        private Button button1;
    }
}
