using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.DomainController;
using DataLayer.Interfaces;

namespace DesktopApp.Forms
{
    public partial class OrganizatorF : Form
    {
        private readonly IOragnizator _oragnizator;
        private readonly OrganizatorDomain _organizatorDomain;
        public OrganizatorF(IOragnizator oragnizator)
        {
            _oragnizator = oragnizator;
            _organizatorDomain = new OrganizatorDomain(_oragnizator);
            InitializeComponent();
            RefreshList();
        }
        private void RefreshList()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = _organizatorDomain.SelectArray();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
