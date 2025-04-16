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

        public OpgaveEditor()
        {
            InitializeComponent();
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

            billede = Image.FromFile(BL.data_sti);

            BL.data_sti = temp;
        }

        private void IndlæsSpørgsmål()
        {
            if (BL.spørgsmålsindeks < BL.alle_opgaver[BL.opgaveindeks].spørgsmål.Count)
            {
                beskr_boks.Text = BL.alle_opgaver[BL.opgaveindeks].spørgsmål[BL.spørgsmålsindeks].beskrivelse;

                for (int i = 0; i < 4; i++)
            }
        }
    }
}
