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

namespace Assignment
{
    public partial class Payment_Renew_ : Form
    {
        //Form Constructor
        public Payment_Renew_()
        {
            InitializeComponent();
        }
        OleDbCommand command = new OleDbCommand(); //Creating Command Object
        OleDbConnection connect = new OleDbConnection(); //Creating Connect Object
        //Properties
        string endDate;
        string policyID;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (checkboxTnC.Checked == true)//Checkbox Validation
            {
                //Radiobutton validation
                if (radiobtn1.Checked)
                {
                    MessageBox.Show("Paid RM " + lblTotal.Text + " with " + radiobtn1.Text + ".");
                    Payment();//Calling method (line:88)
                    this.Close();//Close current Form: Payment(Renew)
                }
                else if (radiobtn2.Checked)
                {
                    MessageBox.Show("Paid RM " + lblTotal.Text + " with " + radiobtn2.Text + ".");
                    Payment();//Calling method (line:88)
                    this.Close();//Close current Form: Payment(Renew)
                }
                else if (radiobtn3.Checked)
                {
                    MessageBox.Show("Paid RM " + lblTotal.Text + " with " + radiobtn3.Text + ".");
                    Payment();//Calling method (line:88)
                    this.Close();//Close current Form: Payment(Renew)

                }
                else if (radiobtn4.Checked)
                {                  
                    MessageBox.Show("Paid RM " + lblTotal.Text + " with " + radiobtn4.Text + ".");
                    Payment();//Calling method (line:88)
                    this.Close();//Close current Form: Payment(Renew)      
                }
                else
                    MessageBox.Show("Please select a payment method.");//Notice user to select payment method
            }
            else
                MessageBox.Show("Please ensure terms and condition have been read.");
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();//Close current Form: Payment(Renew)
        }

        private void Payment_Renew__Load(object sender, EventArgs e)
        {
            connect.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AssignmentDatabase.mdb;";//Database pathway
            connect.Open();//Open Connection
            command.Connection = connect;
        }
        public void PastPolicyID(string policyID)
        {
            this.policyID = policyID;//Assigning policyID
        }
        //Methods
        private string GetEndDate()
        {
            command.CommandText = "SELECT insurance_end_date FROM INSURANCE_T WHERE policy_id = '" + policyID + "'";
            OleDbDataReader read = command.ExecuteReader();
            read.Read();
            string year = DateTime.Parse(read[0].ToString()).AddYears(1).ToString();
            read.Close();
            return year;
        }
        private void Payment()
        {
            endDate = GetEndDate();
            command.CommandText = "UPDATE INSURANCE_T SET insurance_end_date = '" + endDate + "' WHERE policy_id = '" + policyID + "'";
            command.ExecuteNonQuery();//Update new insurance end date
            connect.Close();//Closing connection to avoid error 
            MessageBox.Show("Insurance ID: " + policyID + "\nDear customer, your has successfully renewed your insurance.\nNew Expired Date: " + DateTime.Parse(endDate).ToString("dddd,dd MMMM yyyy"));
            //Renew successful tips
        }
    }
}
