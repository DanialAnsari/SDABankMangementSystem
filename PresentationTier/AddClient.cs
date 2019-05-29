using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessTier;
using DataAccessTier;
namespace PresentationTier
{
    public partial class AddClient : MaterialSkin.Controls.MaterialForm
    {
        public AddClient()
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
            dp.InsertPerson(fname,lname,CNIC,add,city,gender,dateofbirth,religion,education,martial,email);

            if (cmbIncomeType.Text != "") {
                DataTable dt = new DataTable();

                dt = dp.SelectRecords();
                int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]);
                string income = cmbIncomeType.Text;
                string occupation = txtOccupation.Text;
                string org = txtOrganization.Text;
                string design = txtDesignation.Text;

                DataAccessTier.Customer cp = new Customer();
                cp.InsertCustomer(id,income,occupation,org,design);
            }


            MessageBox.Show("Sucess");

        }
    }
}
