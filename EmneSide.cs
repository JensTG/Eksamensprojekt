﻿using System;
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
            Program.hoved_form.ChangeChild(new OpgaveSværhed());
        }
    }
}
