using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksamensprojekt
{
	public partial class VisElevBesvarelser : Form
	{
		public VisElevBesvarelser()
		{
			InitializeComponent();
		}

		private void VisElevBesvarelser_Load(object sender, EventArgs e)
		{
			IndlæsLister();
		}

		private void ny_knap_Click(object sender, EventArgs e)
		{
			BL.alle_opgaver.Add(new Opgave());
			BL.opgaveindeks = BL.alle_opgaver.Count - 1;
			BL.spørgsmålsindeks = 0;
			Program.hoved_form.ChangeChild(new OpgaveEditor());
		}

		private void slet_knap_Click(object sender, EventArgs e)
		{
			if (listBox2.SelectedItems.Count > 0)
				for (int i = 0; i < BL.alle_opgaver.Count; i++)
					if (BL.alle_opgaver[i].titel == listBox2.SelectedItems[0].ToString())
						BL.alle_opgaver.RemoveAt(i);

			IndlæsLister();
		}

		private void VisSvar_Click(object sender, EventArgs e)
		{

		}

		private void IndlæsLister()
		{
			listBox1.Items.Clear();
			listBox2.Items.Clear();

			for (int i = 0; i < BL.brugere.Count; i++)
				if (BL.brugere[i][2] == "e")
					listBox1.Items.Add(BL.brugere[i][0]);

			for (int i = 0; i < BL.alle_opgaver.Count; i++)
				listBox2.Items.Add(BL.alle_opgaver[i].titel);
		}

		private void ret_knap_Click(object sender, EventArgs e)
		{
			if (listBox2.SelectedItems.Count != 0)
			{
				BL.opgaveindeks = listBox2.Items.IndexOf(listBox2.SelectedItems[0]);
				BL.spørgsmålsindeks = 0;
				Program.hoved_form.ChangeChild(new OpgaveEditor());
			}
		}
	}
}
