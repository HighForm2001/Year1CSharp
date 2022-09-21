using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment
{
    public class Car
    {
        private string plateNumber;
        private int productionYear;
        private string color;
        private string manufacturer; //Class template
        public OleDbConnection connect = new OleDbConnection(); //linking connection to database. using public modifier to get access from other form
        OleDbCommand command = new OleDbCommand(); //creating command class
        //constructor
        public Car(string plateNumber, int productionYear, string color, string manufacturer) 
        {
            command.Connection = connect;
            connect.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AssignmentDatabase.mdb;";
            connect.Open();
            this.plateNumber = plateNumber;
            this.productionYear = productionYear;
            this.color = color;
            this.manufacturer = manufacturer;

        }

        //property
        public string PLATE
        {
            get { return plateNumber; }
            set { plateNumber = value; }
        }

        public int YEAR
        {
            get{ return productionYear; }
            set{ productionYear = value; }
        }

        public string COLOR
        {
            get { return color; }
            set { color = value; }
        }

        public string MAKE
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        //Method
        public void Register()
        {
            command.CommandText = "INSERT INTO CAR_T VALUES('" + plateNumber + "'," + productionYear + ",'" + color + "','" + manufacturer + "')" ; 
            command.ExecuteNonQuery();
            //Insert new registered record into database
        }
    }
}
