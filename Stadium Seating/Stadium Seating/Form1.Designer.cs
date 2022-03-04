namespace Stadium_Seating
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
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.cClassTextBox = new System.Windows.Forms.TextBox();
            this.bClassTextBox = new System.Windows.Forms.TextBox();
            this.aClassTextBox = new System.Windows.Forms.TextBox();
            this.labelCclass = new System.Windows.Forms.Label();
            this.labelBclass = new System.Windows.Forms.Label();
            this.labelAclass = new System.Windows.Forms.Label();
            this.inputPromptLabel = new System.Windows.Forms.Label();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.revenueTotalLabel = new System.Windows.Forms.Label();
            this.revenueCclassLabel = new System.Windows.Forms.Label();
            this.revenueBclassLabel = new System.Windows.Forms.Label();
            this.revenueAclassLabel = new System.Windows.Forms.Label();
            this.revTotal = new System.Windows.Forms.Label();
            this.revCclass = new System.Windows.Forms.Label();
            this.revBclass = new System.Windows.Forms.Label();
            this.revAclass = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inputGroupBox.Controls.Add(this.cClassTextBox);
            this.inputGroupBox.Controls.Add(this.bClassTextBox);
            this.inputGroupBox.Controls.Add(this.aClassTextBox);
            this.inputGroupBox.Controls.Add(this.labelCclass);
            this.inputGroupBox.Controls.Add(this.labelBclass);
            this.inputGroupBox.Controls.Add(this.labelAclass);
            this.inputGroupBox.Controls.Add(this.inputPromptLabel);
            this.inputGroupBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inputGroupBox.Location = new System.Drawing.Point(26, 22);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(237, 254);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Tickets Sold";
            // 
            // cClassTextBox
            // 
            this.cClassTextBox.CausesValidation = false;
            this.cClassTextBox.Location = new System.Drawing.Point(96, 184);
            this.cClassTextBox.Name = "cClassTextBox";
            this.cClassTextBox.Size = new System.Drawing.Size(100, 22);
            this.cClassTextBox.TabIndex = 6;
            // 
            // bClassTextBox
            // 
            this.bClassTextBox.CausesValidation = false;
            this.bClassTextBox.Location = new System.Drawing.Point(96, 136);
            this.bClassTextBox.Name = "bClassTextBox";
            this.bClassTextBox.Size = new System.Drawing.Size(100, 22);
            this.bClassTextBox.TabIndex = 5;
            // 
            // aClassTextBox
            // 
            this.aClassTextBox.CausesValidation = false;
            this.aClassTextBox.Location = new System.Drawing.Point(96, 91);
            this.aClassTextBox.Name = "aClassTextBox";
            this.aClassTextBox.Size = new System.Drawing.Size(100, 22);
            this.aClassTextBox.TabIndex = 4;
            // 
            // labelCclass
            // 
            this.labelCclass.AutoSize = true;
            this.labelCclass.Location = new System.Drawing.Point(31, 187);
            this.labelCclass.Name = "labelCclass";
            this.labelCclass.Size = new System.Drawing.Size(59, 17);
            this.labelCclass.TabIndex = 3;
            this.labelCclass.Text = "Class C:";
            // 
            // labelBclass
            // 
            this.labelBclass.AutoSize = true;
            this.labelBclass.Location = new System.Drawing.Point(31, 141);
            this.labelBclass.Name = "labelBclass";
            this.labelBclass.Size = new System.Drawing.Size(59, 17);
            this.labelBclass.TabIndex = 2;
            this.labelBclass.Text = "Class B:";
            // 
            // labelAclass
            // 
            this.labelAclass.AutoSize = true;
            this.labelAclass.Location = new System.Drawing.Point(31, 91);
            this.labelAclass.Name = "labelAclass";
            this.labelAclass.Size = new System.Drawing.Size(59, 17);
            this.labelAclass.TabIndex = 1;
            this.labelAclass.Text = "Class A:";
            // 
            // inputPromptLabel
            // 
            this.inputPromptLabel.Location = new System.Drawing.Point(31, 34);
            this.inputPromptLabel.Name = "inputPromptLabel";
            this.inputPromptLabel.Size = new System.Drawing.Size(201, 42);
            this.inputPromptLabel.TabIndex = 0;
            this.inputPromptLabel.Text = "Enter the number of tickets sold for each class of seats";
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.revenueTotalLabel);
            this.outputGroupBox.Controls.Add(this.revenueCclassLabel);
            this.outputGroupBox.Controls.Add(this.revenueBclassLabel);
            this.outputGroupBox.Controls.Add(this.revenueAclassLabel);
            this.outputGroupBox.Controls.Add(this.revTotal);
            this.outputGroupBox.Controls.Add(this.revCclass);
            this.outputGroupBox.Controls.Add(this.revBclass);
            this.outputGroupBox.Controls.Add(this.revAclass);
            this.outputGroupBox.Location = new System.Drawing.Point(298, 22);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(226, 254);
            this.outputGroupBox.TabIndex = 1;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Revenue generated";
            // 
            // revenueTotalLabel
            // 
            this.revenueTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueTotalLabel.Location = new System.Drawing.Point(85, 183);
            this.revenueTotalLabel.Name = "revenueTotalLabel";
            this.revenueTotalLabel.Size = new System.Drawing.Size(107, 22);
            this.revenueTotalLabel.TabIndex = 11;
            // 
            // revenueCclassLabel
            // 
            this.revenueCclassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueCclassLabel.Location = new System.Drawing.Point(85, 135);
            this.revenueCclassLabel.Name = "revenueCclassLabel";
            this.revenueCclassLabel.Size = new System.Drawing.Size(107, 22);
            this.revenueCclassLabel.TabIndex = 10;
            // 
            // revenueBclassLabel
            // 
            this.revenueBclassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueBclassLabel.Location = new System.Drawing.Point(85, 86);
            this.revenueBclassLabel.Name = "revenueBclassLabel";
            this.revenueBclassLabel.Size = new System.Drawing.Size(107, 22);
            this.revenueBclassLabel.TabIndex = 9;
            // 
            // revenueAclassLabel
            // 
            this.revenueAclassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueAclassLabel.Location = new System.Drawing.Point(85, 39);
            this.revenueAclassLabel.Name = "revenueAclassLabel";
            this.revenueAclassLabel.Size = new System.Drawing.Size(107, 22);
            this.revenueAclassLabel.TabIndex = 8;
            // 
            // revTotal
            // 
            this.revTotal.AutoSize = true;
            this.revTotal.Location = new System.Drawing.Point(20, 184);
            this.revTotal.Name = "revTotal";
            this.revTotal.Size = new System.Drawing.Size(44, 17);
            this.revTotal.TabIndex = 7;
            this.revTotal.Text = "Total:";
            // 
            // revCclass
            // 
            this.revCclass.AutoSize = true;
            this.revCclass.Location = new System.Drawing.Point(20, 136);
            this.revCclass.Name = "revCclass";
            this.revCclass.Size = new System.Drawing.Size(59, 17);
            this.revCclass.TabIndex = 6;
            this.revCclass.Text = "Class C:";
            // 
            // revBclass
            // 
            this.revBclass.AutoSize = true;
            this.revBclass.Location = new System.Drawing.Point(20, 91);
            this.revBclass.Name = "revBclass";
            this.revBclass.Size = new System.Drawing.Size(59, 17);
            this.revBclass.TabIndex = 5;
            this.revBclass.Text = "Class B:";
            // 
            // revAclass
            // 
            this.revAclass.AutoSize = true;
            this.revAclass.Location = new System.Drawing.Point(20, 44);
            this.revAclass.Name = "revAclass";
            this.revAclass.Size = new System.Drawing.Size(59, 17);
            this.revAclass.TabIndex = 4;
            this.revAclass.Text = "Class A:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(105, 307);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(105, 52);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(246, 307);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(98, 52);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(383, 307);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(79, 52);
            this.exitButton.TabIndex = 14;
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
            this.ClientSize = new System.Drawing.Size(555, 385);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox cClassTextBox;
        private System.Windows.Forms.TextBox bClassTextBox;
        private System.Windows.Forms.TextBox aClassTextBox;
        private System.Windows.Forms.Label labelCclass;
        private System.Windows.Forms.Label labelBclass;
        private System.Windows.Forms.Label labelAclass;
        private System.Windows.Forms.Label inputPromptLabel;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Label revenueTotalLabel;
        private System.Windows.Forms.Label revenueCclassLabel;
        private System.Windows.Forms.Label revenueBclassLabel;
        private System.Windows.Forms.Label revenueAclassLabel;
        private System.Windows.Forms.Label revTotal;
        private System.Windows.Forms.Label revCclass;
        private System.Windows.Forms.Label revBclass;
        private System.Windows.Forms.Label revAclass;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

