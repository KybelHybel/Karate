using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer.DomainController;
using BusinessLayer.Modely;
using DataLayer.DbTables;
using DataLayer.Interfaces;
using DataLayer.Items;


namespace DesktopApp.Forms
{
    
    public partial class TrenerF : Form
    {
        private readonly ITrener _trener;
        private readonly TrenerDomain _trenerDomain;
        public TrenerF(ITrener trener)
        {
            _trener = trener;
            _trenerDomain = new TrenerDomain(_trener);
            InitializeComponent();
            dataGridView1.CellClick += DataGridView1_CellClick;
            RefreshList();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView table = (DataGridView)sender;
            if (e.RowIndex == -1)
            {
                return;
            }

            int id = ((int)table.Rows[e.RowIndex].Cells["ID_Trenera"].Value);
            Trener a = _trenerDomain.SelectId(id);
            using (AddTrener detail = new AddTrener(a, _trener))
            {
                if (detail.ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                }
            }
        }
        private void RefreshList()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = _trenerDomain.SelectArray();

            var btnCell = new DataGridViewButtonColumn
            {
                HeaderText = @"Detail",
                Text = @"Detail",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(btnCell);
        }
        
            private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTrener vlozit = new AddTrener(new Trener(), _trener);
            vlozit.ShowDialog(this);
            RefreshList();
        }
    }
    
}
