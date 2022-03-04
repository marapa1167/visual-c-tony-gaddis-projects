namespace Body_Mass_Index
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
            this.weightLabelPrompt = new System.Windows.Forms.Label();
            this.heightLabelPrompt = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.bmiTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weightLabelPrompt
            // 
            this.weightLabelPrompt.AutoSize = true;
            this.weightLabelPrompt.Location = new System.Drawing.Point(30, 26);
            this.weightLabelPrompt.Name = "weightLabelPrompt";
            this.weightLabelPrompt.Size = new System.Drawing.Size(201, 17);
            this.weightLabelPrompt.TabIndex = 0;
            this.weightLabelPrompt.Text = "Enter your weight in kilograms:";
            // 
            // heightLabelPrompt
            // 
            this.heightLabelPrompt.AutoSize = true;
            this.heightLabelPrompt.Location = new System.Drawing.Point(30, 82);
            this.heightLabelPrompt.Name = "heightLabelPrompt";
            this.heightLabelPrompt.Size = new System.Drawing.Size(213, 17);
            this.heightLabelPrompt.TabIndex = 1;
            this.heightLabelPrompt.Text = "Enter your height in centimetres:";
            // 
            // bmiLabel
            // 
            this.bmiLabel.Location = new System.Drawing.Point(105, 187);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(172, 39);
            this.bmiLabel.TabIndex = 2;
            this.bmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightTextBox
            // 
            this.weightTextBox.BackColor = System.Drawing.Color.White;
            this.weightTextBox.Location = new System.Drawing.Point(249, 26);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 22);
            this.weightTextBox.TabIndex = 3;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(249, 79);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 22);
            this.heightTextBox.TabIndex = 4;
            // 
            // bmiTextBox
            // 
            this.bmiTextBox.Location = new System.Drawing.Point(151, 152);
            this.bmiTextBox.Name = "bmiTextBox";
            this.bmiTextBox.Size = new System.Drawing.Size(100, 22);
            this.bmiTextBox.TabIndex = 5;
            this.bmiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(160, 120);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(83, 17);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Your BMI is:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(23, 246);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(79, 37);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(150, 246);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 37);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(265, 246);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 37);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(395, 326);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.bmiTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.heightLabelPrompt);
            this.Controls.Add(this.weightLabelPrompt);
            this.Name = "Form1";
            this.Text = "Body Mass Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLabelPrompt;
        private System.Windows.Forms.Label heightLabelPrompt;
        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox bmiTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

