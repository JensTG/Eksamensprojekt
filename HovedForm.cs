using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksamensprojekt
{
    public partial class HovedForm : Form
    {
        public HovedForm()
        {
            InitializeComponent();
        }

        private void HovedForm_Load(object sender, EventArgs e)
        {
            ChangeChild(new Loginside());
        }

        public void ChangeChild(Form new_child)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }

            new_child.MdiParent = this;

            new_child.FormBorderStyle = FormBorderStyle.None;
            new_child.ShowInTaskbar = false;

            float w_scale = (float)ClientSize.Width / new_child.Size.Width;
            float h_scale = (float)ClientSize.Height / new_child.Size.Height;
            new_child.Size = ClientSize - new Size(5, 5);

            foreach (Control control in new_child.Controls)
            {
                control.Location = new Point((int)((float)control.Location.X * w_scale), (int)((float)control.Location.Y * h_scale));
            }

            new_child.Show();
            new_child.Location = new Point(0, 0);
            ActivateMdiChild(new_child);
        }

        private void HovedForm_ResizeEnd(object sender, EventArgs e)
        {
            float w_scale = (float)ClientSize.Width / ActiveMdiChild.Size.Width;
            float h_scale = (float)ClientSize.Height / ActiveMdiChild.Size.Height;
            ActiveMdiChild.Size = ClientSize - new Size(5, 5);

            foreach (Control control in ActiveMdiChild.Controls)
            {
                control.Location = new Point((int)((float)control.Location.X * w_scale), (int)((float)control.Location.Y * h_scale));
            }
        }
    }
}
