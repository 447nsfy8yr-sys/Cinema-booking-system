namespace WinFormsApp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TotalBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNom.Text) && string.IsNullOrEmpty(textCF.Text))
            {
                MessageBox.Show("Ecrire le Nom et le Carte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                double prixBase = 0;
                double prixSalle = 0;
                int comt = 0;
                if (radioAction.Checked)
                {
                    prixBase = 60;
                }
                if (radioAnimation.Checked)
                {
                    prixBase = 40;
                }
                if (radioDrama.Checked)
                {
                    prixBase = 35;
                }
                if (radioStandard.Checked)
                {
                    prixSalle = 0;
                }
                if (radioIMAX.Checked)
                {
                    prixSalle = 20;
                }
                if (radioVIP.Checked)
                {
                    prixSalle = 45;
                }
                if (checkPopCorn.Checked)
                {
                    comt += 25;
                }
                if (checkBoisson.Checked)
                {
                    comt += 15;
                }
                if (checkChocolah.Checked)
                {
                    comt += 10;
                }
                int qte = (int)numericQuantite.Value;
                double total = (prixSalle + prixBase) * qte + comt;
                LabelTotal.Text = total.ToString() + " DH";
            }
        }

        private void radioDrama_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonRecap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNom.Text))
            {
                MessageBox.Show("Sisir le nom du client ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string film = "";
                if (radioAction.Checked == true)
                {
                    film = "Action/BlockBuster";
                }
                if (radioAnimation.Checked == true)
                {
                    film = "Animation/Enfant";
                }
                if (radioDrama.Checked == true)
                {
                    film = "Documentaire/Drama";
                }
                string salle = "";
                if (radioStandard.Checked == true)
                {
                    salle = "Standard";
                }
                if (radioIMAX.Checked == true)
                {
                    salle = "3D/IMAX";

                }
                if (radioVIP.Checked == true)
                {
                    salle = "VIP(Siege Premium)";
                }
                string snack = "";
                if (checkPopCorn.Checked == true)
                {
                    snack += " Pop-corn ";
                }
                if (checkBoisson.Checked == true)
                {
                    snack += " Boisson ";
                }
                if (checkChocolah.Checked == true)
                {
                    snack += " Chocolat ";
                }
                string everything = "-----------Summary-----------" + "\n" + "Client :" + textNom.Text + "\n" + "Film :" + film + "\n" + "Salle :" + salle + "\n" + "Snack :" + snack + "\n" + "Places :" + numericQuantite.Value.ToString() + "\n" + "---------------------------------";
                LabelRecap9.Text = everything;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
