using Assignment;
using Searching;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomeForm
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        //Properties
        string custID;
        private void Button1_Click(object sender, EventArgs e)
        {
            Choose choose = new Choose(custID);//Create Form: Choose and pass custID to the next form
            this.Hide();
            choose.ShowDialog();//Show form: Choose Form
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();//Close current Form: Welcome Form
        }

        private void Checkdetail_Click(object sender, EventArgs e)
        {
            Check check = new Check();//Create Form: Check form
            this.Hide();
            check.ShowDialog();//Show form: Check Form
            this.Show();
        }
        public void SetLabel(string name)
        {
            wlcLbl.Text = "Welcome! " + name;
        }
        public void SetID (string IDNumber)
        {
            this.custID = IDNumber;
            wlcLbl.Text += "\nID: " + IDNumber;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
