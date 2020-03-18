using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processClick(object sender, EventArgs e)
        {
            // If the user hasn't selected a currency to convert to flash an error message
            if (allCurrencies.Text != "USD" && allCurrencies.Text != "AUD" && allCurrencies.Text != "EUR")
            {
                MessageBox.Show("Select a currency before converting", "Currency Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else
            {
                float gbpNumber = float.Parse(startingCurrency.Text);
                if (allCurrencies.Text == "USD")
                {
                    // Convert given GBP to US Dollars
                    double convertedUsd = Math.Round(gbpNumber * 1.21, 2);
                    // Output the converted currency in the read only textbox
                    endingCurrency.Text = "USD: $" + convertedUsd;
                }
                else if (allCurrencies.Text == "AUD")
                {
                    // Convert the given GBP to Australian Dollars
                    double convertedAud = Math.Round(gbpNumber * 2.02, 2);
                    // Output the converted currency in the read only textbox
                    endingCurrency.Text = "AUD: $" + convertedAud;
                }
                else if (allCurrencies.Text == "EUR")
                {
                    // Convert the given GBP to Euros
                    double convertedEur = Math.Round(gbpNumber * 1.10, 2);
                    // Output the converted currency in the read only textbox
                    endingCurrency.Text = "EUR: €" + convertedEur;
                }

            }

           
            

        }
    }
}
