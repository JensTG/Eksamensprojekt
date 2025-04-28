using ofuasofhuoashhd;

namespace Eksamensprojekt
{
	public partial class Loginside : Form
	{
		public Loginside()
		{
			InitializeComponent();
		}

		private void Brugernavn_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int status = BL.ErBruger(textBox1.Text, textBox2.Text);

			switch (status)
			{
				case -1:
					MessageBox.Show("Brugernavn eller adgangskode er forkert");
					return;
				case 0:
					BL.IndlæsBesvarelser();
					Program.hoved_form.ChangeChild(new VælgEmne());
					return;
				case 1:
					Program.hoved_form.ChangeChild(new VisElevBesvarelser());
					return;
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{

			bool oprettet = BL.OpretBruger(textBox1.Text, textBox2.Text);

			if (oprettet == true)
			{
				MessageBox.Show("Brugeren eksisterer allerede");
			}
			MessageBox.Show("Brugeren er nu oprettet");
		}

		private void Loginside_Load(object sender, EventArgs e)
		{
			pictureBox1.Hide();
		}

		private void IndlæsDataKnap(object sender, EventArgs e)
		{
			Explorer explorer = new Explorer();
			explorer.ShowDialog();

			BL.IndlæsData();
			pictureBox1.Image = Image.FromFile(BL.data_sti + "\\billeder\\logo.png");
			pictureBox1.Show();

			button1.Hide();
		}
	}
}
