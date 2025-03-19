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
            // int status = BL.ErBruger(textBox1.Text, textBox2.Text);
            int status = 0;
            switch(status)
            {
                case -1:
                    
                    return;
                case 0:
                    Form form = new Form();
                    form.Show();

                    return;
                case 1:
                    return;

            }

        }
    }
}
