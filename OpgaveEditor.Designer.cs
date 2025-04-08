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
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MulighedA
            // 
            MulighedA.AutoSize = true;
            MulighedA.Location = new Point(163, 253);
            MulighedA.Name = "MulighedA";
            MulighedA.Size = new Size(18, 15);
            MulighedA.TabIndex = 0;
            MulighedA.Text = "A:";
            // 
            // MulighedB
            // 
            MulighedB.AutoSize = true;
            MulighedB.Location = new Point(164, 280);
            MulighedB.Name = "MulighedB";
            MulighedB.Size = new Size(17, 15);
            MulighedB.TabIndex = 1;
            MulighedB.Text = "B:";
            // 
            // MulighedC
            // 
            MulighedC.AutoSize = true;
            MulighedC.Location = new Point(339, 253);
            MulighedC.Name = "MulighedC";
            MulighedC.Size = new Size(18, 15);
            MulighedC.TabIndex = 2;
            MulighedC.Text = "C:";
            // 
            // MulighedD
            // 
            MulighedD.AutoSize = true;
            MulighedD.Location = new Point(339, 280);
            MulighedD.Name = "MulighedD";
            MulighedD.Size = new Size(18, 15);
            MulighedD.TabIndex = 3;
            MulighedD.Text = "D:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 250);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 277);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(363, 250);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(363, 277);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(187, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 139);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(272, 181);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 9;
            // 
            // Beskrivelse
            // 
            Beskrivelse.AutoSize = true;
            Beskrivelse.Location = new Point(193, 183);
            Beskrivelse.Name = "Beskrivelse";
            Beskrivelse.Size = new Size(67, 15);
            Beskrivelse.TabIndex = 10;
            Beskrivelse.Text = "Beskrivelse:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(546, 252);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Åbent svar";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // OpgaveEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(checkBox1);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private CheckBox checkBox1;
    }
}