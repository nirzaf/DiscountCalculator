using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscountCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double Qty = GetQuantity();
            double Bonus = GetBonus();
            double Cost = GetCost();
        }

        private double GetQuantity()
        {
            return ConToDouble(TxtQuantity.Text.Trim());
        }

        private double GetBonus()
        {
            return ConToDouble(TxtBonus.Text.Trim());
        }

        private double GetCost()
        {
            return ConToDouble(TxtCost.Text.Trim());
        }
        private double ConToDouble(string Value)
        {
            double Double = Convert.ToDouble(Value);
            return Double;
        }
    }
}
