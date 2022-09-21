namespace Assignment
{
    partial class Renew
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
            this.btnRenew = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.policyLbl = new System.Windows.Forms.Label();
            this.policyTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Location = new System.Drawing.Point(233, 154);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(100, 39);
            this.btnRenew.TabIndex = 3;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.BtnRenew_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(55, 47);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(118, 20);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID :";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(179, 38);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 30);
            this.txtID.TabIndex = 0;
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlate.Location = new System.Drawing.Point(49, 72);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(124, 20);
            this.lblPlate.TabIndex = 1;
            this.lblPlate.Text = "Plate Number :";
            // 
            // txtPlate
            // 
            this.txtPlate.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlate.Location = new System.Drawing.Point(179, 69);
            this.txtPlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(154, 30);
            this.txtPlate.TabIndex = 1;
            // 
            // btnBack1
            // 
            this.btnBack1.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.Location = new System.Drawing.Point(30, 154);
            this.btnBack1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(70, 39);
            this.btnBack1.TabIndex = 4;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.BtnBack1_Click);
            // 
            // policyLbl
            // 
            this.policyLbl.AutoSize = true;
            this.policyLbl.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policyLbl.Location = new System.Drawing.Point(86, 101);
            this.policyLbl.Name = "policyLbl";
            this.policyLbl.Size = new System.Drawing.Size(87, 20);
            this.policyLbl.TabIndex = 12;
            this.policyLbl.Text = "Policy ID:";
            // 
            // policyTxtBox
            // 
            this.policyTxtBox.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policyTxtBox.Location = new System.Drawing.Point(179, 101);
            this.policyTxtBox.Name = "policyTxtBox";
            this.policyTxtBox.Size = new System.Drawing.Size(154, 30);
            this.policyTxtBox.TabIndex = 2;
            // 
            // Renew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(368, 220);
            this.ControlBox = false;
            this.Controls.Add(this.policyTxtBox);
            this.Controls.Add(this.policyLbl);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPlate);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnRenew);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Renew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew Insurance";
            this.Load += new System.EventHandler(this.Renew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Label policyLbl;
        private System.Windows.Forms.TextBox policyTxtBox;
    }
}