using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * @author Justin Lucas
 * February 4th 2015
 * Assignment 01
 * Goal is to make an application which allows a user to select their preffered
 * iphone brand/color/memory size and output the cost
 */

namespace Assignment01
{
    public partial class Form1 : Form
    {
        private double basePrice = 0.00;
        private double accPrice = 0.00;
        private double subTotal = 0.00;
        private double totalTax = 0.00;
        private double totalTradeIn = 0.00;
        private double total = 0.00;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void LeftGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BasePriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubtotalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaxBox_TextChanged(object sender, EventArgs e)
        {

        }
        // handles the trade in box error catching
        private void TradeInBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalTradeIn = double.Parse(TradeInBox.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Must enter a number ", "Invalid Value");
                TradeInBox.Text = "0.00";
            }
            
            if (totalTradeIn < 0.00){
                MessageBox.Show("Must enter a positive number ", "Invalid Value");
                TradeInBox.Text = "0.00";
            }

        }

        private void TotalBox_TextChanged(object sender, EventArgs e)
        {

        }
        // the 16 gb radio button, removing this deletes my files for some reasonso its named wrong...
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (Model6Select.Checked){
                basePrice = 749.00;
                BasePriceBox.Text = basePrice.ToString("N2");
            }
            if (Model5Select.Checked)
            {
                basePrice = 639.00;
                BasePriceBox.Text = basePrice.ToString("N2");
            }

            
        }
        // sets the base value for an iphone 6
        private void Model6Select_CheckedChanged_1(object sender, EventArgs e)
        {
            basePrice = 749.00;
            BasePriceBox.Text = basePrice.ToString("N2");
            Mem64GB.Text = "64GB";
            Mem64GB.Checked = false;
            Mem16GB.Checked = false;
            Mem128GB.Checked = false;
            Mem128GB.Enabled = true;
        }
        // sets the base value for an iphone 5s
        private void Model5Select_CheckedChanged_1(object sender, EventArgs e)
        {
            basePrice = 639.00;
            BasePriceBox.Text = basePrice.ToString("N2");
            Mem64GB.Text = "32GB";
            Mem64GB.Checked = false;
            Mem16GB.Checked = false;
            Mem128GB.Checked = false;
            Mem128GB.Enabled = false;
            
        }
        // the 128 gb radio button, removing this deletes my files for some reasonso its named wrong...
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (Model6Select.Checked)
            {
                basePrice = 969.00;
                BasePriceBox.Text = basePrice.ToString("N2");
            }
            
        }
        // the 32/64 gb radio button, removing this deletes my files for some reasonso its named wrong...
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (Model6Select.Checked)
            {
                basePrice = 859.00;
                BasePriceBox.Text = basePrice.ToString("N2");
            }
            if (Model5Select.Checked)
            {
                basePrice = 699.00;
                BasePriceBox.Text = basePrice.ToString("N2");
            }
        }
        // adds/removes value for protection plans
        private void ProtectionPlanCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ProtectionPlanCheck.Checked)
            {
                accPrice = accPrice + 99.00;
                AccPriceBox.Text = accPrice.ToString("N2");
            }
            else
            {
                accPrice = accPrice - 99.00;
                AccPriceBox.Text = accPrice.ToString("N2");
            }
        }
        // add/removes value for leather case
        private void LeatherCaseCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (LeatherCaseCheck.Checked)
            {
                accPrice = accPrice + 49.00;
                AccPriceBox.Text = accPrice.ToString("N2");
            }
            else
            {
                accPrice = accPrice - 49.00;
                AccPriceBox.Text = accPrice.ToString("N2");
            }
        }
        // adds/removes value for screen protector
        private void ScreenProtectCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ScreenProtectCheck.Checked)
            {
                accPrice = accPrice + 29.00;
                AccPriceBox.Text = accPrice.ToString("N2");
            }
            else
            {
                accPrice = accPrice - 29.00;
                AccPriceBox.Text = accPrice.ToString("N2");
            }
        }
        // black iphone pictures
        private void colourBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (Model6Select.Checked)
            {
                pictureBox1.Image = Assignment01.Properties.Resources.ip6black;
            }
            if (Model5Select.Checked)
            {
                pictureBox1.Image = Assignment01.Properties.Resources.ip5s;
            }
        }
        // silver iphone pictures
        private void colourSilver_CheckedChanged(object sender, EventArgs e)
        {
            if (Model6Select.Checked)
            {
                pictureBox1.Image = Assignment01.Properties.Resources.ip6silver;
            }
            if (Model5Select.Checked)
            {
                pictureBox1.Image = Assignment01.Properties.Resources.ip5ssilver;
            }
        }
        // gold iphone pictures
        private void colourGold_CheckedChanged(object sender, EventArgs e)
        {
            if (Model6Select.Checked)
            {
                pictureBox1.Image = Assignment01.Properties.Resources.ip6gold;
            }
            if (Model5Select.Checked)
            {
                pictureBox1.Image = Assignment01.Properties.Resources.ip5sgold;
            }
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // calculates subtotal and displays it
            subTotal = basePrice + accPrice;
            SubtotalBox.Text = subTotal.ToString("N2");
            // calculates the tax and displays it
            totalTax = subTotal * 0.13;
            TaxBox.Text = totalTax.ToString("N2");
            // calculates total and displays it
            total = subTotal + totalTax - totalTradeIn;
            TotalBox.Text = total.ToString("N2");

        }
        // clears values
        private void clearButton_Click(object sender, EventArgs e)
        {
            SubtotalBox.Text = "0.00";
            TaxBox.Text = "0.00";
            TradeInBox.Text = "0.00";
            TotalBox.Text = "0.00";
        }
        // exits application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       // sets the hotkeys for my buttons
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.I))
            {
                clearButton.PerformClick();
                return true;
            }
            if (keyData == (Keys.C))
            {
                CalcButton.PerformClick();
                return true;
            }
            if (keyData == (Keys.X))
            {
                exitButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        
    }
}
