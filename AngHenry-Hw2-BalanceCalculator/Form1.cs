using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngHenry_Hw2_BalanceCalculator
{
    public partial class balanceCalculatorForm : Form
    {
        public balanceCalculatorForm()
        {
            InitializeComponent();
            nameTextBox.Focus();        //sets focus to Name text box 
            showBalanceButton.Text = "&Show Balance";
            resetButton.Text = "&Reset";
            exitButton.Text = "&Exit";
        }

        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            accountSummaryLabel.Visible = true; 

            // ending balance displayed in both accounts 
            double checkingEndBalance = (Double.Parse(checkBeginningBalanceTextBox.Text) + Double.Parse(checkingDepositTextBox.Text)
                                                - Double.Parse(checkingWithdrawTextBox.Text));
            checkingEndbalanceLabel.Text = "$" + checkingEndBalance.ToString();
            checkingEndbalanceLabel.Text = "$" + checkingEndBalance.ToString();

            double savingEndBalance = (Double.Parse(savingBeginningBalanceTextBox.Text) + Double.Parse(savingDepositTextBox.Text)
                                               - Double.Parse(savingWithdrawTextBox.Text));
            savingEndbalanceLabel.Text = "$" + savingEndBalance.ToString();
            savingEndbalanceLabel.Text = "$" + savingEndBalance.ToString();

            // Displays account summary message
            double totalBeginning = (Double.Parse(checkBeginningBalanceTextBox.Text) + Double.Parse(savingBeginningBalanceTextBox.Text));
            double totalEnd = checkingEndBalance + savingEndBalance;
            double gain = (checkingEndBalance - Double.Parse(checkBeginningBalanceTextBox.Text)) +
                          (savingEndBalance - Double.Parse(savingBeginningBalanceTextBox.Text));

            if (gain < 0)
            {
                accountSummaryLabel.Text = "Total Beginning:  $" + totalBeginning.ToString()  + "\r\n" +
                                             "Total End:           $" + totalEnd.ToString() + "\r\n" +
                                             "Gain (loss):          $" + "(" + gain.ToString() + ")";
            }
            else
            {
                accountSummaryLabel.Text = "Total Beginning:  $" + totalBeginning.ToString() + "\r\n" +
                                             "Total End:           $" + totalEnd.ToString() + "\r\n" +
                                             "Gain (loss):          $" + gain.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // resets all text fields to default values 
            nameTextBox.Text = "";
            activityMaskedTextBox.Text = "";
            checkBeginningBalanceTextBox.Text = "0.00";
            savingBeginningBalanceTextBox.Text = "0.00";
            checkingDepositTextBox.Text = "0.00";
            savingDepositTextBox.Text = "0.00";
            checkingWithdrawTextBox.Text = "0.00";
            savingWithdrawTextBox.Text = "0.00";
            checkingEndbalanceLabel.Text = "";
            savingEndbalanceLabel.Text = "";

            // set account summary to not visible 
            accountSummaryLabel.Visible = false; 

            // set focus to name text box 
            nameTextBox.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();               // closes the form 
        }
    }
}
