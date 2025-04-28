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
    public partial class VælgEmne : Form
    {
        public VælgEmne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                BL.opg_idx = listBox1.Items.IndexOf(listBox1.SelectedItems[0]);
                Program.hoved_form.ChangeChild(new OpgaveSide());
            }
        }

        private void VælgEmne_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < BL.opgaver.Count; i++)
                listBox1.Items.Add(BL.opgaver[i].titel);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                BL.opg_idx = listBox1.Items.IndexOf(listBox1.SelectedItems[0]);
                IndlæsOpgaveForhåndsvisning();
            }
        }

        private void IndlæsOpgaveForhåndsvisning()
        {
            pictureBox1.Image = BL.opgaver[BL.opg_idx].billede;
            beskrivelselabel.Text = BL.opgaver[BL.opg_idx].beskrivelse;
        }
    }
}
