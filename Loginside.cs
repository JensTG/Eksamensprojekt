namespace Eksamensprojekt
{
    public partial class Loginside : Form
    {
        public Loginside()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                    VælgEmne ve = new VælgEmne();
                    ve.ShowDialog();
                    return;

                case 1:
                    LærerSide ls = new LærerSide();
                    ls.ShowDialog();
                    return;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BL.ErBruger(textBox1.Text, textBox2.Text)==-1)
            {
                BL.OpretBruger(textBox1.Text, textBox2.Text);
                MessageBox.Show("Brugeren er nu oprettet");
            }
            MessageBox.Show("Brugeren eksisterer allerede");
        }
    }
}
