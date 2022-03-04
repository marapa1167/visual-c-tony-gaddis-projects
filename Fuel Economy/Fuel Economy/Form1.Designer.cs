namespace Fuel_Economy
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
            this.milesPromptLbl = new System.Windows.Forms.Label();
            this.gallonsPromptLbl = new System.Windows.Forms.Label();
            this.MPGlbl = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milesPromptLbl
            // 
            this.milesPromptLbl.AutoSize = true;
            this.milesPromptLbl.Location = new System.Drawing.Point(38, 46);
            this.milesPromptLbl.Name = "milesPromptLbl";
            this.milesPromptLbl.Size = new System.Drawing.Size(217, 17);
            this.milesPromptLbl.TabIndex = 0;
            this.milesPromptLbl.Text = "Enter the number of miles driven:";
            // 
            // gallonsPromptLbl
            // 
            this.gallonsPromptLbl.AutoSize = true;
            this.gallonsPromptLbl.Location = new System.Drawing.Point(38, 85);
            this.gallonsPromptLbl.Name = "gallonsPromptLbl";
            this.gallonsPromptLbl.Size = new System.Drawing.Size(197, 17);
            this.gallonsPromptLbl.TabIndex = 1;
            this.gallonsPromptLbl.Text = "Enter the gallons of gas used:";
            // 
            // MPGlbl
            // 
            this.MPGlbl.AutoSize = true;
            this.MPGlbl.Location = new System.Drawing.Point(84, 167);
            this.MPGlbl.Name = "MPGlbl";
            this.MPGlbl.Size = new System.Drawing.Size(111, 17);
            this.MPGlbl.TabIndex = 2;
            this.MPGlbl.Text = "Your car\'s MPG:";
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(288, 46);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(100, 22);
            this.milesTextBox.TabIndex = 3;
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(288, 85);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(100, 22);
            this.gallonsTextBox.TabIndex = 4;
            // 
            // mpgLabel
            // 
            this.mpgLabel.Location = new System.Drawing.Point(285, 167);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(119, 27);
            this.mpgLabel.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(87, 233);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(83, 45);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(288, 233);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 45);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 363);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.MPGlbl);
            this.Controls.Add(this.gallonsPromptLbl);
            this.Controls.Add(this.milesPromptLbl);
            this.Name = "Form1";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesPromptLbl;
        private System.Windows.Forms.Label gallonsPromptLbl;
        private System.Windows.Forms.Label MPGlbl;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

