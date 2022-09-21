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
    public partial class Payment : Form
    {
        //Form Constructor
        public Payment(Car car, Insurance insurance)
        {
            InitializeComponent();
            this.car = car;
            this.insurance = insurance;
        }
        //Properties
        Car car;
        Insurance insurance;
        OleDbConnection connect = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            connect.Open();
            //Checkbox Validation
            if (checkboxTnC.Checked == true)
            {
                command.Connection = connect;
                command.CommandText = "Select car_plate_number FROM CAR_T WHERE car_plate_number = '" + car.PLATE + "'";//
                OleDbDataReader read = command.ExecuteReader();
                if (read.Read())//Show customer that current care is registered
                    MessageBox.Show("Car Model: " + car.MAKE + "\nPlate Number: "+ car.PLATE + "\nYour car has already registered an Insurance. Failed to purchase insurance");
                else
                {
                    if (bankingbtn.Checked)//Radiobutton validation
                    {
                        MessageBox.Show("Paid RM " + lblTotal.Text + " with " + bankingbtn.Text + ".");
                        FinishUp();//Calling methods (line: 94)
                    }
                    else if (atmbtn.Checked)
                    {
                        MessageBox.Show("Paid RM " + lblTotal.Text + " with " + atmbtn.Text + ".");
                        FinishUp();//Calling methods (line: 94)
                    }
                    else if (instalbtn.Checked)
                    {
                        MessageBox.Show("Paid RM " + lblTotal.Text + " with " + instalbtn.Text + ".");
                        FinishUp(); //Calling methods (line: 94)    
                    }
                    else if (cardbtn.Checked)
                    {
                        MessageBox.Show("Paid RM " + lblTotal.Text + " with " + cardbtn.Text + ".");
                        FinishUp();//Calling methods (line: 94)
                    }
                    else//Tips to ask user to select payment method
                        MessageBox.Show("Please select a payment method.");
                }
            }
            else
            {
                MessageBox.Show("Please ensure terms and condition have been read.");
            }
            connect.Close();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {  
            this.Close();
        }
        private void RegisterCar()
        {
            car.Register();//Call method in Car class
            car.connect.Close();//Closing connection in Car class
        }
        private void RegisterInsurance()
        {
            insurance.PurchaseInsurance();//Call method in Insurance class
            insurance.connect.Close();//closing connection in Insurance class
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = connect.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AssignmentDatabase.mdb;";//Database pathway
        }
        private void FinishUp()
        {
            RegisterCar();//Calling method (line: 78)
            RegisterInsurance();//Calling method (line: 83)
            MessageBox.Show("Your Policy Number for Car " + insurance.PLATE + " is " + insurance.POLICYID + "!\nPlease record.\nIf you forgot you can search it in our searching system");
            //Tips to show insurance registered successful
            this.Close();//Closing current form: Payment form
        }

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
