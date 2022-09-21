using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forgot_Password
{
    public partial class forgotForm : Form
    {
        public forgotForm()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();

        private void Button1_Click(object sender, EventArgs e)
        {
            //Input Validation
            if ((nameTxtBox.Text.Trim() == "") || (icTxtBox.Text.Trim() == "") || (newPwdTxtBox.Text.Trim() == "") || (newPwdTxtBox2.Text.Trim() == ""))
                MessageBox.Show("Please fill in all details");
            else if ((newPwdTxtBox.Text.Length < 8) || (newPwdTxtBox2.Text.Length < 8))
                MessageBox.Show("Password must include at least 8 characters");
            else if (!newPwdTxtBox.Text.Equals(newPwdTxtBox2.Text))
                MessageBox.Show("Please confirm your password again, it is different");
            else
                RenewPassword();//Call method (line: 51)
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ForgotForm_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AssignmentDatabase.mdb;";//Database Pathway
            connect.Open();//Open Connection
        }
        //Method
        private void RenewPassword()
        {
            command.CommandText = "Select customer_name FROM CUSTOMER_T WHERE customer_ic = '" + icTxtBox.Text + "'";//Load ID and do validation
            command.Connection = connect;
            OleDbDataReader read = command.ExecuteReader();
            if (!read.Read())
            {
                MessageBox.Show("Customer not found. Please Register!");
                read.Close();
            }
                
            else
            {
                if ((!read[0].ToString().Equals(nameTxtBox.Text)))
                    MessageBox.Show("Customer name incorrect");
                else
                {
                    read.Close();
                    command.CommandText = "UPDATE CUSTOMER_T SET customer_password = '" + newPwdTxtBox.Text + "' WHERE customer_ic = '" + icTxtBox.Text + "'";
                    command.ExecuteNonQuery();//Update Customer Password
                    MessageBox.Show("Password Renew Successful!");
                    connect.Close();//Close database connection
                    this.Close();//Close current Form: Forgot Form
                }
            }
        }

        private void EyeBox_Click(object sender, EventArgs e)
        {
            if (newPwdTxtBox.UseSystemPasswordChar == true)
                newPwdTxtBox.UseSystemPasswordChar = false;
            else
                newPwdTxtBox.UseSystemPasswordChar = true;
        }

        private void EyeBox2_Click(object sender, EventArgs e)
        {
            if (newPwdTxtBox2.UseSystemPasswordChar == true)
                newPwdTxtBox2.UseSystemPasswordChar = false;
            else
                newPwdTxtBox2.UseSystemPasswordChar = true;
        }
    }
}
