namespace Eksamensprojekt
{
    partial class OpgaveEditor
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
            MulighedA = new Label();
            MulighedB = new Label();
            MulighedC = new Label();
            MulighedD = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            Beskrivelse = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MulighedA
            // 
            MulighedA.AutoSize = true;
            MulighedA.Location = new Point(186, 338);
            MulighedA.Name = "MulighedA";
            MulighedA.Size = new Size(22, 20);
            MulighedA.TabIndex = 0;
            MulighedA.Text = "A:";
            // 
            // MulighedB
            // 
            MulighedB.AutoSize = true;
            MulighedB.Location = new Point(187, 372);
            MulighedB.Name = "MulighedB";
            MulighedB.Size = new Size(21, 20);
            MulighedB.TabIndex = 1;
            MulighedB.Text = "B:";
            // 
            // MulighedC
            // 
            MulighedC.AutoSize = true;
            MulighedC.Location = new Point(387, 336);
            MulighedC.Name = "MulighedC";
            MulighedC.Size = new Size(21, 20);
            MulighedC.TabIndex = 2;
            MulighedC.Text = "C:";
            // 
            // MulighedD
            // 
            MulighedD.AutoSize = true;
            MulighedD.Location = new Point(387, 369);
            MulighedD.Name = "MulighedD";
            MulighedD.Size = new Size(23, 20);
            MulighedD.TabIndex = 3;
            MulighedD.Text = "D:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 336);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 369);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(416, 338);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(416, 369);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(214, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 139);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(311, 241);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += this.textBox5_TextChanged;
            // 
            // Beskrivelse
            // 
            Beskrivelse.AutoSize = true;
            Beskrivelse.Location = new Point(221, 244);
            Beskrivelse.Name = "Beskrivelse";
            Beskrivelse.Size = new Size(84, 20);
            Beskrivelse.TabIndex = 10;
            Beskrivelse.Text = "Beskrivelse:";
            // 
            // OpgaveEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Beskrivelse);
            Controls.Add(textBox5);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(MulighedD);
            Controls.Add(MulighedC);
            Controls.Add(MulighedB);
            Controls.Add(MulighedA);
            Name = "OpgaveEditor";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MulighedA;
        private Label MulighedB;
        private Label MulighedC;
        private Label MulighedD;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Label Beskrivelse;
    }
}