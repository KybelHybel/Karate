using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Forms;
using DataLayer.Database;
using DesktopApp.Persist;
using DataLayer.DbTables;
namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Logged.Instance.Changed += Instance_Changed;
            button_1.Enabled = false;
            button_kluby.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }
        private void Instance_Changed(object sender, EventArgs e)
        {
            if (!Logged.Instance.LoggedState || Logged.Instance.PersonT == false)
            {
            }
            else
            {
                /*var z = (Trener)Logged.Instance.PersonT;
                label_name.Text = "Jméno: " + z.Jmeno;
                label_power.Text = "Oprávnění: Trener";
                label_surname.Text = @"Přijmení:" + z.Prijmeni;*/
                button_1.Enabled = true;
                button_kluby.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }
            if (!Logged.Instance.LoggedState || Logged.Instance.PersonO == false)
            {
            }
            else
            {
                /*var z = (Organizator)Logged.Instance.PersonO;
                label_name.Text = @"Jméno: " + z.Jmeno;
                label_power.Text = @"Oprávnění: Organizator";
                label_surname.Text = @"Přijmení: " + z.Prijmeni;*/
                button_1.Enabled = true;
                button_kluby.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new SoutezeF(new DbSoutez()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new KlubyF(new DbKluby()));
        }

       /*private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new ZavodikF(new DbZavodnik()));
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            using(var a = new Login()){
                if (a.ShowDialog() == DialogResult.OK) { 
                
                }
            }
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel8.Controls.Add(childForm);
            panel8.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new OrganizatorF(new DbOragnizator()));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           openChildForm(new TrenerF(new DbTrener()));
        }

        private void button_trener_Click(object sender, EventArgs e)
        {

        }

        private void button_souteze_Click(object sender, EventArgs e)
        {
            openChildForm(new SoutezeF(new DbSoutez()));
        }

        private void button_klub_Click(object sender, EventArgs e)
        {
            openChildForm(new KlubyF(new DbKluby()));
        }
    }
}
