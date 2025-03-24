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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void Tilbage_Click(object sender, EventArgs e)
        {
            Program.hoved_form.ChangeChild(new VælgEmne());
        }
    }
}
