using System.Windows.Forms;
using System.Linq;
using BusinessLayer.DomainController;
using DataLayer.Interfaces;
using System;


namespace DesktopApp.Forms
{
    public partial class KlubyF : Form
    {
        private readonly IKluby _kluby;
        private readonly KlubyDomain _klubyDomain;
        public KlubyF(IKluby kluby)
        {
            _kluby = kluby;
            _klubyDomain = new KlubyDomain(_kluby);
            InitializeComponent();
            RefreshList();
        }
        private void RefreshList()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = _klubyDomain.VyberVsechnyKluby();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
