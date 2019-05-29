namespace PresentationTier
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.comboCity = new MaterialSkin.Controls.MaterialLabel();
            this.cmdLoad = new MetroFramework.Controls.MetroComboBox();
            this.txtCurrBal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAccTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAccNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dateOpened = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCity
            // 
            this.comboCity.AutoSize = true;
            this.comboCity.BackColor = System.Drawing.Color.Transparent;
            this.comboCity.Depth = 0;
            this.comboCity.Font = new System.Drawing.Font("Roboto", 11F);
            this.comboCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboCity.Location = new System.Drawing.Point(12, 85);
            this.comboCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.comboCity.Name = "comboCity";
            this.comboCity.Size = new System.Drawing.Size(116, 19);
            this.comboCity.TabIndex = 68;
            this.comboCity.Text = "Load Customer:";
            // 
            // cmdLoad
            // 
            this.cmdLoad.FormattingEnabled = true;
            this.cmdLoad.ItemHeight = 23;
            this.cmdLoad.Items.AddRange(new object[] {
            "021",
            "044",
            "081",
            "042",
            "022",
            "087"});
            this.cmdLoad.Location = new System.Drawing.Point(154, 85);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(216, 29);
            this.cmdLoad.TabIndex = 67;
            this.cmdLoad.UseSelectable = true;
            // 
            // txtCurrBal
            // 
            this.txtCurrBal.Depth = 0;
            this.txtCurrBal.Hint = "";
            this.txtCurrBal.Location = new System.Drawing.Point(154, 178);
            this.txtCurrBal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCurrBal.Name = "txtCurrBal";
            this.txtCurrBal.PasswordChar = '\0';
            this.txtCurrBal.SelectedText = "";
            this.txtCurrBal.SelectionLength = 0;
            this.txtCurrBal.SelectionStart = 0;
            this.txtCurrBal.Size = new System.Drawing.Size(216, 23);
            this.txtCurrBal.TabIndex = 70;
            this.txtCurrBal.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 179);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 19);
            this.materialLabel2.TabIndex = 69;
            this.materialLabel2.Text = "Current Balance:";
            // 
            // txtAccTitle
            // 
            this.txtAccTitle.Depth = 0;
            this.txtAccTitle.Hint = "";
            this.txtAccTitle.Location = new System.Drawing.Point(154, 149);
            this.txtAccTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAccTitle.Name = "txtAccTitle";
            this.txtAccTitle.PasswordChar = '\0';
            this.txtAccTitle.SelectedText = "";
            this.txtAccTitle.SelectionLength = 0;
            this.txtAccTitle.SelectionStart = 0;
            this.txtAccTitle.Size = new System.Drawing.Size(216, 23);
            this.txtAccTitle.TabIndex = 72;
            this.txtAccTitle.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 150);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(103, 19);
            this.materialLabel1.TabIndex = 71;
            this.materialLabel1.Text = "Account Title:";
            // 
            // txtAccNum
            // 
            this.txtAccNum.Depth = 0;
            this.txtAccNum.Hint = "";
            this.txtAccNum.Location = new System.Drawing.Point(154, 120);
            this.txtAccNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.PasswordChar = '\0';
            this.txtAccNum.SelectedText = "";
            this.txtAccNum.SelectionLength = 0;
            this.txtAccNum.SelectionStart = 0;
            this.txtAccNum.Size = new System.Drawing.Size(216, 23);
            this.txtAccNum.TabIndex = 74;
            this.txtAccNum.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 120);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(126, 19);
            this.materialLabel3.TabIndex = 73;
            this.materialLabel3.Text = "Account Number:";
            // 
            // dateOpened
            // 
            this.dateOpened.Location = new System.Drawing.Point(154, 207);
            this.dateOpened.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateOpened.Name = "dateOpened";
            this.dateOpened.Size = new System.Drawing.Size(216, 29);
            this.dateOpened.TabIndex = 75;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 207);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(98, 19);
            this.materialLabel4.TabIndex = 76;
            this.materialLabel4.Text = "Date Opened:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(706, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // picCustomer
            // 
            this.picCustomer.BackColor = System.Drawing.Color.White;
            this.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCustomer.Image = ((System.Drawing.Image)(resources.GetObject("picCustomer.Image")));
            this.picCustomer.Location = new System.Drawing.Point(605, 85);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(161, 160);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCustomer.TabIndex = 109;
            this.picCustomer.TabStop = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(32, 573);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(14, 13);
            this.errorLabel.TabIndex = 112;
            this.errorLabel.Text = "#";
            this.errorLabel.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(666, 560);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(100, 38);
            this.btnAdd.TabIndex = 111;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 610);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picCustomer);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dateOpened);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtAccTitle);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtCurrBal);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.comboCity);
            this.Controls.Add(this.cmdLoad);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Account";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel comboCity;
        private MetroFramework.Controls.MetroComboBox cmdLoad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCurrBal;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAccTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAccNum;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MetroFramework.Controls.MetroDateTime dateOpened;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.Label errorLabel;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
    }
}