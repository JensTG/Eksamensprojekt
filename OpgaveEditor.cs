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
        private CheckBox[] korrekt_tjek = new CheckBox[4];

        public OpgaveEditor()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                mul_bokse[i] = new TextBox();
                mul_bokse[i].Size = new Size(146, 23);
                mul_bokse[i].TabIndex = Controls[Controls.Count - 1].TabIndex + i;
                mul_bokse[i].Name = "mul" + i;

                mul_bokse[i].Location = new Point(i < 2 ? 180 : 370, i % 2 == 1 ? 228 : 256);
                mul_bokse[i].TextChanged += mul_ændret;
                Controls.Add(mul_bokse[i]);

                korrekt_tjek[i] = new CheckBox();
                korrekt_tjek[i].Size = new Size(18, 18);
                korrekt_tjek[i].TabIndex = Controls[Controls.Count - 1].TabIndex + i;
                korrekt_tjek[i].Name = "tjek" + i;

                korrekt_tjek[i].Location = new Point(i < 2 ? 155 : 345, i % 2 == 1 ? 228 : 256);
                korrekt_tjek[i].TextChanged += mul_ændret;
                Controls.Add(korrekt_tjek[i]);

                ResumeLayout(true);
            }
        }

        private void OpgaveEditor_Load(object sender, EventArgs e)
        {
            BL.spørgsmålsindeks = 0;
            nu_mc.mulige_svar = new string[4];

            IndlæsSpørgsmål();
        }

        private void ns_spm_knap_Click(object sender, EventArgs e)
        {
            SætNuværendeSpørgsmål();

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
            }
            catch { }

            BL.data_sti = temp;
        }

        private void IndlæsSpørgsmål()
        {
            if (BL.spørgsmålsindeks < BL.alle_opgaver[BL.opgaveindeks].spørgsmål.Count && BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks] != null)
            {
                beskr_boks.Text = BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks].beskrivelse;

                for (int i = 0; i < 4 && i < BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks].mulige_svar.Length; i++)
                    mul_bokse[i].Text = BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks].mulige_svar[i];

                if (BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks].GetType() == typeof(ÅbentSvar))
                    ås_knap.Checked = true;

                korrekt_tjek[int.Parse(BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks].korrekt)].Checked = true;
            }
        }

        private void OpdaterKnapper()
        {
            fr_spm_knap.Enabled = false;

            if (BL.spørgsmålsindeks > 0)
                fr_spm_knap.Enabled = true;
        }

        private void fr_spm_knap_Click(object sender, EventArgs e)
        {

            if (BL.spørgsmålsindeks > 0)
            {
                SætNuværendeSpørgsmål();
                BL.spørgsmålsindeks--;
                IndlæsSpørgsmål();
            }

        }

        private void gem_knap_Click(object sender, EventArgs e)
        {
            SætNuværendeSpørgsmål();
            Program.hoved_form.ChangeChild(new VisElevBesvarelser());
        }

        private void SætNuværendeSpørgsmål()
        {
            if (BL.spørgsmålsindeks == BL.alle_opgaver[BL.opgaveindeks].spørgsmål.Count)
                BL.alle_opgaver[BL.opgaveindeks].spørgsmål.Add(null); // Tror ikke typen betyder noget her

            if (ås_knap.Checked)
            {
                nu_ås.eksempelbillede = billede;
                BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks] = nu_ås;
            }
            else
            {
                nu_mc.eksempelbillede = billede;
                for (int i = 0; i < 4; i++)
                    if (korrekt_tjek[i].Checked)
                        nu_mc.korrekt = i.ToString();
                BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks] = nu_mc;
            }

            nu_mc = new MultipleChoice();
            nu_ås = new ÅbentSvar();

            beskr_boks.Text = "";
            for (int i = 0; i < 4; i++)
            {
                mul_bokse[i].Text = "";
                korrekt_tjek[i].Checked = false;
            }
            billede = null;
        }

        private void opgave_navn_box_TextChanged(object sender, EventArgs e)
        {
            BL.alle_opgaver[BL.opgaveindeks].titel = opgave_navn_box.Text;
        }
    }
}
