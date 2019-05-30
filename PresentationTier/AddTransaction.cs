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
    public partial class AddTransaction :MaterialSkin.Controls.MaterialForm
    {
        public AddTransaction()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            DataAccessTier.Account dp = new DataAccessTier.Account();
            DataTable dt = new DataTable();
            dt = dp.SelectRecords();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmdLoad.Items.Add(dt.Rows[i][0]);
                metroComboBox1.Items.Add(dt.Rows[i][0]);

            }
        }

        private void cmdTransType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdTransType.Text == "Transfer")
            {
                metroComboBox1.Enabled = true;
            }
            else {
                metroComboBox1.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmdLoad.Text);
            string date = dateTrans.Text;
            string status = cmdMode.Text;
            double amount = Convert.ToDouble(txtAmm.Text);
            string desc = txtDesc.Text;
            string type = cmdTransType.Text;

            DataAccessTier.Transaction tr = new DataAccessTier.Transaction();
            BuisnessTier.Transaction bt = new BuisnessTier.Transaction();
            if (type == "Withdraw")
            {
                bt.Withdraw(amount, id);
            }
            else if(type=="Deposit") {
                bt.Deposit(id,amount);
            }
            tr.InsertBankTransaction(date, amount, type, id, desc, status);

            if (cmdTransType.Text == "Transfer")
            {
                bt.Transfer(id,Convert.ToInt32(metroComboBox1.Text),amount);
                DataTable dt = new DataTable();
                dt=tr.SelectRecords();
                DataAccessTier.MoneyTransfer mt = new DataAccessTier.MoneyTransfer();
                mt.InsertMoneyTransfer(Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0]),id, Convert.ToInt32(metroComboBox1.Text));
            }
            

            MessageBox.Show("Transaction performed Sucessfullt");
            

            
            
        }

        private void cmdLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
