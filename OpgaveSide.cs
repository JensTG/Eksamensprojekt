using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksamensprojekt
{
	public partial class OpgaveSide : Form
	{
		Button[] svarknapper = new Button[4];

		int n_fhv_svar = 0;
		List<string> spm_svar = new List<string>();

		public OpgaveSide()
		{
			InitializeComponent();
		}

		private void MenuKnap_Click(object sender, EventArgs e)
		{
			// Gem besvarede spørgsmål
			BL.besvarelser.AddRange(spm_svar[n_fhv_svar..]);

			Program.hoved_form.ChangeChild(Program.emneside);
		}

		private void OpgaveSide_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 4; i++)
			{
				svarknapper[i] = new Button();
				svarknapper[i].Name = "SvarKnap" + i;
				svarknapper[i].Location = new Point(i < 2 ? 352 : 523, i % 2 == 1 ? 183 : 257);
				svarknapper[i].Size = new Size(165, 70);
				svarknapper[i].Margin = new Padding(3, 2, 3, 2);
				svarknapper[i].UseVisualStyleBackColor = true;

				svarknapper[i].Click += SvarKnap_Click;
				Controls.Add(svarknapper[i]);
			}

			spm_svar =
				(from svar in BL.besvarelser
				 where svar.Split('#')[0] == BL.opgaver[BL.opg_idx].titel
				 select svar).ToList();

			n_fhv_svar = spm_svar.Count;

			while (spm_svar.Count < BL.opgaver[BL.opg_idx].spørgsmål.Count)
				spm_svar.Add(null);

			IndlæsSpørgsmål();
		}

		private void SvarKnap_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 4; i++)
			{
				svarknapper[i].BackColor = SystemColors.Control;
				if (svarknapper[i] == sender)
				{
					spm_svar[BL.spm_idx] = BL.opgaver[BL.opg_idx].titel + '#' + i.ToString();
					svarknapper[i].BackColor = SystemColors.ButtonHighlight;
				}
			}
		}

		private void IndlæsSpørgsmål()
		{
			if (BL.spm_idx == 0) ForrigeOpgaveKnap.Enabled = false;
			else ForrigeOpgaveKnap.Enabled = true;
			if (BL.spm_idx >= BL.opgaver[BL.opg_idx].spørgsmål.Count - 1) NæsteOpgaveKnap.Enabled = false;
			else NæsteOpgaveKnap.Enabled = true;

			SvarFelt.TextChanged -= SvarFelt_TextChanged;
			foreach (Control control in Controls)
				if (control.Name.Contains("Svar"))
				{
					control.Hide();
					control.Text = "";
				}
			SvarFelt.TextChanged += SvarFelt_TextChanged;

			if (BL.opgaver[BL.opg_idx].spørgsmål[BL.spm_idx].GetType() == typeof(ÅbentSvar))
			{
				SvarFelt.Show();

				if (BL.spm_idx < spm_svar.Count && spm_svar[BL.spm_idx] != null)
				{
					SvarFelt.Text = spm_svar[BL.spm_idx].Split('#')[1];
				}

			}
			else if (BL.opgaver[BL.opg_idx].spørgsmål[BL.spm_idx].GetType() == typeof(MultipleChoice))
			{
				for (int i = 0; i < 4; i++)
				{
					svarknapper[i].Show();
					svarknapper[i].BackColor = SystemColors.Control;
					svarknapper[i].Text = BL.opgaver[BL.opg_idx].spørgsmål[BL.spm_idx].mulige_svar[i];
				}

				if (BL.spm_idx < spm_svar.Count && spm_svar[BL.spm_idx] != null)
				{
					int.TryParse(spm_svar[BL.spm_idx].Split('#')[1], out int n);
					svarknapper[n].BackColor = SystemColors.ButtonHighlight;
				}
			}

			OpgaveBillede.Image = BL.opgaver[BL.opg_idx].spørgsmål[BL.spm_idx].eksempelbillede;
			OpgaveTekst.Text = BL.opgaver[BL.opg_idx].spørgsmål[BL.spm_idx].beskrivelse;
		}

		private void SvarFelt_TextChanged(object sender, EventArgs e)
		{
			spm_svar[BL.spm_idx] = BL.opgaver[BL.opg_idx].titel + '#' + SvarFelt.Text;
		}

		private void NæsteOpgaveKnap_Click(object sender, EventArgs e)
		{
			BL.spm_idx++;
			IndlæsSpørgsmål();
		}

		private void ForrigeOpgaveKnap_Click(object sender, EventArgs e)
		{
			BL.spm_idx--;
			IndlæsSpørgsmål();
		}
	}
}
