using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Searching
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection();//Create Object: Connect
        OleDbCommand command = new OleDbCommand();//Create Object: Command
        private int count;
        private void Check_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AssignmentDatabase.mdb;";//Database Pathway
            connect.Open();
            command.Connection = connect; //Enable Connection
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            connect.Close();//Close connectio before closing form
            this.Close();//Close current Form: Check Form
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;//Get object: DateTime
            command.Connection = connect;
            //ComboBox Validation
            if (chooseCombo.SelectedIndex == 0)
                if (numberTxtBox.Text.Trim() == "")//TextBox Validation
                    MessageBox.Show("Please fill in your policy number.");
                else
                    SearchPolicy(now);//Call method (line: 69) with Parameter DateTime
            else if (chooseCombo.SelectedIndex == 1)
                if (numberTxtBox.Text.Trim() == "")//TextBox Validation
                    MessageBox.Show("Please fill in your ID number.");
                else
                    searchIC(now);//Call method (line: 84) with Parameter DataTime
            else
                MessageBox.Show("Please select either to fill in Policy Number or fill in ID Number");
        }
        //Methods
        private void NCD(int years)
        {
            if (years == 0)
                entitlementLbl.Text = "0%";
            else if (years < 2)
                entitlementLbl.Text = "25%";
            else if (years < 3)
                entitlementLbl.Text = "30%";
            else if (years < 4)
                entitlementLbl.Text = "38.33%";
            else if (years < 5)
                entitlementLbl.Text = "45%";
            else
                entitlementLbl.Text = "55%";//Discount based on Non claim period(year)
        }
        private void SearchPolicy(DateTime now)
        {
            command.CommandText = "SELECT * FROM CUSTOMER_T c, INSURANCE_T i WHERE ((c.customer_ic = i.customer_ic) and (i.policy_id = '" + numberTxtBox.Text.ToUpper() + "'))";
            OleDbDataReader read = command.ExecuteReader();//Load records
            if (!read.Read())
            {
                MessageBox.Show("Record not found.");
            }
            else
            {
                ShowRecord(read, now);//Call method (line: 119) with Parameter OleDbDataReader and DateTime
                ShowVisible();//Call method (line: 137)
            }
            read.Close();//Close read
        }
        private void searchIC(DateTime now)
        {
            command.CommandText = "SELECT COUNT(*) FROM INSURANCE_T WHERE customer_ic = '" + numberTxtBox.Text + "'";//Get total number of insurance customer owns
            OleDbDataReader read = command.ExecuteReader();
            if (read.Read())
            {
                count = int.Parse(read[0].ToString());
                read.Close();
                if (count >= 1)
                {
                    command.CommandText = "SELECT * FROM CUSTOMER_T c, INSURANCE_T i WHERE ((c.customer_ic = i.customer_ic) and (c.customer_ic = '" + numberTxtBox.Text + "'))";
                    read = command.ExecuteReader();
                    ShowVisible();//Call method (line: 137)
                    if (count == 1)
                    {
                        read.Read();//go to the new row
                        ShowRecord(read, now);//Call method (line: 119) with Parameter OleDbDataReader and DateTime
                    }
                    if(count > 1)
                    {
                        while (read.Read())
                        {
                            ShowRecord(read, now);//Call method (line: 119) with Parameter OleDbDataReader and DateTime
                            MessageBox.Show("Click me after finish checking this current insurance details");
                        }
                    }  
                    read.Close();
                }
                else
                    MessageBox.Show("Record not found.");       
            }       
        }
        private void ShowRecord(OleDbDataReader read,DateTime now)
        {
            TimeSpan ts = DateTime.Parse(read[14].ToString()) - now;
            //Get days after of before expired date
            nameLbl.Text = "Username: " + read[1].ToString();
            ICLbl.Text = "IC Number: " + read[0].ToString();
            policyNoLbl.Text = read[7].ToString();
            carModelLbl.Text = read[9].ToString();
            plateNoLbl.Text = read[10].ToString();
            freePeriodLbl.Text = read[16].ToString() + "years";
            NCD(int.Parse(read[16].ToString()));//Call method (line: 55);
            if (ts.Days >= 0)
                expLbl.Text = "Expire after " + ts.Days.ToString() + " day(s)";//Assign different value based on the days
            else
                expLbl.Text = "Expired " + (-ts.Days).ToString() + " day(s)";
                
        }        
        private void ShowVisible()
        {
            policyNoLbl.Visible = true;//Make labels visible
            carModelLbl.Visible = true;
            plateNoLbl.Visible = true;
            freePeriodLbl.Visible = true;
            entitlementLbl.Visible = true;
        }
    }
}
