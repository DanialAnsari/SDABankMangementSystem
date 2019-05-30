namespace PresentationTier
{
    partial class AddTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransaction));
            this.btnEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.cmdTransType = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmdMode = new MetroFramework.Controls.MetroComboBox();
            this.txtAmm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTrans = new MetroFramework.Controls.MetroDateTime();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.comboCity = new MaterialSkin.Controls.MaterialLabel();
            this.cmdLoad = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Depth = 0;
            this.btnEdit.Location = new System.Drawing.Point(663, 560);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = true;
            this.btnEdit.Size = new System.Drawing.Size(100, 38);
            this.btnEdit.TabIndex = 182;
            this.btnEdit.Text = "Add";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(13, 282);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(748, 1);
            this.materialDivider2.TabIndex = 173;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(19, 333);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(129, 19);
            this.materialLabel8.TabIndex = 177;
            this.materialLabel8.Text = "Transaction Type:";
            // 
            // cmdTransType
            // 
            this.cmdTransType.FormattingEnabled = true;
            this.cmdTransType.ItemHeight = 23;
            this.cmdTransType.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw",
            "Transfer"});
            this.cmdTransType.Location = new System.Drawing.Point(161, 333);
            this.cmdTransType.Name = "cmdTransType";
            this.cmdTransType.Size = new System.Drawing.Size(216, 29);
            this.cmdTransType.TabIndex = 176;
            this.cmdTransType.UseSelectable = true;
            this.cmdTransType.SelectedIndexChanged += new System.EventHandler(this.cmdTransType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 38);
            this.panel1.TabIndex = 174;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Normal Transaction";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(29, 573);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(14, 13);
            this.errorLabel.TabIndex = 183;
            this.errorLabel.Text = "#";
            this.errorLabel.Visible = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(19, 433);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(91, 19);
            this.materialLabel6.TabIndex = 178;
            this.materialLabel6.Text = "To Account:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 38);
            this.panel2.TabIndex = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer Transaction";
            // 
            // txtDesc
            // 
            this.txtDesc.Depth = 0;
            this.txtDesc.Hint = "";
            this.txtDesc.Location = new System.Drawing.Point(153, 218);
            this.txtDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.Size = new System.Drawing.Size(216, 23);
            this.txtDesc.TabIndex = 172;
            this.txtDesc.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(11, 218);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(90, 19);
            this.materialLabel5.TabIndex = 171;
            this.materialLabel5.Text = "Description:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 297);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 19);
            this.materialLabel2.TabIndex = 170;
            this.materialLabel2.Text = "Load Account:";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "021",
            "044",
            "081",
            "042",
            "022",
            "087"});
            this.metroComboBox2.Location = new System.Drawing.Point(153, 298);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(216, 29);
            this.metroComboBox2.TabIndex = 169;
            this.metroComboBox2.UseSelectable = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 154);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(52, 19);
            this.materialLabel1.TabIndex = 168;
            this.materialLabel1.Text = "Status";
            // 
            // cmdMode
            // 
            this.cmdMode.FormattingEnabled = true;
            this.cmdMode.ItemHeight = 23;
            this.cmdMode.Items.AddRange(new object[] {
            "Pending",
            "Completed"});
            this.cmdMode.Location = new System.Drawing.Point(153, 154);
            this.cmdMode.Name = "cmdMode";
            this.cmdMode.Size = new System.Drawing.Size(216, 29);
            this.cmdMode.TabIndex = 167;
            this.cmdMode.UseSelectable = true;
            // 
            // txtAmm
            // 
            this.txtAmm.Depth = 0;
            this.txtAmm.Hint = "";
            this.txtAmm.Location = new System.Drawing.Point(153, 189);
            this.txtAmm.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAmm.Name = "txtAmm";
            this.txtAmm.PasswordChar = '\0';
            this.txtAmm.SelectedText = "";
            this.txtAmm.SelectionLength = 0;
            this.txtAmm.SelectionStart = 0;
            this.txtAmm.Size = new System.Drawing.Size(216, 23);
            this.txtAmm.TabIndex = 166;
            this.txtAmm.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(11, 189);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 19);
            this.materialLabel3.TabIndex = 165;
            this.materialLabel3.Text = "Amount:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(11, 119);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(128, 19);
            this.materialLabel4.TabIndex = 164;
            this.materialLabel4.Text = "Transaction Date:";
            // 
            // dateTrans
            // 
            this.dateTrans.Location = new System.Drawing.Point(153, 119);
            this.dateTrans.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTrans.Name = "dateTrans";
            this.dateTrans.Size = new System.Drawing.Size(216, 29);
            this.dateTrans.TabIndex = 163;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(707, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 162;
            this.pictureBox1.TabStop = false;
            // 
            // picCustomer
            // 
            this.picCustomer.BackColor = System.Drawing.Color.White;
            this.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCustomer.Image = ((System.Drawing.Image)(resources.GetObject("picCustomer.Image")));
            this.picCustomer.Location = new System.Drawing.Point(606, 84);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(161, 160);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCustomer.TabIndex = 161;
            this.picCustomer.TabStop = false;
            // 
            // comboCity
            // 
            this.comboCity.AutoSize = true;
            this.comboCity.BackColor = System.Drawing.Color.Transparent;
            this.comboCity.Depth = 0;
            this.comboCity.Font = new System.Drawing.Font("Roboto", 11F);
            this.comboCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboCity.Location = new System.Drawing.Point(13, 84);
            this.comboCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.comboCity.Name = "comboCity";
            this.comboCity.Size = new System.Drawing.Size(106, 19);
            this.comboCity.TabIndex = 160;
            this.comboCity.Text = "Load Account:";
            // 
            // cmdLoad
            // 
            this.cmdLoad.FormattingEnabled = true;
            this.cmdLoad.ItemHeight = 23;
            this.cmdLoad.Location = new System.Drawing.Point(153, 84);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(216, 29);
            this.cmdLoad.TabIndex = 159;
            this.cmdLoad.UseSelectable = true;
            this.cmdLoad.SelectedIndexChanged += new System.EventHandler(this.cmdLoad_SelectedIndexChanged);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Enabled = false;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(161, 429);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(216, 29);
            this.metroComboBox1.TabIndex = 184;
            this.metroComboBox1.UseSelectable = true;
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 610);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.cmdTransType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmdMode);
            this.Controls.Add(this.txtAmm);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dateTrans);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picCustomer);
            this.Controls.Add(this.comboCity);
            this.Controls.Add(this.cmdLoad);
            this.MaximizeBox = false;
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnEdit;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MetroFramework.Controls.MetroComboBox cmdTransType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDesc;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroComboBox cmdMode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAmm;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MetroFramework.Controls.MetroDateTime dateTrans;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCustomer;
        private MaterialSkin.Controls.MaterialLabel comboCity;
        private MetroFramework.Controls.MetroComboBox cmdLoad;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}