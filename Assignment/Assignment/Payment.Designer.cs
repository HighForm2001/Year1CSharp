namespace Assignment
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTypeFinal = new System.Windows.Forms.Label();
            this.lblDescFinal = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblRateFinal = new System.Windows.Forms.Label();
            this.checkboxTnC = new System.Windows.Forms.CheckBox();
            this.lblPaymentTitle = new System.Windows.Forms.Label();
            this.bankingbtn = new System.Windows.Forms.RadioButton();
            this.atmbtn = new System.Windows.Forms.RadioButton();
            this.instalbtn = new System.Windows.Forms.RadioButton();
            this.cardbtn = new System.Windows.Forms.RadioButton();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGrosstotal = new System.Windows.Forms.Label();
            this.lblSST = new System.Windows.Forms.Label();
            this.lblStampDuty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRM = new System.Windows.Forms.Label();
            this.grpProduct.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.tableLayoutPanel1);
            this.grpProduct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProduct.Location = new System.Drawing.Point(21, 31);
            this.grpProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProduct.Size = new System.Drawing.Size(685, 176);
            this.grpProduct.TabIndex = 0;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product Selection";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.47369F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.lblType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTypeFinal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDescFinal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDesc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRateFinal, 2, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.68707F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.31293F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 127);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(4, 1);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(107, 19);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Insurance type";
            // 
            // lblTypeFinal
            // 
            this.lblTypeFinal.AutoSize = true;
            this.lblTypeFinal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeFinal.Location = new System.Drawing.Point(4, 23);
            this.lblTypeFinal.Name = "lblTypeFinal";
            this.lblTypeFinal.Size = new System.Drawing.Size(83, 19);
            this.lblTypeFinal.TabIndex = 2;
            this.lblTypeFinal.Text = "Third party";
            // 
            // lblDescFinal
            // 
            this.lblDescFinal.AutoSize = true;
            this.lblDescFinal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescFinal.Location = new System.Drawing.Point(175, 23);
            this.lblDescFinal.Name = "lblDescFinal";
            this.lblDescFinal.Size = new System.Drawing.Size(378, 76);
            this.lblDescFinal.TabIndex = 2;
            this.lblDescFinal.Text = resources.GetString("lblDescFinal.Text");
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(175, 1);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(90, 19);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(562, 1);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(66, 19);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Rate(%)";
            // 
            // lblRateFinal
            // 
            this.lblRateFinal.AutoSize = true;
            this.lblRateFinal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateFinal.Location = new System.Drawing.Point(562, 23);
            this.lblRateFinal.Name = "lblRateFinal";
            this.lblRateFinal.Size = new System.Drawing.Size(40, 19);
            this.lblRateFinal.TabIndex = 2;
            this.lblRateFinal.Text = "2.66";
            // 
            // checkboxTnC
            // 
            this.checkboxTnC.AutoSize = true;
            this.checkboxTnC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxTnC.Location = new System.Drawing.Point(373, 211);
            this.checkboxTnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkboxTnC.Name = "checkboxTnC";
            this.checkboxTnC.Size = new System.Drawing.Size(333, 23);
            this.checkboxTnC.TabIndex = 1;
            this.checkboxTnC.Text = "I have read and agree to the terms of service.";
            this.checkboxTnC.UseVisualStyleBackColor = true;
            // 
            // lblPaymentTitle
            // 
            this.lblPaymentTitle.AutoSize = true;
            this.lblPaymentTitle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTitle.Location = new System.Drawing.Point(25, 245);
            this.lblPaymentTitle.Name = "lblPaymentTitle";
            this.lblPaymentTitle.Size = new System.Drawing.Size(125, 19);
            this.lblPaymentTitle.TabIndex = 2;
            this.lblPaymentTitle.Text = "Payment Method";
            // 
            // bankingbtn
            // 
            this.bankingbtn.AutoSize = true;
            this.bankingbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankingbtn.Location = new System.Drawing.Point(29, 274);
            this.bankingbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bankingbtn.Name = "bankingbtn";
            this.bankingbtn.Size = new System.Drawing.Size(135, 23);
            this.bankingbtn.TabIndex = 3;
            this.bankingbtn.TabStop = true;
            this.bankingbtn.Text = "Online Banking";
            this.bankingbtn.UseVisualStyleBackColor = true;
            // 
            // atmbtn
            // 
            this.atmbtn.AutoSize = true;
            this.atmbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atmbtn.Location = new System.Drawing.Point(259, 273);
            this.atmbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.atmbtn.Name = "atmbtn";
            this.atmbtn.Size = new System.Drawing.Size(159, 23);
            this.atmbtn.TabIndex = 3;
            this.atmbtn.TabStop = true;
            this.atmbtn.Text = "ATM/Cash Deposit";
            this.atmbtn.UseVisualStyleBackColor = true;
            // 
            // instalbtn
            // 
            this.instalbtn.AutoSize = true;
            this.instalbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instalbtn.Location = new System.Drawing.Point(28, 301);
            this.instalbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instalbtn.Name = "instalbtn";
            this.instalbtn.Size = new System.Drawing.Size(189, 23);
            this.instalbtn.TabIndex = 3;
            this.instalbtn.TabStop = true;
            this.instalbtn.Text = "Credit Card Installment";
            this.instalbtn.UseVisualStyleBackColor = true;
            // 
            // cardbtn
            // 
            this.cardbtn.AutoSize = true;
            this.cardbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardbtn.Location = new System.Drawing.Point(259, 299);
            this.cardbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardbtn.Name = "cardbtn";
            this.cardbtn.Size = new System.Drawing.Size(152, 23);
            this.cardbtn.TabIndex = 3;
            this.cardbtn.TabStop = true;
            this.cardbtn.Text = "Credit/Debit Card";
            this.cardbtn.UseVisualStyleBackColor = true;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(396, 352);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(228, 76);
            this.lblShow.TabIndex = 4;
            this.lblShow.Text = "Insurance premium gross total : \r\nSST (6%) :   \r\nStamp Duty :   \r\nTotal Annual Pr" +
    "emium : \r\n";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(564, 442);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 32);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(28, 442);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 32);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblGrosstotal
            // 
            this.lblGrosstotal.AutoSize = true;
            this.lblGrosstotal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrosstotal.Location = new System.Drawing.Point(653, 352);
            this.lblGrosstotal.Name = "lblGrosstotal";
            this.lblGrosstotal.Size = new System.Drawing.Size(36, 19);
            this.lblGrosstotal.TabIndex = 7;
            this.lblGrosstotal.Text = "100";
            // 
            // lblSST
            // 
            this.lblSST.AutoSize = true;
            this.lblSST.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSST.Location = new System.Drawing.Point(662, 372);
            this.lblSST.Name = "lblSST";
            this.lblSST.Size = new System.Drawing.Size(27, 19);
            this.lblSST.TabIndex = 7;
            this.lblSST.Text = "10";
            // 
            // lblStampDuty
            // 
            this.lblStampDuty.AutoSize = true;
            this.lblStampDuty.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStampDuty.Location = new System.Drawing.Point(662, 391);
            this.lblStampDuty.Name = "lblStampDuty";
            this.lblStampDuty.Size = new System.Drawing.Size(27, 19);
            this.lblStampDuty.TabIndex = 7;
            this.lblStampDuty.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(653, 410);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 21);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "100";
            this.lblTotal.Click += new System.EventHandler(this.LblTotal_Click);
            // 
            // lblRM
            // 
            this.lblRM.AutoSize = true;
            this.lblRM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRM.Location = new System.Drawing.Point(602, 352);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(35, 76);
            this.lblRM.TabIndex = 9;
            this.lblRM.Text = "RM\r\nRM\r\nRM\r\nRM";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 512);
            this.ControlBox = false;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStampDuty);
            this.Controls.Add(this.lblSST);
            this.Controls.Add(this.lblGrosstotal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.cardbtn);
            this.Controls.Add(this.instalbtn);
            this.Controls.Add(this.atmbtn);
            this.Controls.Add(this.bankingbtn);
            this.Controls.Add(this.lblPaymentTitle);
            this.Controls.Add(this.checkboxTnC);
            this.Controls.Add(this.grpProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Name | Payment Check Out";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.grpProduct.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.CheckBox checkboxTnC;
        private System.Windows.Forms.Label lblPaymentTitle;
        private System.Windows.Forms.RadioButton bankingbtn;
        private System.Windows.Forms.RadioButton atmbtn;
        private System.Windows.Forms.RadioButton instalbtn;
        private System.Windows.Forms.RadioButton cardbtn;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStampDuty;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblRate;
        public System.Windows.Forms.Label lblTypeFinal;
        public System.Windows.Forms.Label lblDescFinal;
        public System.Windows.Forms.Label lblRateFinal;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblGrosstotal;
        public System.Windows.Forms.Label lblSST;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRM;
    }
}