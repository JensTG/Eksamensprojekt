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
    public partial class OpgaveSide : Form
    {
        public OpgaveSide()
        {
            InitializeComponent();
        }

        private void MenuKnap_Click(object sender, EventArgs e)
        {
            Program.hoved_form.ChangeChild(Program.emneside);
        }

        private void OpgaveSide_Load(object sender, EventArgs e)
        {
            if (BL.spørgsmålsindeks == 0) ForrigeOpgaveKnap.Enabled = false;
            if (BL.spørgsmålsindeks >= BL.spørgsmål.Count) NæsteOpgaveKnap.Enabled = false;
        }

        private void IndlæsSpørgsmål()
        {

        }
    }
}
