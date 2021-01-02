using System;
using System.Windows.Forms;
using BusinessLayer.DomainController;
using DataLayer.Interfaces;
using DataLayer.Items;

namespace DesktopApp.Forms
{
    public partial class AddTrener : Form
    {
        private Trener trener;
        private readonly ITrener _itrener;
        private readonly TrenerDomain _trenerDomain;
        public AddTrener(Trener trener, ITrener itrener)
        {
            InitializeComponent();
            _itrener = itrener;
            _trenerDomain = new TrenerDomain(_itrener);

            trener = LoadTrener(trener);
            tb_id.Text = trener.ID_Trenera.ToString();
            tb_jmeno.Text = trener.Jmeno;
            tb_prijmeni.Text = trener.Prijmeni;
            tb_pohlavi.Text = trener.Pohlavi;
            dtp_datum.Value = trener.Datum_narozeni < (new DateTime(1900,1,1)) ? new DateTime(2000, 1, 1) : trener.Datum_narozeni;
        }

        private Trener LoadTrener(Trener trener)
        {
            Trener tempTrener = new Trener();
            tempTrener.ID_Trenera = trener.ID_Trenera;
            tempTrener.Jmeno = trener.Jmeno;
            tempTrener.Prijmeni = trener.Prijmeni;
            tempTrener.Pohlavi = trener.Pohlavi;
            tempTrener.Datum_narozeni = trener.Datum_narozeni;

            return tempTrener;
        }
        private bool ValidateInput()
        {
            if (tb_id.Text.Equals("")) return false;
            if (tb_jmeno.Text.Equals("")) return false;
            if (tb_prijmeni.Text.Equals("")) return false;
            if (tb_pohlavi.Text.Equals("")) return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trener = new Trener();
            if (!ValidateInput())
            {
                MessageBox.Show(@"Bad args");
                return;
            }
            trener.Jmeno = tb_jmeno.Text;
            trener.Prijmeni = tb_prijmeni.Text;
            trener.Pohlavi = tb_pohlavi.Text;
            trener.Datum_narozeni = dtp_datum.Value;
            trener.Heslo = "12345";
            _trenerDomain.InsertTrener(trener);
            DialogResult = DialogResult.OK;
        }
    }
}
