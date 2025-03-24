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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(41, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(250, 344);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(314, 43);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(250, 344);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // VisSvar
            // 
            VisSvar.Location = new Point(636, 358);
            VisSvar.Name = "VisSvar";
            VisSvar.Size = new Size(94, 29);
            VisSvar.TabIndex = 2;
            VisSvar.Text = "Vis svar";
            VisSvar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(594, 43);
            label1.Name = "label1";
            label1.Size = new Size(194, 291);
            label1.TabIndex = 6;
            label1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud e";
            // 
            // VælgElev
            // 
            VælgElev.AutoSize = true;
            VælgElev.Location = new Point(41, 20);
            VælgElev.Name = "VælgElev";
            VælgElev.Size = new Size(73, 20);
            VælgElev.TabIndex = 7;
            VælgElev.Text = "Vælg elev";
            // 
            // VælgOpgave
            // 
            VælgOpgave.AutoSize = true;
            VælgOpgave.Location = new Point(314, 20);
            VælgOpgave.Name = "VælgOpgave";
            VælgOpgave.Size = new Size(96, 20);
            VælgOpgave.TabIndex = 8;
            VælgOpgave.Text = "Vælg opgave";
            // 
            // VisElevBesvarelser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VælgOpgave);
            Controls.Add(VælgElev);
            Controls.Add(label1);
            Controls.Add(VisSvar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "VisElevBesvarelser";
            Text = "Form1";
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
    }
}