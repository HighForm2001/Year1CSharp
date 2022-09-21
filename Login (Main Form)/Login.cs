using System.Data.OleDb;
using Forgot_Password;
using RegistrationPage;
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
using WelcomeForm;
using System.Collections;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics.PerformanceData;
using EditForm;

namespace LoginPage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Initialize Objects
        OleDbConnection connect = new  OleDbConnection(); //Connection to Database
        OleDbCommand command = new OleDbCommand(); //Command to Database



        private void Label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Renew();//Call method (line: 113)
            command.CommandText = "SELECT * FROM CUSTOMER_T WHERE customer_name = '" + nameTxtBox.Text + "'";
            OleDbDataReader read = command.ExecuteReader();//Load customer name to do validation
            //Input Validation
            if ((nameTxtBox.Text.Trim() == "") || (pwdTextBox.Text.Trim() == ""))
            {
                MessageBox.Show("Please fill in Username and Password");
                read.Close();
            }
            else if((nameTxtBox.Text == "Employee Account") && (pwdTextBox.Text == "EMP"))//Edit Form Validation
            {
                Edit edit = new Edit();//Create Object: Edit Form
                this.Hide();
                edit.ShowDialog();//Show Edit Form
                this.Show();
            }
            else
            {
                if (!read.Read())
                {
                    MessageBox.Show("Customer name not found");
                    read.Close();
                }
                else
                { 
                    if (pwdTextBox.Text.Equals(read[5]))
                    {
                        this.Hide();
                        Welcome welcome = new Welcome(); //Create Object: Welcome Form
                        welcome.SetLabel(read[1].ToString());
                        welcome.SetID(read[0].ToString());//Assign value to be displayed in Welcome Form
                        read.Close();
                        welcome.ShowDialog();//Show Welcome Form
                        this.Show();
                    }
                    else
                        MessageBox.Show("Password Incorrect!");
                }          
            }
            read.Close();           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Registration register = new Registration(); //Create Object: Registration Form
            register.ShowDialog();//Show Registration Form
            this.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {            
            this.Hide();
            forgotForm forgot = new forgotForm(); //Create Object: Forgot Form
            forgot.ShowDialog();//Show Forgot Form
            this.Show();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AssignmentDatabase.mdb;";
            connect.Open();
            command.Connection = connect;
        }
        //Method
        private void Renew()
        {
            command.CommandText = "SELECT COUNT(*) FROM INSURANCE_T";//Count total insurance available to get Array Size
            OleDbDataReader read = command.ExecuteReader();
            DateTime now = DateTime.Now;
            if (read.Read())
            {
                int count = int.Parse(read[0].ToString());//get size
                read.Close();
                if (count > 0)
                {
                    int year = 0;
                    int days;
                    TimeSpan ts;
                    string[] yearPeriod = new string[count];
                    command.CommandText = "SELECT insurance_claim_date FROM INSURANCE_T";
                    read = command.ExecuteReader();
                    if (read.Read())
                    {
                        for (int i = 0; i < yearPeriod.Length; i++)
                        {
                            yearPeriod[i] = read[0].ToString();
                            read.Read();//next row
                        }
                        read.Close();
                        for (int i = 0; i < yearPeriod.Length; i++)
                        {
                            ts = DateTime.Now - DateTime.Parse(yearPeriod[i]);
                            days = ts.Days;
                            while(days >= 365)
                            {
                                year++;
                                days -= 365;
                            }
                            command.CommandText = "UPDATE INSURANCE_T SET insurance_claim_free_period = " + year + " WHERE insurance_claim_date = '" + yearPeriod[i] + "'";
                            command.ExecuteNonQuery();//Update insurance_claim_free_period
                            year = 0;
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pwdTextBox.UseSystemPasswordChar != true)
                pwdTextBox.UseSystemPasswordChar = true;
            else
                pwdTextBox.UseSystemPasswordChar = false;
        }
    }
}
