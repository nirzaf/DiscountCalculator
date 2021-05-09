
namespace DiscountCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.TxtBonus = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(163, 34);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(167, 23);
            this.TxtCost.TabIndex = 0;
            // 
            // TxtBonus
            // 
            this.TxtBonus.Location = new System.Drawing.Point(163, 130);
            this.TxtBonus.Name = "TxtBonus";
            this.TxtBonus.Size = new System.Drawing.Size(167, 23);
            this.TxtBonus.TabIndex = 1;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(163, 80);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(167, 23);
            this.TxtQuantity.TabIndex = 2;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(163, 193);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(167, 56);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblResult.Location = new System.Drawing.Point(163, 288);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(61, 25);
            this.LblResult.TabIndex = 4;
            this.LblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 462);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.TxtBonus);
            this.Controls.Add(this.TxtCost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.TextBox TxtBonus;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label LblResult;
    }
}

