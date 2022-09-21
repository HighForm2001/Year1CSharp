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
    public partial class Renew : Form
    {
        OleDbConnection connect = new OleDbConnection(); //Creating Object: Connect
        OleDbCommand command = new OleDbCommand();//Creating Object: Command
        //Properties
        private double discount;
        private int year;
        private int day; //storing days remained until expired date or expired days
        
        //Form Constructor
        public Renew()
        {
            InitializeComponent();
        }

        private void BtnBack1_Click(object sender, EventArgs e)
        {
            this.Close();//Close current form: Renew Form
        }

        private void BtnRenew_Click(object sender, EventArgs e)
        {
            connect.Open();//Open Connection
            DateTime now = DateTime.Now;//Getting DateTime type object
            if (txtID.Text.Trim() == "")//Text box input validation
                MessageBox.Show("Please enter your customer IC.");
            else if (txtPlate.Text.Trim() == "")
                MessageBox.Show("Please enter your Plate Number.");
            else if (policyTxtBox.Text.Trim() == "")
                MessageBox.Show("Please enter your Policy ID.");
            else
            {
                command.CommandText = "SELECT * FROM INSURANCE_T WHERE ( ( customer_ic = '" + txtID.Text + "') and ( car_plate_number = '" + txtPlate.Text.ToUpper() + "') and ( policy_id = '" + policyTxtBox.Text.ToUpper() + "') )";
                command.Connection = connect;
                OleDbDataReader read = command.ExecuteReader();//Search records
                if (read.Read())
                {
                    TimeSpan ts =   DateTime.Parse(read[7].ToString()) - now;
                    day = ts.Days;
                    if (day > 60)
                        MessageBox.Show("You can only renew the insurance 60 days in advance, currently: " + day + " days");//Renewal validation
                    else if (day < 0)
                        MessageBox.Show("Insurance Policy ID: " + policyTxtBox.Text.ToUpper() + " has expired for " + (-day) + " days.\nInsurance expired date: " + DateTime.Parse(read[7].ToString()).ToString("dddd, d MMMM YYYY"));
                    else
                    {
                        Payment_Renew_ pay = new Payment_Renew_();//Creating Form: Payment_Renew_ Form
                        Apply apply = new Apply();//Creating Apply form to retrieve data
                        if (double.Parse(read[8].ToString()) == 0.0266)
                        {
                            pay.lblDescFinal.Text = apply.lblDesc1.Text;//Assigning new value to display in Payment_Renew Form
                            pay.lblRateFinal.Text = apply.lblRate1.Text;
                            pay.lblTypeFinal.Text = apply.lblType1.Text;
                            Proceed(read, pay);//Calling methods (line: 123) with parameters Object OleDbDataReader and Object Payment_Renew_
                        }
                        else if (double.Parse(read[8].ToString()) == 0.0275)
                        {
                            pay.lblDescFinal.Text = apply.lblDesc2.Text;//Assigning new value to display in Payment_Renew Form
                            pay.lblRateFinal.Text = apply.lblRate2.Text;
                            pay.lblTypeFinal.Text = apply.lblType2.Text;
                            Proceed(read, pay);//Calling methods (line: 123) with parameters Object OleDbDataReader and Object Payment_Renew_
                        }
                        else if (double.Parse(read[8].ToString()) == 0.0284)
                        {
                            pay.lblDescFinal.Text = apply.lblDesc3.Text;//Assigning new value to display in Payment_Renew Form
                            pay.lblRateFinal.Text = apply.lblRate3.Text;
                            pay.lblTypeFinal.Text = apply.lblType3.Text;
                            Proceed(read, pay);//Calling methods (line: 123) with parameters Object OleDbDataReader and Object Payment_Renew_
                        }
                    }
                    read.Close();//Close reeading stream
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    read.Close();
                }
                connect.Close();//Close connection to avoid errors
            }
        }
        
 
        private void Calculate(OleDbDataReader read, Payment_Renew_ pay)
        {
            year = int.Parse(read[9].ToString());
            //Assigning different discount value to base on the year
            if (year >= 5)
                discount = 0.55;
            else if (year >= 4)
                discount = 0.45;
            else if (year >= 3)
                discount = 0.3833;
            else if (year >= 2)
                discount = 0.3;
            else if (year > 0)
                discount = 0.25;
            else
                discount = 0;    
            //Assigning values to display in Payement_Renew_ form
            pay.lblGrosstotal.Text = (double.Parse(pay.lblGrosstotal.Text) / 100 * double.Parse(read[5].ToString())).ToString("f2");
            pay.lblNCD.Text =(double.Parse(pay.lblGrosstotal.Text) * discount).ToString("f2");
            pay.lblSST.Text = (double.Parse(pay.lblGrosstotal.Text) * 6 / 100).ToString("f2");
            pay.lblTotal.Text = (double.Parse(pay.lblGrosstotal.Text) + double.Parse(pay.lblSST.Text) - double.Parse(pay.lblNCD.Text) + 10).ToString("f2");
            pay.lblNCD.Text = "(" + pay.lblNCD.Text + ")";
        }

        private void Renew_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = connect.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AssignmentDatabase.mdb;";
            
        }
        private void Proceed(OleDbDataReader read, Payment_Renew_ pay)
        {
            Calculate(read, pay);//Calling methods (line: 95) with parameters Object OleDbDataReader and Object Payment_Renew_
            pay.PastPolicyID(read[0].ToString());//Passing policy ID to Payment_Renew_ form
            read.Close();
            this.Hide();//Hide current Form: Renew Form
            connect.Close();//Close connection with Database
            pay.ShowDialog();//Showing Payment_Renew_ form
            this.Close();//Close current Form: Renew Form
        }

    }      
}
