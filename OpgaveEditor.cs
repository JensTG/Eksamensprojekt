using ofuasofhuoashhd;
using System;
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
	public partial class OpgaveEditor : Form
	{
		MultipleChoice nu_mc = new MultipleChoice();
		ÅbentSvar nu_ås = new ÅbentSvar();
		Image? billede;

		private TextBox[] mul_bokse = new TextBox[4];

		public OpgaveEditor()
		{
			InitializeComponent();

			for (int i = 0; i < 4; i++)
			{
				mul_bokse[i] = new TextBox();
				mul_bokse[i].Size = new Size(146, 23);
				mul_bokse[i].TabIndex = Controls[Controls.Count - 1].TabIndex + i;
				mul_bokse[i].Name = "mul" + i;

				mul_bokse[i].Location = new Point(i < 2 ? 187 : 363, i % 2 == 1 ? 228 : 256);
				mul_bokse[i].TextChanged += mul_ændret;
				Controls.Add(mul_bokse[i]);
				ResumeLayout(true);
			}
		}

		private void OpgaveEditor_Load(object sender, EventArgs e)
		{
			BL.spørgsmålsindeks = 0;
			nu_mc.mulige_svar = new string[4];
		}

		private void ns_spm_knap_Click(object sender, EventArgs e)
		{
			if (ås_knap.Checked)
				BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks] = nu_ås;
			else
				BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks] = nu_mc;

			if (BL.spørgsmålsindeks == BL.alle_opgaver[BL.opgaveindeks].spørgsmål.Count - 1)
				BL.alle_opgaver[BL.opgaveindeks].spørgsmål.Add(new MultipleChoice()); // Tror ikke typen betyder noget her

			BL.spørgsmålsindeks++;
			IndlæsSpørgsmål();
        }

		private void beskr_boks_TextChanged(object sender, EventArgs e)
		{
			nu_ås.beskrivelse = beskr_boks.Text;
			nu_mc.beskrivelse = beskr_boks.Text;
		}

		private void mul_ændret(object sender, EventArgs e)
		{
			for (int i = 0; i < 4; i++)
				nu_mc.mulige_svar[i] = mul_bokse[i].Text;
		}

		private void upl_bil_knap_Click(object sender, EventArgs e)
		{
			string temp = BL.data_sti;

			Explorer explorer = new Explorer();
			explorer.ShowDialog();

			try
			{
				billede = Image.FromFile(BL.data_sti);
			} catch { }

			BL.data_sti = temp;
		}

		private void IndlæsSpørgsmål()
		{
			if (BL.spørgsmålsindeks < BL.alle_opgaver[BL.opgaveindeks].spørgsmål.Count)
			{
				beskr_boks.Text = BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks].beskrivelse;

				for (int i = 0; i < 4 && i < BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks].mulige_svar.Length; i++)
					mul_bokse[i].Text = BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks].mulige_svar[i];
            }
		}

		private void OpdaterKnapper()
		{
			fr_spm_knap.Enabled = false;

			if (BL.spørgsmålsindeks > 0)
				fr_spm_knap.Enabled = true;
		}
	}
}
