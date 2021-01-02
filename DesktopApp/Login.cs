using System;
using System.Windows.Forms;
using DataLayer.DbTables;
using DesktopApp.Persist;
using DataLayer.Interfaces;
using BusinessLayer.DomainController;

namespace DesktopApp
{
    public partial class Login : Form
    {
        private readonly IOragnizator _organizator;
        private readonly ITrener _trener;

        private OrganizatorDomain _organizatorDomain;
        private TrenerDomain _trenerDomain;
        public Login()
        {
            InitializeComponent();
            _organizator = new DbOragnizator();
            _trener = new DbTrener();
            _organizatorDomain = new OrganizatorDomain(_organizator);
            _trenerDomain = new TrenerDomain(_trener);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Trener")
            {
                var z = _trenerDomain.GetLogin(tb_login.Text, tb_pwd.Text);
                if (z == false)
                {
                    MessageBox.Show(@"Nepodařilo se přihlásit");
                    return;
                }
                Logged.Instance.PersonT = z;
                Logged.Instance.LoggedState = true;

                DialogResult = DialogResult.OK;
            }
            else if (comboBox1.Text == "Organizator")
            {
                var z = _organizatorDomain.GetLogin(tb_login.Text, tb_pwd.Text);

                if (z == false)
                {
                    MessageBox.Show(@"Nepodařilo se přihlásit");
                    return;
                }
                Logged.Instance.PersonO = z;
                Logged.Instance.LoggedState = true;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(@"Zadej typ uživatele");
                return;
            }
        }
    }
}
