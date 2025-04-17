namespace Eksamensprojekt
{
    partial class VisElevBesvarelser
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
            listBox2 = new ListBox();
            VisSvar = new Button();
            label1 = new Label();
            VælgElev = new Label();
            VælgOpgave = new Label();
            ny_knap = new Button();
            slet_knap = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(36, 32);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 259);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(275, 32);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(219, 259);
            listBox2.TabIndex = 1;
            // 
            // VisSvar
            // 
            VisSvar.Location = new Point(520, 268);
            VisSvar.Margin = new Padding(3, 2, 3, 2);
            VisSvar.Name = "VisSvar";
            VisSvar.Size = new Size(82, 22);
            VisSvar.TabIndex = 2;
            VisSvar.Text = "Vis svar";
            VisSvar.UseVisualStyleBackColor = true;
            VisSvar.Click += VisSvar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(520, 32);
            label1.Name = "label1";
            label1.Size = new Size(168, 234);
            label1.TabIndex = 6;
            label1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud e";
            // 
            // VælgElev
            // 
            VælgElev.AutoSize = true;
            VælgElev.Location = new Point(36, 15);
            VælgElev.Name = "VælgElev";
            VælgElev.Size = new Size(57, 15);
            VælgElev.TabIndex = 7;
            VælgElev.Text = "Vælg elev";
            // 
            // VælgOpgave
            // 
            VælgOpgave.AutoSize = true;
            VælgOpgave.Location = new Point(275, 15);
            VælgOpgave.Name = "VælgOpgave";
            VælgOpgave.Size = new Size(75, 15);
            VælgOpgave.TabIndex = 8;
            VælgOpgave.Text = "Vælg opgave";
            // 
            // ny_knap
            // 
            ny_knap.Location = new Point(275, 296);
            ny_knap.Name = "ny_knap";
            ny_knap.Size = new Size(75, 23);
            ny_knap.TabIndex = 9;
            ny_knap.Text = "Ny";
            ny_knap.UseVisualStyleBackColor = true;
            ny_knap.Click += ny_knap_Click;
            // 
            // slet_knap
            // 
            slet_knap.Location = new Point(419, 296);
            slet_knap.Name = "slet_knap";
            slet_knap.Size = new Size(75, 23);
            slet_knap.TabIndex = 10;
            slet_knap.Text = "Slet";
            slet_knap.UseVisualStyleBackColor = true;
            slet_knap.Click += slet_knap_Click;
            // 
            // VisElevBesvarelser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(slet_knap);
            Controls.Add(ny_knap);
            Controls.Add(VælgOpgave);
            Controls.Add(VælgElev);
            Controls.Add(label1);
            Controls.Add(VisSvar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VisElevBesvarelser";
            Text = "Form1";
            Load += VisElevBesvarelser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button VisSvar;
        private Label label1;
        private Label VælgElev;
        private Label VælgOpgave;
        private Button ny_knap;
        private Button slet_knap;
    }
}