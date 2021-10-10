using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This code runs when the Calculate button is clicked
        private void Calculate_Click(object sender, EventArgs e)
        {
            int numberOfTerms; // An integer variable that will contain the number of terms that will be used in the calculation
            double result = 0; // A double variable that will contain the result of the calculation
            string resultString; // A variable that will contain the result variable and the numberOfTerms variable formatted into a string

            if (int.TryParse(NumberOfTerms.Text, out numberOfTerms) && numberOfTerms >= 1) // This code runs if the data entered in the NumberOfTerms textbox can be parsed into an integer and if that integer is greater than or equal to 1. Made with help from the textbook (Gaddis, 244).
            {
                for(int i = 1; i <= numberOfTerms; i++) // This code will loop as many times as the number of terms entered by the user. Made with help from the textbook (Gaddis, 289).
                {
                    if(i % 2 != 0) // If the term is an odd number term, it will be added to the result
                    {
                        result += 4.0 / (2 * i - 1); // Calculates the next term and adds it to the result variable
                    } 
                    else // If the term is an even number term, it will be subtracted from the result
                    {
                        result -= 4.0 / (2 * i - 1); // Calculates the next term and subtracts it from the the result variable
                    }
                }
            }
            else // This code runs if the data entered in the NumberOfTerms textbox can't be parsed into an integer or if the that integer is less than 1
            {
                MessageBox.Show("Please enter an integer greater than or equal to 1"); // Displays a message requesting that the user enter an integer greater than or equal to 1
            }

            resultString = "The approximate value of pi after " + numberOfTerms + " terms is " + result; // Sets the value of the resultString variable to a string that contains the numberOfTerms variable and the the result variable
            ResultLabel.Text = resultString; // Sets the text of the ResultLabel to the resultString variable

        }
    }
}

// References:
// Gaddis, T. (2020). Starting Out With Visual C#. Pearson.