using System.Windows.Forms;
using BusinessLayer.DomainController;
using DataLayer.Interfaces;
using DataLayer.Items;
using System;
namespace DesktopApp.Forms
{
    public partial class NovaSoutezF : Form
    {
        private readonly Soutez soutez;
        private readonly ISoutez _isoutez;
        private readonly SoutezDomain _soutezDomain;

        public NovaSoutezF(Soutez soute, ISoutez isoutez)
        {
            InitializeComponent();

            _isoutez = isoutez;
            _soutezDomain = new SoutezDomain(_isoutez);
            soutez = LoadSoutez(soute);
            tb_nezev.Text = soutez.Nazev;
            tb_startovne.Text = soutez.Startovne.ToString();
            dtp_datum.Value = soutez.Kdy;
            tb_organizator.Text = soutez.Organizator_ID_Organizatora.ToString();
            tb_adresa.Text = soutez.Adresa_ID_Adresy.ToString();

        }
        private Soutez LoadSoutez(Soutez soutez)
        {
            Soutez tempSoutez = new Soutez();
            tempSoutez.ID_Souteze = soutez.ID_Souteze;
            tempSoutez.Nazev = soutez.Nazev;
            tempSoutez.Kdy = soutez.Kdy;
            tempSoutez.Startovne = soutez.Startovne;
            tempSoutez.Organizator_ID_Organizatora = soutez.Organizator_ID_Organizatora;
            tempSoutez.Adresa_ID_Adresy = soutez.Adresa_ID_Adresy;
            return tempSoutez;
        }
            private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput()
        {
            if (tb_nezev.Text.Equals("")) return false;
            if (tb_startovne.Text.Equals("")) return false;
            if (tb_adresa.Text.Equals("")) return false;
            if (tb_organizator.Text.Equals("")) return false;
            else return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show(@"Bad args");
                return;
            }

            soutez.Nazev = tb_nezev.Text;
            soutez.Startovne = int.Parse(tb_startovne.Text);
            soutez.Organizator_ID_Organizatora = int.Parse(tb_organizator.Text);
            soutez.Adresa_ID_Adresy = int.Parse(tb_adresa.Text);
            soutez.Kdy = dtp_datum.Value;

            _soutezDomain.InsertSoutez(soutez);
            DialogResult = DialogResult.OK;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
