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
    public partial class OpgaveSværhed : Form
    {
        public OpgaveSværhed()
        {
            InitializeComponent();
        }

        private void Svær_Click(object sender, EventArgs e)
        {
            Program.hoved_form.ChangeChild(new OpgaveSide());
        }

        private void Mellem_Click(object sender, EventArgs e)
        {
            Program.hoved_form.ChangeChild(new OpgaveSide());
        }

        private void Let_Click(object sender, EventArgs e)
        {
            Program.hoved_form.ChangeChild(new OpgaveSide());
        }

        private void ForrigeOpgaveKnap_Click(object sender, EventArgs e)
        {

        }

        private void MenuKnap_Click(object sender, EventArgs e)
        {
            Program.hoved_form.ChangeChild(Program.emneside);
        }

        private void NæsteOpgaveKnap_Click(object sender, EventArgs e)
        {

        }

        private void OpgaveSværhed_Load(object sender, EventArgs e)
        {
            if (BL.opg_idx == 0) ForrigeOpgaveKnap.Enabled = false;
            if (BL.opg_idx >= BL.opgaver.Count) NæsteOpgaveKnap.Enabled = false;
        }
    }
}
