using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void userName_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void password_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void userName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (userName.Text.Length == 0 && e.KeyChar == 8)
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (password.Text.Length == 0 && e.KeyChar == 8)
            {
                SystemSounds.Exclamation.Play();
            }
        }


        //-------------------------------Login---------------------//
        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (userName.Text.Equals("") || password.Text.Equals(""))
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
                errorLabel.Text = "One or more Fields are empty!";
                SystemSounds.Exclamation.Play();
            }
            else
            {
                //Paste the error visible= true and excalamation sound code lines incase of incorrect input as pasted in "if condtion"
            }
        }

    }
}
