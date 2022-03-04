namespace Fat_percentage_calculator
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
            this.labelCalPrompt = new System.Windows.Forms.Label();
            this.labelFatPrompt = new System.Windows.Forms.Label();
            this.textBoxCalories = new System.Windows.Forms.TextBox();
            this.textBoxFat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonClr = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCalPrompt
            // 
            this.labelCalPrompt.AutoSize = true;
            this.labelCalPrompt.Location = new System.Drawing.Point(25, 35);
            this.labelCalPrompt.Name = "labelCalPrompt";
            this.labelCalPrompt.Size = new System.Drawing.Size(317, 17);
            this.labelCalPrompt.TabIndex = 0;
            this.labelCalPrompt.Text = "Enter the total number of calories for a food item:";
            // 
            // labelFatPrompt
            // 
            this.labelFatPrompt.AutoSize = true;
            this.labelFatPrompt.Location = new System.Drawing.Point(25, 99);
            this.labelFatPrompt.Name = "labelFatPrompt";
            this.labelFatPrompt.Size = new System.Drawing.Size(306, 17);
            this.labelFatPrompt.TabIndex = 1;
            this.labelFatPrompt.Text = "Enter the number of fat grams in that food item:";
            // 
            // textBoxCalories
            // 
            this.textBoxCalories.Location = new System.Drawing.Point(394, 35);
            this.textBoxCalories.Name = "textBoxCalories";
            this.textBoxCalories.Size = new System.Drawing.Size(100, 22);
            this.textBoxCalories.TabIndex = 2;
            // 
            // textBoxFat
            // 
            this.textBoxFat.Location = new System.Drawing.Point(394, 99);
            this.textBoxFat.Name = "textBoxFat";
            this.textBoxFat.Size = new System.Drawing.Size(100, 22);
            this.textBoxFat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calories from fat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "% of calories that come from fat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 7;
            // 
            // labelCalories
            // 
            this.labelCalories.Location = new System.Drawing.Point(276, 197);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(115, 17);
            this.labelCalories.TabIndex = 8;
            // 
            // labelPercent
            // 
            this.labelPercent.Location = new System.Drawing.Point(276, 275);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(115, 17);
            this.labelPercent.TabIndex = 9;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(76, 495);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(90, 32);
            this.buttonCalc.TabIndex = 10;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonClr
            // 
            this.buttonClr.Location = new System.Drawing.Point(231, 495);
            this.buttonClr.Name = "buttonClr";
            this.buttonClr.Size = new System.Drawing.Size(76, 32);
            this.buttonClr.TabIndex = 11;
            this.buttonClr.Text = "Clear";
            this.buttonClr.UseVisualStyleBackColor = true;
            this.buttonClr.Click += new System.EventHandler(this.buttonClr_Click);
            // 
            // buttonEx
            // 
            this.buttonEx.Location = new System.Drawing.Point(394, 495);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(77, 32);
            this.buttonEx.TabIndex = 12;
            this.buttonEx.Text = "Exit";
            this.buttonEx.UseVisualStyleBackColor = true;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 359);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(372, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Do you want to check if the food is considered low fat?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfo.Location = new System.Drawing.Point(25, 404);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(375, 47);
            this.labelInfo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 588);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.buttonClr);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFat);
            this.Controls.Add(this.textBoxCalories);
            this.Controls.Add(this.labelFatPrompt);
            this.Controls.Add(this.labelCalPrompt);
            this.Name = "Form1";
            this.Text = "Fat percentage calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCalPrompt;
        private System.Windows.Forms.Label labelFatPrompt;
        private System.Windows.Forms.TextBox textBoxCalories;
        private System.Windows.Forms.TextBox textBoxFat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonClr;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelInfo;
    }
}

