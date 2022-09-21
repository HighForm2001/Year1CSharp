namespace EditForm
{
    partial class Edit
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.custBox = new System.Windows.Forms.ComboBox();
            this.custInfoGrpBox = new System.Windows.Forms.GroupBox();
            this.eyeBox = new System.Windows.Forms.PictureBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.contactLbl = new System.Windows.Forms.Label();
            this.addLbl = new System.Windows.Forms.Label();
            this.custIC = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.Label();
            this.ICLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.insuranceBox = new System.Windows.Forms.ComboBox();
            this.claimbtn = new System.Windows.Forms.Button();
            this.insuranceGroupBox = new System.Windows.Forms.GroupBox();
            this.custInfoGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeBox)).BeginInit();
            this.insuranceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // custBox
            // 
            this.custBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custBox.FormattingEnabled = true;
            this.custBox.Location = new System.Drawing.Point(126, 49);
            this.custBox.Name = "custBox";
            this.custBox.Size = new System.Drawing.Size(241, 31);
            this.custBox.TabIndex = 0;
            this.custBox.Text = "Choose Customer ID";
            // 
            // custInfoGrpBox
            // 
            this.custInfoGrpBox.Controls.Add(this.eyeBox);
            this.custInfoGrpBox.Controls.Add(this.emailBox);
            this.custInfoGrpBox.Controls.Add(this.emailLbl);
            this.custInfoGrpBox.Controls.Add(this.pwdTxt);
            this.custInfoGrpBox.Controls.Add(this.saveBtn);
            this.custInfoGrpBox.Controls.Add(this.contactTxt);
            this.custInfoGrpBox.Controls.Add(this.pwdLbl);
            this.custInfoGrpBox.Controls.Add(this.addTextBox);
            this.custInfoGrpBox.Controls.Add(this.contactLbl);
            this.custInfoGrpBox.Controls.Add(this.addLbl);
            this.custInfoGrpBox.Controls.Add(this.custIC);
            this.custInfoGrpBox.Controls.Add(this.custName);
            this.custInfoGrpBox.Controls.Add(this.ICLbl);
            this.custInfoGrpBox.Controls.Add(this.nameLbl);
            this.custInfoGrpBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custInfoGrpBox.Location = new System.Drawing.Point(101, 95);
            this.custInfoGrpBox.Name = "custInfoGrpBox";
            this.custInfoGrpBox.Size = new System.Drawing.Size(552, 477);
            this.custInfoGrpBox.TabIndex = 2;
            this.custInfoGrpBox.TabStop = false;
            this.custInfoGrpBox.Text = "Customer Info";
            // 
            // eyeBox
            // 
            this.eyeBox.Image = ((System.Drawing.Image)(resources.GetObject("eyeBox.Image")));
            this.eyeBox.Location = new System.Drawing.Point(459, 376);
            this.eyeBox.Name = "eyeBox";
            this.eyeBox.Size = new System.Drawing.Size(39, 32);
            this.eyeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeBox.TabIndex = 9;
            this.eyeBox.TabStop = false;
            this.eyeBox.Click += new System.EventHandler(this.eyeBox_Click);
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(210, 117);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(288, 32);
            this.emailBox.TabIndex = 0;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(31, 120);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(170, 23);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "Email                     :";
            // 
            // pwdTxt
            // 
            this.pwdTxt.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTxt.Location = new System.Drawing.Point(210, 376);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.Size = new System.Drawing.Size(252, 32);
            this.pwdTxt.TabIndex = 3;
            this.pwdTxt.UseSystemPasswordChar = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(396, 418);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(140, 39);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // contactTxt
            // 
            this.contactTxt.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTxt.Location = new System.Drawing.Point(210, 337);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(288, 32);
            this.contactTxt.TabIndex = 2;
            // 
            // pwdLbl
            // 
            this.pwdLbl.AutoSize = true;
            this.pwdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdLbl.Location = new System.Drawing.Point(32, 386);
            this.pwdLbl.Name = "pwdLbl";
            this.pwdLbl.Size = new System.Drawing.Size(172, 23);
            this.pwdLbl.TabIndex = 7;
            this.pwdLbl.Text = "Password               :";
            // 
            // addTextBox
            // 
            this.addTextBox.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTextBox.Location = new System.Drawing.Point(210, 169);
            this.addTextBox.Multiline = true;
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(288, 154);
            this.addTextBox.TabIndex = 1;
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLbl.Location = new System.Drawing.Point(27, 340);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(176, 23);
            this.contactLbl.TabIndex = 5;
            this.contactLbl.Text = "Contact Number    :";
            // 
            // addLbl
            // 
            this.addLbl.AutoSize = true;
            this.addLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLbl.Location = new System.Drawing.Point(32, 172);
            this.addLbl.Name = "addLbl";
            this.addLbl.Size = new System.Drawing.Size(170, 23);
            this.addLbl.TabIndex = 4;
            this.addLbl.Text = "Address                 :";
            // 
            // custIC
            // 
            this.custIC.AutoSize = true;
            this.custIC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIC.Location = new System.Drawing.Point(206, 75);
            this.custIC.Name = "custIC";
            this.custIC.Size = new System.Drawing.Size(60, 23);
            this.custIC.TabIndex = 3;
            this.custIC.Text = "label4";
            this.custIC.Visible = false;
            // 
            // custName
            // 
            this.custName.AutoSize = true;
            this.custName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(206, 42);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(60, 23);
            this.custName.TabIndex = 2;
            this.custName.Text = "label3";
            this.custName.Visible = false;
            // 
            // ICLbl
            // 
            this.ICLbl.AutoSize = true;
            this.ICLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICLbl.Location = new System.Drawing.Point(31, 75);
            this.ICLbl.Name = "ICLbl";
            this.ICLbl.Size = new System.Drawing.Size(170, 23);
            this.ICLbl.TabIndex = 1;
            this.ICLbl.Text = "Identity Card(IC) :";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(31, 42);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(171, 23);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name                     :";
            // 
            // applyBtn
            // 
            this.applyBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.Location = new System.Drawing.Point(373, 46);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(88, 35);
            this.applyBtn.TabIndex = 1;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(22, 712);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(140, 39);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // insuranceBox
            // 
            this.insuranceBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceBox.FormattingEnabled = true;
            this.insuranceBox.Location = new System.Drawing.Point(25, 36);
            this.insuranceBox.Name = "insuranceBox";
            this.insuranceBox.Size = new System.Drawing.Size(241, 31);
            this.insuranceBox.TabIndex = 0;
            this.insuranceBox.Text = "Choose Policy ID";
            // 
            // claimbtn
            // 
            this.claimbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimbtn.Location = new System.Drawing.Point(272, 36);
            this.claimbtn.Name = "claimbtn";
            this.claimbtn.Size = new System.Drawing.Size(88, 35);
            this.claimbtn.TabIndex = 1;
            this.claimbtn.Text = "Claim";
            this.claimbtn.UseVisualStyleBackColor = true;
            this.claimbtn.Click += new System.EventHandler(this.Claimbtn_Click);
            // 
            // insuranceGroupBox
            // 
            this.insuranceGroupBox.Controls.Add(this.insuranceBox);
            this.insuranceGroupBox.Controls.Add(this.claimbtn);
            this.insuranceGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceGroupBox.Location = new System.Drawing.Point(101, 578);
            this.insuranceGroupBox.Name = "insuranceGroupBox";
            this.insuranceGroupBox.Size = new System.Drawing.Size(552, 102);
            this.insuranceGroupBox.TabIndex = 3;
            this.insuranceGroupBox.TabStop = false;
            this.insuranceGroupBox.Text = "Customer Insurance";
            this.insuranceGroupBox.Visible = false;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(782, 776);
            this.Controls.Add(this.insuranceGroupBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.custInfoGrpBox);
            this.Controls.Add(this.custBox);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit ";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.custInfoGrpBox.ResumeLayout(false);
            this.custInfoGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeBox)).EndInit();
            this.insuranceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox custBox;
        private System.Windows.Forms.GroupBox custInfoGrpBox;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.Label pwdLbl;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Label contactLbl;
        private System.Windows.Forms.Label addLbl;
        private System.Windows.Forms.Label custIC;
        private System.Windows.Forms.Label custName;
        private System.Windows.Forms.Label ICLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox insuranceBox;
        private System.Windows.Forms.Button claimbtn;
        private System.Windows.Forms.GroupBox insuranceGroupBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.PictureBox eyeBox;
    }
}

