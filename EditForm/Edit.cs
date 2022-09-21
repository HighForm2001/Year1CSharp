
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EditForm
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }
        OleDbCommand command = new OleDbCommand();
        OleDbConnection connect = new OleDbConnection();
        
        private void Edit_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AssignmentDatabase.mdb;";//Database Pathway
            connect.Open();
            command.Connection = connect;
            command.CommandText = "SELECT customer_ic FROM CUSTOMER_T";//Search all customer ID from database
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
                custBox.Items.Add(reader[0].ToString()); //Load all customer ID into comboBox
            reader.Close();//Close reader
        }
        //Method
        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            //ComboBox validation
            if (custBox.SelectedIndex == -1)
                MessageBox.Show("Please select a customer ID");
            else
            {
                command.CommandText = "SELECT * FROM CUSTOMER_T WHERE customer_ic = '" + custBox.SelectedItem.ToString() + "'";//Load customer details using selected ID
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                custName.Text = reader[1].ToString();
                custIC.Text = reader[0].ToString();
                custName.Visible = true;
                custIC.Visible = true;//Make label visible
                insuranceGroupBox.Visible = true;//Make another group box available
                addTextBox.Text = reader[3].ToString();
                contactTxt.Text = reader[4].ToString();
                emailBox.Text = reader[2].ToString();
                pwdTxt.Text = reader[5].ToString();
                reader.Close();//Close reader
                LoadCustomerInsurance();//Calling method (line: 80)
            } 
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if ((emailBox.Text.Trim() == "") || (addTextBox.Text.Trim() == "") || (contactTxt.Text.Trim() == "") || (pwdTxt.Text.Trim() == ""))
                MessageBox.Show("Please fill in all details");
            else
            {
                if (contactTxt.Text.Length > 13)// Input Validation
                    MessageBox.Show("Contact number should not be longer than 13 characters");
                else if (!long.TryParse(contactTxt.Text, out long tryOnly))
                    MessageBox.Show("Contact number should only contains numeric characters");
                else if (pwdTxt.Text.Length < 8)
                    MessageBox.Show("Password must be at least 8 characters");
                else if (!emailBox.Text.Contains("@") || (!emailBox.Text.Contains(".")))
                    MessageBox.Show("Email format incorrect!");
                else
                {
                    command.CommandText = "UPDATE CUSTOMER_T SET customer_address = '" + addTextBox.Text +
                        "', customer_contact = '" + contactTxt.Text + "', customer_password = '" + pwdTxt.Text + "', customer_email = '" 
                        + emailBox.Text + "' WHERE customer_ic = '" + custIC.Text + "'";
                    command.ExecuteNonQuery();//Update customer details
                    MessageBox.Show("Changes Saved");
                    MessageBox.Show("Please check data.\nCustomer Name\t: " + custName.Text + "\nCustomer ID\t: " + custIC.Text+ 
                        "\nCustomer email\t: " + emailBox.Text + "\nCustomer Contact\t: " + contactTxt.Text + "\nCustomer Password\t: " + pwdTxt.Text
                        + "\nCustomer Address\t: \n" + addTextBox.Text);
                }
            }
            



        }
        private void Back_Click(object sender, EventArgs e)
        {
            connect.Close();//Close Connection
            this.Close();//Close current Form: Edit Form
        }
        private void LoadCustomerInsurance()
        {
            insuranceBox.Items.Clear();
            command.CommandText = "SELECT policy_id FROM INSURANCE_T WHERE customer_ic = '" + custBox.SelectedItem.ToString() + "'";//Load customer's all insurances
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
                insuranceBox.Items.Add(reader[0].ToString());//Load all insurance policy id into comboBox
            reader.Close();//close reader
        }

        private void Claimbtn_Click(object sender, EventArgs e)
        {
            //ComboBox validation
            if (insuranceBox.SelectedIndex == -1)
                MessageBox.Show("Please select an insurance policy ID to claim.\nIf do not find any, the customer has nout bought any insurance yet.");
            else
            {
                DateTime nowDate = DateTime.Now;
                string now = nowDate.ToString();
                command.CommandText = "SELECT insurance_end_date FROM INSURANCE_T WHERE policy_id = '" + insuranceBox.SelectedItem.ToString() + "'";
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                DateTime endDate = DateTime.Parse(reader[0].ToString());
                reader.Close();
                TimeSpan ts = endDate - nowDate;
                if (ts.Days >= 0)
                {
                    command.CommandText = "UPDATE INSURANCE_T SET insurance_claim_date = '" + now + "', insurance_claim_free_period = 0 WHERE policy_id = '" + insuranceBox.SelectedItem.ToString() + "'";
                    command.ExecuteNonQuery();//Update Claim Date
                    MessageBox.Show("Customer ID: " + custBox.SelectedItem.ToString() + "\nCustomer Name: " + custName.Text + "\nInsurance Policy ID: " + insuranceBox.SelectedItem.ToString() +
                        "\nInsurance has been claimed\nClaim Date: " + DateTime.Now.ToString("dddd, dd MMMM yyyy") + "\nNon Claim Period is 0 years now");
                    //Tips to tell employee insurance claimed
                }
                else
                    MessageBox.Show("Seems the customer's insurance had expired. Claim failed.\nExpired Date: " + endDate.ToString("dddd, d MMM yyyy") + "\nExpired days: " + (-ts.Days).ToString());
                
                

            }
        }

        private void eyeBox_Click(object sender, EventArgs e)
        {
            if (pwdTxt.UseSystemPasswordChar == true)
                pwdTxt.UseSystemPasswordChar = false;
            else
                pwdTxt.UseSystemPasswordChar = true;
        }
    }
}
