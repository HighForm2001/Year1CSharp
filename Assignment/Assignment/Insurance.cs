using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment
{
    public class Insurance
    {
        //Properties
        private string custID;
        private double carPrice; //customer insured price
        private double rate; //according insurance selection
        private double insurancePrice; //total amount for the insurance paid
        private string brand;
        private string plate;
        private string policyID;
        private string startDate;
        private string endDate;
        private int period;
        public OleDbConnection connect = new OleDbConnection(); //Creating connection to the database. Modifier set to public to allow outside access
        OleDbCommand command = new OleDbCommand(); //Creating Command Object

        //Constructor
        public Insurance()
        {
            //Assign value
            custID = "";
            carPrice = 0.0;
            rate = 0.0;
            insurancePrice = 0.0;
            brand = "";
            plate = "";
            startDate = DateTime.Now.ToString(); //Get now 
            endDate = DateTime.Parse(startDate).AddYears(1).ToString(); //Get end date of insurance
            period = 0;
            connect.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AssignmentDatabase.mdb;"; //Database pathway
            connect.Open();
        }
        //Properties
        public string ID
        {
            get { return custID; }
            set { custID = value; }
        }

        public double PRICE
        {
            get { return carPrice; }
            set { carPrice = value; }
        }

        public double RATES
        {
            get { return rate; }
            set { rate = value/100; }
        }

        public double TOTAL
        {
            get { return insurancePrice; }
        }
        public string BRAND
        {
            get { return brand; }
            set { brand = value; }
        }
        public string PLATE
        {
            get { return plate; }
            set { plate = value; }
        }
        
        public int PERIOD
        {
            get { return period; }
            set { period = value; }
        }
        public string POLICYID
        {
            get { return policyID; }
        }
        //Method
        public void PurchaseInsurance()
        {
            command.Connection = connect;
            command.CommandText = "SELECT COUNT(*) FROM INSURANCE_T"; //Get total number of policy existed
            OleDbDataReader read = command.ExecuteReader();
            //Ways to get id generator
            if (!read.Read())
                policyID = "P00001";
            else if (int.Parse(read[0].ToString()) < 10)
                policyID = "P0000" + (int.Parse(read[0].ToString()) + 1).ToString();
            else if (int.Parse(read[0].ToString()) < 100)
                policyID = "P000" + (int.Parse(read[0].ToString()) + 1).ToString();
            else if (int.Parse(read[0].ToString()) < 1000)
                policyID = "P00" + (int.Parse(read[0].ToString()) + 1).ToString();
            else if (int.Parse(read[0].ToString()) < 10000)
                policyID = "P0" + (int.Parse(read[0].ToString()) + 1).ToString();
            else
                policyID = "P" + (int.Parse(read[0].ToString()) + 1).ToString();
            read.Close();
            command.CommandText = "INSERT INTO INSURANCE_T Values('" + policyID + "','" + custID + "','" + brand + "','" + plate + "'," + carPrice + "," 
                + insurancePrice + ",'" + startDate + "','" + endDate+"'," + rate + ",0,'" +  startDate + "')";
            command.ExecuteNonQuery();//Insert new registered register data
            command.CommandText = "UPDATE CUSTOMER_T SET policy_quantity = policy_quantity + 1 WHERE customer_ic = '" + custID + "'";
            command.ExecuteNonQuery();//Update customer's total insurance number
        }
        public double TotalAmount()
        {
            insurancePrice += (carPrice * rate);
            insurancePrice *= 1.06;
            insurancePrice += 10;
            return insurancePrice;
        }
    }
}
