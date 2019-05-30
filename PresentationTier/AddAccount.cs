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
    public partial class AddAccount : MaterialSkin.Controls.MaterialForm
    {
        public AddAccount()
        {

            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string num=txtAccNum.Text;
            string title = txtAccTitle.Text;
            double balance = Convert.ToDouble(txtCurrBal.Text);
            string date = dateOpened.Text;
            int id = Convert.ToInt32(cmdLoad.Text);

            DataAccessTier.Account ac = new DataAccessTier.Account();

            ac.InsertAccount(id, num, title, balance, date);

            MessageBox.Show("Success");
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            DataAccessTier.Customer dp = new DataAccessTier.Customer();
            DataTable dt = new DataTable();
            dt = dp.SelectRecords();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmdLoad.Items.Add(dt.Rows[i][0]);

            }
        }
    }
}
