﻿namespace Eksamensprojekt
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
            beskr_boks = new TextBox();
            Beskrivelse = new Label();
            ås_knap = new CheckBox();
            ns_spm_knap = new Button();
            upl_bil_knap = new Button();
            gem_knap = new Button();
            fr_spm_knap = new Button();
            SuspendLayout();
            // 
            // MulighedA
            // 
            MulighedA.AutoSize = true;
            MulighedA.Location = new Point(163, 232);
            MulighedA.Name = "MulighedA";
            MulighedA.Size = new Size(18, 15);
            MulighedA.TabIndex = 0;
            MulighedA.Text = "A:";
            // 
            // MulighedB
            // 
            MulighedB.AutoSize = true;
            MulighedB.Location = new Point(164, 259);
            MulighedB.Name = "MulighedB";
            MulighedB.Size = new Size(17, 15);
            MulighedB.TabIndex = 1;
            MulighedB.Text = "B:";
            // 
            // MulighedC
            // 
            MulighedC.AutoSize = true;
            MulighedC.Location = new Point(339, 232);
            MulighedC.Name = "MulighedC";
            MulighedC.Size = new Size(18, 15);
            MulighedC.TabIndex = 2;
            MulighedC.Text = "C:";
            // 
            // MulighedD
            // 
            MulighedD.AutoSize = true;
            MulighedD.Location = new Point(339, 259);
            MulighedD.Name = "MulighedD";
            MulighedD.Size = new Size(18, 15);
            MulighedD.TabIndex = 3;
            MulighedD.Text = "D:";
            // 
            // beskr_boks
            // 
            beskr_boks.Location = new Point(272, 160);
            beskr_boks.Margin = new Padding(3, 2, 3, 2);
            beskr_boks.Name = "beskr_boks";
            beskr_boks.Size = new Size(110, 23);
            beskr_boks.TabIndex = 9;
            beskr_boks.TextChanged += beskr_boks_TextChanged;
            // 
            // Beskrivelse
            // 
            Beskrivelse.AutoSize = true;
            Beskrivelse.Location = new Point(193, 162);
            Beskrivelse.Name = "Beskrivelse";
            Beskrivelse.Size = new Size(67, 15);
            Beskrivelse.TabIndex = 10;
            Beskrivelse.Text = "Beskrivelse:";
            // 
            // ås_knap
            // 
            ås_knap.AutoSize = true;
            ås_knap.Location = new Point(546, 231);
            ås_knap.Name = "ås_knap";
            ås_knap.Size = new Size(82, 19);
            ås_knap.TabIndex = 11;
            ås_knap.Text = "Åbent svar";
            ås_knap.UseVisualStyleBackColor = true;
            // 
            // ns_spm_knap
            // 
            ns_spm_knap.Location = new Point(613, 303);
            ns_spm_knap.Name = "ns_spm_knap";
            ns_spm_knap.Size = new Size(75, 23);
            ns_spm_knap.TabIndex = 13;
            ns_spm_knap.Text = "Næste";
            ns_spm_knap.UseVisualStyleBackColor = true;
            ns_spm_knap.Click += ns_spm_knap_Click;
            // 
            // upl_bil_knap
            // 
            upl_bil_knap.Location = new Point(272, 85);
            upl_bil_knap.Name = "upl_bil_knap";
            upl_bil_knap.Size = new Size(121, 23);
            upl_bil_knap.TabIndex = 14;
            upl_bil_knap.Text = "Upload billede";
            upl_bil_knap.UseVisualStyleBackColor = true;
            upl_bil_knap.Click += upl_bil_knap_Click;
            // 
            // gem_knap
            // 
            gem_knap.Location = new Point(307, 303);
            gem_knap.Name = "gem_knap";
            gem_knap.Size = new Size(75, 23);
            gem_knap.TabIndex = 15;
            gem_knap.Text = "Gem";
            gem_knap.UseVisualStyleBackColor = true;
            // 
            // fr_spm_knap
            // 
            fr_spm_knap.Location = new Point(12, 303);
            fr_spm_knap.Name = "fr_spm_knap";
            fr_spm_knap.Size = new Size(75, 23);
            fr_spm_knap.TabIndex = 16;
            fr_spm_knap.Text = "Forrige";
            fr_spm_knap.UseVisualStyleBackColor = true;
            // 
            // OpgaveEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(fr_spm_knap);
            Controls.Add(gem_knap);
            Controls.Add(upl_bil_knap);
            Controls.Add(ns_spm_knap);
            Controls.Add(ås_knap);
            Controls.Add(Beskrivelse);
            Controls.Add(beskr_boks);
            Controls.Add(MulighedD);
            Controls.Add(MulighedC);
            Controls.Add(MulighedB);
            Controls.Add(MulighedA);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OpgaveEditor";
            Text = "Form1";
            Load += OpgaveEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MulighedA;
		private Label MulighedB;
		private Label MulighedC;
		private Label MulighedD;
		private TextBox beskr_boks;
		private Label Beskrivelse;
		private CheckBox ås_knap;
		private Button ns_spm_knap;
		private Button upl_bil_knap;
		private Button gem_knap;
		private Button fr_spm_knap;
	}
}