namespace WelcomeForm
{
    partial class Welcome
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
            this.purchasebtn = new System.Windows.Forms.Button();
            this.wlcLbl = new System.Windows.Forms.Label();
            this.instrucLbl = new System.Windows.Forms.Label();
            this.checkdetail = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // purchasebtn
            // 
            this.purchasebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasebtn.Location = new System.Drawing.Point(393, 130);
            this.purchasebtn.Name = "purchasebtn";
            this.purchasebtn.Size = new System.Drawing.Size(270, 66);
            this.purchasebtn.TabIndex = 0;
            this.purchasebtn.Text = "Purchase or Renew Insurance";
            this.purchasebtn.UseVisualStyleBackColor = true;
            this.purchasebtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // wlcLbl
            // 
            this.wlcLbl.AutoSize = true;
            this.wlcLbl.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlcLbl.Location = new System.Drawing.Point(33, 22);
            this.wlcLbl.Name = "wlcLbl";
            this.wlcLbl.Size = new System.Drawing.Size(355, 35);
            this.wlcLbl.TabIndex = 1;
            this.wlcLbl.Text = "Welcome! (Username)";
            // 
            // instrucLbl
            // 
            this.instrucLbl.AutoSize = true;
            this.instrucLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrucLbl.Location = new System.Drawing.Point(100, 197);
            this.instrucLbl.Name = "instrucLbl";
            this.instrucLbl.Size = new System.Drawing.Size(206, 23);
            this.instrucLbl.TabIndex = 2;
            this.instrucLbl.Text = "Please select a service:";
            // 
            // checkdetail
            // 
            this.checkdetail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkdetail.Location = new System.Drawing.Point(393, 225);
            this.checkdetail.Name = "checkdetail";
            this.checkdetail.Size = new System.Drawing.Size(270, 66);
            this.checkdetail.TabIndex = 3;
            this.checkdetail.Text = "Seacrh Insurance";
            this.checkdetail.UseVisualStyleBackColor = true;
            this.checkdetail.Click += new System.EventHandler(this.Checkdetail_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(39, 358);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(185, 66);
            this.exit.TabIndex = 4;
            this.exit.Text = "Log out";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.checkdetail);
            this.Controls.Add(this.instrucLbl);
            this.Controls.Add(this.wlcLbl);
            this.Controls.Add(this.purchasebtn);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button purchasebtn;
        private System.Windows.Forms.Label wlcLbl;
        private System.Windows.Forms.Label instrucLbl;
        private System.Windows.Forms.Button checkdetail;
        private System.Windows.Forms.Button exit;
    }
}

