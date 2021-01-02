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
    public partial class SoutezeF : Form
    {
        private readonly ISoutez _soutez;
        private readonly SoutezDomain _soutezDomain;
        public SoutezeF(ISoutez soutez)
        {
            _soutez = soutez;
            _soutezDomain = new SoutezDomain(_soutez);
            InitializeComponent();
            dataGridView1.CellDoubleClick += DataGridView1_CellClick;
            RefreshList();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView table = (DataGridView)sender;
            if (e.RowIndex == -1)
            {
                return;
            }

            Soutez a = _soutez.SelectId((int)table.Rows[e.RowIndex].Cells["id_souteze"].Value);
            using (NovaSoutezF detail = new NovaSoutezF(a, _soutez))
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

            dataGridView1.DataSource = _soutezDomain.SelectArray();

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
            NovaSoutezF vlozit = new NovaSoutezF(new Soutez(), _soutez);
            vlozit.ShowDialog(this);
            RefreshList();

        }
    }
}
