using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
    public partial class Form1 : Form
    {
        private double basePrice = 0.00;
        private double accPrice = 0.00;
        private double subTotal = 0.00;
        private double totalTax = 0.00;

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

        private void TradeInBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (Model6Select.Checked){
                basePrice = 749.00;
                BasePriceBox.Text = basePrice.ToString();
            }
            if (Model5Select.Checked)
            {
                basePrice = 639.00;
                BasePriceBox.Text = basePrice.ToString();
            }

            
        }

        private void Model6Select_CheckedChanged_1(object sender, EventArgs e)
        {
            basePrice = 749.00;
            BasePriceBox.Text = basePrice.ToString();
            Mem64GB.Text = "64GB";
            Mem64GB.Checked = false;
            Mem16GB.Checked = false;
            Mem128GB.Checked = false;
            Mem128GB.Enabled = true;
        }

        private void Model5Select_CheckedChanged_1(object sender, EventArgs e)
        {
            basePrice = 639.00;
            BasePriceBox.Text = basePrice.ToString();
            Mem64GB.Text = "32GB";
            Mem64GB.Checked = false;
            Mem16GB.Checked = false;
            Mem128GB.Checked = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (Model6Select.Checked)
            {
                basePrice = 969.00;
                BasePriceBox.Text = basePrice.ToString();
            }
            if (Model5Select.Checked)
            {
                Mem128GB.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (Model6Select.Checked)
            {
                basePrice = 859.00;
                BasePriceBox.Text = basePrice.ToString();
            }
            if (Model5Select.Checked)
            {
                basePrice = 699.00;
                BasePriceBox.Text = basePrice.ToString();
            }
        }

        private void ProtectionPlanCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ProtectionPlanCheck.Checked)
            {
                accPrice = accPrice + 99.00;
                AccPriceBox.Text = accPrice.ToString();
            }
            else
            {
                accPrice = accPrice - 99.00;
                AccPriceBox.Text = accPrice.ToString();
            }
        }

        private void LeatherCaseCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (LeatherCaseCheck.Checked)
            {
                accPrice = accPrice + 49.00;
                AccPriceBox.Text = accPrice.ToString();
            }
            else
            {
                accPrice = accPrice - 49.00;
                AccPriceBox.Text = accPrice.ToString();
            }
        }

        private void ScreenProtectCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ScreenProtectCheck.Checked)
            {
                accPrice = accPrice + 29.00;
                AccPriceBox.Text = accPrice.ToString();
            }
            else
            {
                accPrice = accPrice - 29.00;
                AccPriceBox.Text = accPrice.ToString();
            }
        }
    }
}
