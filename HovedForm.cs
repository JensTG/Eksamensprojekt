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
			AutoScroll = false;
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
			ClientSize = new_child.ClientSize + new Size(5, 5);
			//new_child.WindowState = FormWindowState.Maximized;

			new_child.Show();
			new_child.Location = new Point(0, 0);
			ActivateMdiChild(new_child);
		}
	}
}
