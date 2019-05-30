using System;
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
    public partial class EditAccount : MaterialSkin.Controls.MaterialForm
    {
        public EditAccount()
        {

            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void cmdLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccessTier.Account dp = new DataAccessTier.Account();
            DataTable dt = new DataTable();
            dt=dp.SelectRecordswithID(cmdLoad.Text);
            TxtAccount.Text = cmdLoad.Text;
            txtAccTitle.Text = dt.Rows[0][3].ToString();
            txtCurrBal.Text = dt.Rows[0][4].ToString();
            dateOpened.Text= dt.Rows[0][5].ToString();
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            DataAccessTier.Account dp = new DataAccessTier.Account();
            DataTable dt = new DataTable();
            dt = dp.SelectRecords();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmdLoad.Items.Add(dt.Rows[i][2]);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAccessTier.Account dp = new DataAccessTier.Account();
            string title = txtAccTitle.Text;
            double balance = Convert.ToDouble(txtCurrBal.Text);
            string date = dateOpened.Text;
            dp.UpdateAccount(cmdLoad.Text,TxtAccount.Text, title, balance, date);

            MessageBox.Show("Update Sucessful");
        }
    }
}
