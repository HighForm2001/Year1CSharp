using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Choose : Form
    {
        
        public Choose(string ID)  //constructor
        {
            InitializeComponent();
            customerID = ID;
        }
        string customerID; //getting value from "Welcome" form
        private void BtnApply_Click(object sender, EventArgs e)
        {
            //Selection from radiobutton
            if (radiobtn1.Checked)
            {
                Apply insurance = new Apply();
                insurance.SetIC(customerID);
                this.Hide();
                insurance.ShowDialog();
                this.Close();
            }
            else if (radiobtn2.Checked)
            {
                Renew insurance = new Renew();
                this.Hide();
                insurance.ShowDialog();
                this.Close();
            }
            //Radiobutton validation
            else
            {
                MessageBox.Show("Please select an action.");
            }
        }

        private void Insurance_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnBack1_Click(object sender, EventArgs e)
        {
            this.Close();//Closing current form: Choose form
        }
    }
}
