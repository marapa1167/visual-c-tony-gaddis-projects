namespace Sale_Price_Calculator
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
            this.OriginalPricePromptLabel = new System.Windows.Forms.Label();
            this.DiscPercentagePromptLabel = new System.Windows.Forms.Label();
            this.OutputDescriptionLabel = new System.Windows.Forms.Label();
            this.OriginalPriceTextBox = new System.Windows.Forms.TextBox();
            this.DiscountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SalePriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OriginalPricePromptLabel
            // 
            this.OriginalPricePromptLabel.AutoSize = true;
            this.OriginalPricePromptLabel.Location = new System.Drawing.Point(42, 43);
            this.OriginalPricePromptLabel.Name = "OriginalPricePromptLabel";
            this.OriginalPricePromptLabel.Size = new System.Drawing.Size(195, 17);
            this.OriginalPricePromptLabel.TabIndex = 0;
            this.OriginalPricePromptLabel.Text = "Enter the item\'s original price:";
            // 
            // DiscPercentagePromptLabel
            // 
            this.DiscPercentagePromptLabel.AutoSize = true;
            this.DiscPercentagePromptLabel.Location = new System.Drawing.Point(42, 114);
            this.DiscPercentagePromptLabel.Name = "DiscPercentagePromptLabel";
            this.DiscPercentagePromptLabel.Size = new System.Drawing.Size(203, 17);
            this.DiscPercentagePromptLabel.TabIndex = 1;
            this.DiscPercentagePromptLabel.Text = "Enter the discount percentage:";
            // 
            // OutputDescriptionLabel
            // 
            this.OutputDescriptionLabel.AutoSize = true;
            this.OutputDescriptionLabel.Location = new System.Drawing.Point(162, 178);
            this.OutputDescriptionLabel.Name = "OutputDescriptionLabel";
            this.OutputDescriptionLabel.Size = new System.Drawing.Size(75, 17);
            this.OutputDescriptionLabel.TabIndex = 2;
            this.OutputDescriptionLabel.Text = "Sale price:";
            // 
            // OriginalPriceTextBox
            // 
            this.OriginalPriceTextBox.Location = new System.Drawing.Point(289, 43);
            this.OriginalPriceTextBox.Name = "OriginalPriceTextBox";
            this.OriginalPriceTextBox.Size = new System.Drawing.Size(133, 22);
            this.OriginalPriceTextBox.TabIndex = 3;
            // 
            // DiscountPercentageTextBox
            // 
            this.DiscountPercentageTextBox.Location = new System.Drawing.Point(289, 114);
            this.DiscountPercentageTextBox.Name = "DiscountPercentageTextBox";
            this.DiscountPercentageTextBox.Size = new System.Drawing.Size(133, 22);
            this.DiscountPercentageTextBox.TabIndex = 4;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(83, 267);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(115, 56);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate Sale Price";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(300, 266);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(89, 57);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SalePriceLabel
            // 
            this.SalePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalePriceLabel.Location = new System.Drawing.Point(289, 178);
            this.SalePriceLabel.Name = "SalePriceLabel";
            this.SalePriceLabel.Size = new System.Drawing.Size(133, 31);
            this.SalePriceLabel.TabIndex = 8;
            this.SalePriceLabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 386);
            this.Controls.Add(this.SalePriceLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.DiscountPercentageTextBox);
            this.Controls.Add(this.OriginalPriceTextBox);
            this.Controls.Add(this.OutputDescriptionLabel);
            this.Controls.Add(this.DiscPercentagePromptLabel);
            this.Controls.Add(this.OriginalPricePromptLabel);
            this.Name = "Form1";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OriginalPricePromptLabel;
        private System.Windows.Forms.Label DiscPercentagePromptLabel;
        private System.Windows.Forms.Label OutputDescriptionLabel;
        private System.Windows.Forms.TextBox OriginalPriceTextBox;
        private System.Windows.Forms.TextBox DiscountPercentageTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label SalePriceLabel;
    }
}

