using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Apply : Form
    {
        public Apply()
        {
            InitializeComponent();
        }
        string ID;
        private void proceedBtn_Click(object sender, EventArgs e)
        {
            char[] notAllowedCharacters = { '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=', '\\', '|', '}', ']', '{', '[', '"', '\'', ';', ':', '/', '?', '.', '>', '<', ',' };
            Boolean flag = false;
            char characterAppeared = ' ';
            for (int i = 0; i < notAllowedCharacters.Length; i++)
            {
                if (plateTxt.Text.Contains(notAllowedCharacters[i]))
                {
                    flag = true;
                    characterAppeared = notAllowedCharacters[i];
                    break;
                }
            }
            if (flag)
                MessageBox.Show("Car Plate number should only include alphanumerics\nIllegal character: " + characterAppeared.ToString());
            else
            {
                if (txtCarPrice.Text.Trim() == "")
                    MessageBox.Show("Please enter a value.");
                else if (brandTxt.Text.Trim() == "")
                    MessageBox.Show("Please enter Car Brand.");
                else if (plateTxt.Text.Trim() == "")
                    MessageBox.Show("Please enter Car Plate Number");
                else if (plateTxt.Text.Contains(" "))
                    MessageBox.Show("Please delete the space of Car Plate Number");
                else if (colorBox.Text.Trim() == "")
                    MessageBox.Show("Please enter Car Color.");
                else if (yearBox.Text.Trim() == "")
                    MessageBox.Show("Please enter production year.");
                else if (!int.TryParse(yearBox.Text, out int year))
                    MessageBox.Show("Year should includes numeric only");
                else if (int.Parse(yearBox.Text) < (DateTime.Now.Year - 10))
                    MessageBox.Show("Vehicle is not available to register insurance after 10 years");
                else if (int.Parse(yearBox.Text) > DateTime.Now.Year)
                    MessageBox.Show("No future production year is allowed here.");//Validating input string from 22 to 39 line
                else
                {
                    if (double.TryParse(txtCarPrice.Text, out double price)) //Price validation, if cannot parse into double, means input includes string character
                    {
                        if (firstRadioBtn.Checked)//Check the radioButton to confirm insurance type selected
                            PurchaseInsurance(double.Parse(lblRate1.Text), price, 1); //calling methods (line:62)
                        else if (secondRadioBtn.Checked)
                            PurchaseInsurance(double.Parse(lblRate2.Text), price, 2);
                        else if (thirdRadioBtn.Checked)
                            PurchaseInsurance(double.Parse(lblRate3.Text), price, 3);
                        else
                            MessageBox.Show("Please select an insurance.");
                    }
                    else
                        MessageBox.Show("Car price should be numeric");
                }
            }
            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //Closing form
        }
        private void PurchaseInsurance(double rates, double price, int selection)
        {

            Insurance insurance = new Insurance(); //Create Object: Insurance
            Car car = RegisterCar();//Create methods creating object (lines:98)
            insurance.PRICE = price;//Assigning value to the properties of Insurance Object
            insurance.RATES = rates;
            insurance.BRAND = brandTxt.Text.ToUpper();
            insurance.PLATE = plateTxt.Text.ToUpper();
            insurance.ID = ID;
            Payment pay = new Payment(car, insurance);//Creating Payment Form
            if (selection == 1)//Assigning different value to display in the form based on the selection.
            {
                pay.lblDescFinal.Text = lblDesc1.Text;
                pay.lblRateFinal.Text = lblRate1.Text;
                pay.lblTypeFinal.Text = lblType1.Text;
            }
            else if (selection == 2)
            {
                pay.lblDescFinal.Text = lblDesc2.Text;
                pay.lblRateFinal.Text = lblRate2.Text;
                pay.lblTypeFinal.Text = lblType2.Text;
            }
            else
            {
                pay.lblDescFinal.Text = lblDesc3.Text;
                pay.lblRateFinal.Text = lblRate3.Text;
                pay.lblTypeFinal.Text = lblType3.Text;
            }

            pay.lblGrosstotal.Text = (insurance.RATES * insurance.PRICE).ToString("f2"); //Assigning the common value to display in the form
            pay.lblSST.Text = (double.Parse(pay.lblGrosstotal.Text) * 6 / 100).ToString("f2");
            pay.lblTotal.Text = insurance.TotalAmount().ToString("f2");
            this.Hide(); //Hiding current form
            pay.ShowDialog(); //Showing Payment form with correct details
        }
        private Car RegisterCar()
        {
            Car newcar = new Car(plateTxt.Text.ToUpper(), int.Parse(yearBox.Text), colorBox.Text.ToUpper(), brandTxt.Text.ToUpper());
            //Creating object using constructor
            return newcar;//return object to the caller
        }

        public void SetIC(string ID)
        {
            this.ID = ID; //Getting ID from previous "Choose" Form
        }

    }
}
