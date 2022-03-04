namespace The_Distance_Converter
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
            this.promptLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.convertedDistanceLbl = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.fromGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptLbl
            // 
            this.promptLbl.AutoSize = true;
            this.promptLbl.Location = new System.Drawing.Point(92, 35);
            this.promptLbl.Name = "promptLbl";
            this.promptLbl.Size = new System.Drawing.Size(182, 17);
            this.promptLbl.TabIndex = 0;
            this.promptLbl.Text = "Enter a distance to convert:";
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(71, 208);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(134, 17);
            this.outputLbl.TabIndex = 1;
            this.outputLbl.Text = "Converted distance:";
            // 
            // convertedDistanceLbl
            // 
            this.convertedDistanceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedDistanceLbl.Location = new System.Drawing.Point(341, 207);
            this.convertedDistanceLbl.Name = "convertedDistanceLbl";
            this.convertedDistanceLbl.Size = new System.Drawing.Size(112, 33);
            this.convertedDistanceLbl.TabIndex = 2;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(341, 30);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.distanceTextBox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(74, 269);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(84, 32);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(360, 269);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 32);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.fromListBox);
            this.fromGroupBox.Location = new System.Drawing.Point(74, 70);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(181, 103);
            this.fromGroupBox.TabIndex = 8;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "From";
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.ItemHeight = 16;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(6, 31);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(125, 52);
            this.fromListBox.TabIndex = 0;
            // 
            // toGroupBox
            // 
            this.toGroupBox.Controls.Add(this.toListBox);
            this.toGroupBox.Location = new System.Drawing.Point(307, 70);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(200, 103);
            this.toGroupBox.TabIndex = 9;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "To";
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.ItemHeight = 16;
            this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(6, 31);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(128, 52);
            this.toListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 352);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.fromGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.convertedDistanceLbl);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.promptLbl);
            this.Name = "Form1";
            this.Text = "The Distance Converter";
            this.fromGroupBox.ResumeLayout(false);
            this.toGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLbl;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Label convertedDistanceLbl;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.ListBox toListBox;
    }
}

