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
			foreach (Form child in MdiChildren) // Gemmer alle andre Forms end den der nu skal vises
			{
				child.Hide();
			}

			new_child.MdiParent = this; // Gør Hoved-Formen til MDI Parent

			new_child.FormBorderStyle = FormBorderStyle.None; // Fjerner "titel-blokken" på den indre Form
			ClientSize = new_child.ClientSize + new Size(5, 5); // Sørger for at Hoved-Formen er stor nok til den indre form

			new_child.Show();
			new_child.Location = new Point(0, 0); // Rykker den indre Form helt op i venstre hjørne
			ActivateMdiChild(new_child); // Sætter "fokus" på den indre Form
		}
	}
}
