namespace Tip__Tax_and_Total
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelFoodChargePrompt = new System.Windows.Forms.Label();
            this.LabelTip = new System.Windows.Forms.Label();
            this.LabelTipAndSales = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.TipTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFoodChargePrompt
            // 
            this.LabelFoodChargePrompt.AutoSize = true;
            this.LabelFoodChargePrompt.Location = new System.Drawing.Point(24, 9);
            this.LabelFoodChargePrompt.Name = "LabelFoodChargePrompt";
            this.LabelFoodChargePrompt.Size = new System.Drawing.Size(177, 17);
            this.LabelFoodChargePrompt.TabIndex = 0;
            this.LabelFoodChargePrompt.Text = "Enter the charged amount:";
            // 
            // LabelTip
            // 
            this.LabelTip.AutoSize = true;
            this.LabelTip.Location = new System.Drawing.Point(24, 70);
            this.LabelTip.Name = "LabelTip";
            this.LabelTip.Size = new System.Drawing.Size(64, 17);
            this.LabelTip.TabIndex = 1;
            this.LabelTip.Text = "Tip 15%:";
            // 
            // LabelTipAndSales
            // 
            this.LabelTipAndSales.AutoSize = true;
            this.LabelTipAndSales.Location = new System.Drawing.Point(24, 149);
            this.LabelTipAndSales.Name = "LabelTipAndSales";
            this.LabelTipAndSales.Size = new System.Drawing.Size(93, 17);
            this.LabelTipAndSales.TabIndex = 2;
            this.LabelTipAndSales.Text = "Sales tax 7%:";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(24, 225);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(138, 17);
            this.LabelTotal.TabIndex = 3;
            this.LabelTotal.Text = "Total amount to pay:";
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(54, 278);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(98, 36);
            this.ButtonCalculate.TabIndex = 8;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Location = new System.Drawing.Point(296, 278);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonExit.Size = new System.Drawing.Size(80, 36);
            this.ButtonExit.TabIndex = 10;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(290, 9);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 22);
            this.InputTextBox.TabIndex = 4;
            // 
            // TipTextBox
            // 
            this.TipTextBox.Location = new System.Drawing.Point(290, 70);
            this.TipTextBox.Name = "TipTextBox";
            this.TipTextBox.Size = new System.Drawing.Size(100, 22);
            this.TipTextBox.TabIndex = 5;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(290, 144);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.SalesTaxTextBox.TabIndex = 6;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(290, 220);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalTextBox.TabIndex = 7;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(173, 278);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(98, 36);
            this.ButtonClear.TabIndex = 9;
            this.ButtonClear.Text = "&Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.ButtonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonExit;
            this.ClientSize = new System.Drawing.Size(448, 344);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.TipTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.LabelTipAndSales);
            this.Controls.Add(this.LabelTip);
            this.Controls.Add(this.LabelFoodChargePrompt);
            this.Name = "Form1";
            this.Text = "Tip, Tax and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFoodChargePrompt;
        private System.Windows.Forms.Label LabelTip;
        private System.Windows.Forms.Label LabelTipAndSales;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox TipTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button ButtonClear;
    }
}

