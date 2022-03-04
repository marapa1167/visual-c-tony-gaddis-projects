namespace Change_for_a_dollar
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
            this.penniesLbl = new System.Windows.Forms.Label();
            this.nicklesLbl = new System.Windows.Forms.Label();
            this.dimesLbl = new System.Windows.Forms.Label();
            this.quartersLbl = new System.Windows.Forms.Label();
            this.pennytextBox = new System.Windows.Forms.TextBox();
            this.nickletextBox = new System.Windows.Forms.TextBox();
            this.dimetextBox = new System.Windows.Forms.TextBox();
            this.quartertextBox = new System.Windows.Forms.TextBox();
            this.chceckButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // penniesLbl
            // 
            this.penniesLbl.AutoSize = true;
            this.penniesLbl.Location = new System.Drawing.Point(37, 11);
            this.penniesLbl.Name = "penniesLbl";
            this.penniesLbl.Size = new System.Drawing.Size(196, 17);
            this.penniesLbl.TabIndex = 0;
            this.penniesLbl.Text = "Enter the number of  pennies:";
            // 
            // nicklesLbl
            // 
            this.nicklesLbl.AutoSize = true;
            this.nicklesLbl.Location = new System.Drawing.Point(37, 53);
            this.nicklesLbl.Name = "nicklesLbl";
            this.nicklesLbl.Size = new System.Drawing.Size(189, 17);
            this.nicklesLbl.TabIndex = 1;
            this.nicklesLbl.Text = "Enter the number of  nickles:";
            // 
            // dimesLbl
            // 
            this.dimesLbl.AutoSize = true;
            this.dimesLbl.Location = new System.Drawing.Point(37, 91);
            this.dimesLbl.Name = "dimesLbl";
            this.dimesLbl.Size = new System.Drawing.Size(183, 17);
            this.dimesLbl.TabIndex = 2;
            this.dimesLbl.Text = "Enter the number of  dimes:";
            // 
            // quartersLbl
            // 
            this.quartersLbl.AutoSize = true;
            this.quartersLbl.Location = new System.Drawing.Point(37, 130);
            this.quartersLbl.Name = "quartersLbl";
            this.quartersLbl.Size = new System.Drawing.Size(195, 17);
            this.quartersLbl.TabIndex = 3;
            this.quartersLbl.Text = "Enter the number of quarters:";
            // 
            // pennytextBox
            // 
            this.pennytextBox.Location = new System.Drawing.Point(292, 6);
            this.pennytextBox.Name = "pennytextBox";
            this.pennytextBox.Size = new System.Drawing.Size(100, 22);
            this.pennytextBox.TabIndex = 4;
            // 
            // nickletextBox
            // 
            this.nickletextBox.Location = new System.Drawing.Point(292, 48);
            this.nickletextBox.Name = "nickletextBox";
            this.nickletextBox.Size = new System.Drawing.Size(100, 22);
            this.nickletextBox.TabIndex = 5;
            // 
            // dimetextBox
            // 
            this.dimetextBox.Location = new System.Drawing.Point(292, 91);
            this.dimetextBox.Name = "dimetextBox";
            this.dimetextBox.Size = new System.Drawing.Size(100, 22);
            this.dimetextBox.TabIndex = 6;
            // 
            // quartertextBox
            // 
            this.quartertextBox.Location = new System.Drawing.Point(292, 130);
            this.quartertextBox.Name = "quartertextBox";
            this.quartertextBox.Size = new System.Drawing.Size(100, 22);
            this.quartertextBox.TabIndex = 7;
            // 
            // chceckButton
            // 
            this.chceckButton.Location = new System.Drawing.Point(55, 229);
            this.chceckButton.Name = "chceckButton";
            this.chceckButton.Size = new System.Drawing.Size(106, 56);
            this.chceckButton.TabIndex = 8;
            this.chceckButton.Text = "Check the total amount";
            this.chceckButton.UseVisualStyleBackColor = true;
            this.chceckButton.Click += new System.EventHandler(this.chceckButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(197, 229);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(78, 56);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(314, 229);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 56);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(264, 183);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 17);
            this.totalLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 345);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.chceckButton);
            this.Controls.Add(this.quartertextBox);
            this.Controls.Add(this.dimetextBox);
            this.Controls.Add(this.nickletextBox);
            this.Controls.Add(this.pennytextBox);
            this.Controls.Add(this.quartersLbl);
            this.Controls.Add(this.dimesLbl);
            this.Controls.Add(this.nicklesLbl);
            this.Controls.Add(this.penniesLbl);
            this.Name = "Form1";
            this.Text = "Change for a dollar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label penniesLbl;
        private System.Windows.Forms.Label nicklesLbl;
        private System.Windows.Forms.Label dimesLbl;
        private System.Windows.Forms.Label quartersLbl;
        private System.Windows.Forms.TextBox pennytextBox;
        private System.Windows.Forms.TextBox nickletextBox;
        private System.Windows.Forms.TextBox dimetextBox;
        private System.Windows.Forms.TextBox quartertextBox;
        private System.Windows.Forms.Button chceckButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
    }
}

