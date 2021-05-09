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
            double Qty = Convert.ToDouble(TxtQuantity.Text.Trim());
            double Bonus = Convert.ToDouble(TxtBonus.Text.Trim());
            double Cost = Convert.ToDouble(TxtCost.Text.Trim());

            double TotalCostWithoutBonus = Qty * Cost;
            double TotalQtyWithBonus = Bonus + Qty;
            double TotalCostWithBonus = Cost * TotalQtyWithBonus;
            double CostPerPeiceWithBonus = TotalCostWithoutBonus / TotalQtyWithBonus;
            double DiscountPerPiece = Cost - CostPerPeiceWithBonus;
            double DiscountPercentagePerPiece = DiscountPerPiece / Cost * 100;

            TxtBonusPercentage.Text = DiscountPercentagePerPiece.ToString();

        }
    }
}
