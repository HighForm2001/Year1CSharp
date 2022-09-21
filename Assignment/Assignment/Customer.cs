using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Assignment
{
    public class Customer
    {
        //Properties
        private string custID;
        private string custname;
        private string contact;
        private string address;
        private string password;
        private string email;

        public OleDbConnection connect = new OleDbConnection(); //Creating connection with database. Publie modifier to allow outside access
        OleDbCommand command = new OleDbCommand(); //Creating Command Object
        
        //Constructor
        public Customer(string custID, string custName, string contact, string address, string password,string email)
        {
            this.custID = custID;
            this.custname = custName;
            this.contact = contact;
            this.address = address;
            this.password = password;
            this.email = email;
            connect.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AssignmentDatabase.mdb;";
            connect.Open(); //Open connection
        }
        //Method
        public void Register()
        {
            command.CommandText = "Insert INTO CUSTOMER_T VALUES('" + custID + "', '" + custname + "','" + email + "','" + address + "','" + contact + "','" + password + "',0)";
            command.Connection = connect;
            command.ExecuteNonQuery();//Insert new registered customer to the database
            MessageBox.Show("Account registered!");
            MessageBox.Show("Customer ID: " + custID + "\nCustomer Name: " + custname + "\nContact number: " 
                + contact + "\nEmail: " +email + "\nAddress: \n" + address + "\nPassword: " + password + "\nAny problem please contact to " +
                "our employee.\nThank you for your registration.");
            //Showing data recorded to the customer
        }
    }
}
