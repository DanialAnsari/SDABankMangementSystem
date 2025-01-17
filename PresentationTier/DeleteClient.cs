﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class DeleteClient : MaterialSkin.Controls.MaterialForm
    {
        public DeleteClient()
        {

            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void DeleteClient_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 205, 50);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            DataAccessTier.Person dp = new DataAccessTier.Person();
            DataTable dt = new DataTable();
            dt = dp.SelectRecords();

            dataGridView1.DataSource = dt;
        }

        private void btnDelte_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

            DataAccessTier.Person dp = new DataAccessTier.Person();

            dp.DeletePerson(id);

            
                DataAccessTier.Customer cp = new DataAccessTier.Customer();
                cp.DeleteCustomer(id);

            MessageBox.Show("Delete Sucessful");

            DataTable dt = new DataTable();
            dt = dp.SelectRecords();

            dataGridView1.DataSource = dt;

        }
    }
}
