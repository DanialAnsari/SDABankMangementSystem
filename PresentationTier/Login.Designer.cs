namespace PresentationTier
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.errorLabel = new System.Windows.Forms.Label();
            this.loginbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 264);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(14, 13);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "#";
            this.errorLabel.Visible = false;
            // 
            // loginbutton
            // 
            this.loginbutton.Depth = 0;
            this.loginbutton.Location = new System.Drawing.Point(161, 217);
            this.loginbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Primary = true;
            this.loginbutton.Size = new System.Drawing.Size(75, 34);
            this.loginbutton.TabIndex = 6;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "Password";
            this.password.Location = new System.Drawing.Point(30, 137);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(206, 23);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = false;
            this.password.Click += new System.EventHandler(this.password_Click);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // userName
            // 
            this.userName.Depth = 0;
            this.userName.Hint = "User Name";
            this.userName.Location = new System.Drawing.Point(30, 88);
            this.userName.MouseState = MaterialSkin.MouseState.HOVER;
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.SelectedText = "";
            this.userName.SelectionLength = 0;
            this.userName.SelectionStart = 0;
            this.userName.Size = new System.Drawing.Size(206, 23);
            this.userName.TabIndex = 4;
            this.userName.UseSystemPasswordChar = false;
            this.userName.Click += new System.EventHandler(this.userName_Click);
            this.userName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userName_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 310);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private MaterialSkin.Controls.MaterialRaisedButton loginbutton;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialSingleLineTextField userName;
    }
}

