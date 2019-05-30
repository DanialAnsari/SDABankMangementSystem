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
    public partial class EditClient : MaterialSkin.Controls.MaterialForm
    {
        public EditClient()
        {

            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string fname = sFirstName.Text;
            string lname = sLastName.Text;
            string CNIC = txtCNIC.Text;
            string add = txtAddress.Text;
            string city = cmdCity.Text;
            string gender = cmbGender.Text;
            string dateofbirth = dateOfBirth.Value.ToString();
            string religion = cmbReligion.Text;
            string martial = cmbMarritalStatus.Text;
            string education = cmbEducation.Text;
            string email = txtEmail.Text;

            DataAccessTier.Person dp = new DataAccessTier.Person();
            dp.UpdatePerson(Convert.ToInt32(metroComboBox1.Text),fname, lname, CNIC, add, city, gender, dateofbirth, religion, education, martial, email);

            if (cmbIncomeType.Text != "")
            {
                DataTable dt = new DataTable();

                dt = dp.SelectRecords();
                int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]);
                string income = cmbIncomeType.Text;
                string occupation = txtOccupation.Text;
                string org = txtOrganization.Text;
                string design = txtDesignation.Text;

                DataAccessTier.Customer cp = new DataAccessTier.Customer();
                cp.UpdateCustomer(Convert.ToInt32(metroComboBox1.Text), income, occupation, org, design);
            }


            MessageBox.Show("Update Successful");
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            DataAccessTier.Person dp = new DataAccessTier.Person();
            DataTable dt = new DataTable();
            dt = dp.SelectRecords();

            for (int i = 0; i < dt.Rows.Count; i++) {
                metroComboBox1.Items.Add(dt.Rows[i][0]);

            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccessTier.Person dp = new DataAccessTier.Person();
            DataTable dt = new DataTable();
            dt = dp.SelectRecordswithID(Convert.ToInt32(metroComboBox1.Text));

            sFirstName.Text = Convert.ToString(dt.Rows[0][1]);
            sLastName.Text= Convert.ToString(dt.Rows[0][2]);
            txtCNIC.Text= Convert.ToString(dt.Rows[0][3]);
            txtAddress.Text= Convert.ToString(dt.Rows[0][4]);
            cmdCity.Text= Convert.ToString(dt.Rows[0][5]);
            cmbGender.Text= Convert.ToString(dt.Rows[0][6]);
            dateOfBirth.Text= Convert.ToString(dt.Rows[0][7]);
            cmbReligion.Text= Convert.ToString(dt.Rows[0][8]);
            cmbEducation.Text= Convert.ToString(dt.Rows[0][9]);
            cmbMarritalStatus.Text= Convert.ToString(dt.Rows[0][10]);
            txtEmail.Text= Convert.ToString(dt.Rows[0][11]);

            DataAccessTier.Customer dc = new DataAccessTier.Customer();
            dt = dc.SelectRecordswithID(Convert.ToInt32(metroComboBox1.Text));

            if (dt.Rows.Count != 0) {
                cmbIncomeType.Text = Convert.ToString(dt.Rows[0][1]);
                txtOccupation.Text = Convert.ToString(dt.Rows[0][2]);
                txtOrganization.Text = Convert.ToString(dt.Rows[0][3]);
                txtDesignation.Text = Convert.ToString(dt.Rows[0][4]);
            }

           
        }
    }
}
