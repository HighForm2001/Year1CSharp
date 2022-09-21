using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment;

namespace RegistrationPage
{
    public partial class Registration : Form
    {
        //Constructor
        public Registration()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection();//Create Object: Connect
        OleDbCommand command = new OleDbCommand();//Create Object: Command
        
        private void Label2_Click(object sender, EventArgs e)
        {
        }
        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            command.Connection = connect;
            //input validation
            if ((nameTxtBox.Text.Trim() == "") || (icTextBox.Text.Trim() == "") || (addTxtBox.Text.Trim() == "") || (contactTxtBox.Text.Trim() == "") || (pwdTxtBox.Text.Trim() == "")||(emailBox.Text.Trim() ==""))
            {
                MessageBox.Show("Please fill in all details.");
            }
            else
            {
                //Input Validation
                if (icTextBox.Text.Length != 12)
                    MessageBox.Show("IC Number should include 12 characters");
                else if (!long.TryParse(icTextBox.Text, out long trying))
                    MessageBox.Show("IC Number should only includes numeric characters");
                else if (contactTxtBox.Text.Length > 13)
                    MessageBox.Show("Contact number should not be longer than 13 characters");
                else if (!long.TryParse(contactTxtBox.Text, out long trying2))
                    MessageBox.Show("Contact number should only includes numeric characters");
                else if (pwdTxtBox.Text.Length < 8)
                    MessageBox.Show("Password should be more than 8 characters");
                else if (!emailBox.Text.Contains("@") || (!emailBox.Text.Contains(".")))
                    MessageBox.Show("Email format incorrect");
                else
                {
                    //Input Validation
                    if (!long.TryParse(icTextBox.Text, out long ic))
                        MessageBox.Show("IC should only include numbers");
                    else if (!long.TryParse(contactTxtBox.Text, out long contact))
                        MessageBox.Show("Contact number should only include numbers");
                    else
                    {
                        command.CommandText = "Select * FROM CUSTOMER_T WHERE customer_ic = '" + icTextBox.Text + "'";//Check if account existed
                        OleDbDataReader read = command.ExecuteReader();
                        if (read.Read())
                        {
                            MessageBox.Show("Account existed! Registration failed");
                            read.Close();
                        }
                        else
                        {
                            read.Close();
                            Customer customer = new Customer(icTextBox.Text, nameTxtBox.Text, contactTxtBox.Text, addTxtBox.Text, pwdTxtBox.Text,emailBox.Text);
                            customer.Register();//Call Customer Class Method
                            customer.connect.Close();//Close Customer Class Connection with Database
                            connect.Close();//Close Connection with Database
                            this.Close();//Close current Form: Registration Form
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AssignmentDatabase.mdb;";//Database Pathway
            connect.Open();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            connect.Close();
            this.Close();//Close current Form: Registration Form
        }

        private void eyeBox_Click(object sender, EventArgs e)
        {
            if (pwdTxtBox.UseSystemPasswordChar == true)
                pwdTxtBox.UseSystemPasswordChar = false;
            else
                pwdTxtBox.UseSystemPasswordChar = true;
        }
    }
}
