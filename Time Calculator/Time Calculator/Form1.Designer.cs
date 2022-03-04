namespace Time_Calculator
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
            this.lblprompt = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.convertBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblprompt
            // 
            this.lblprompt.AutoSize = true;
            this.lblprompt.Location = new System.Drawing.Point(42, 43);
            this.lblprompt.Name = "lblprompt";
            this.lblprompt.Size = new System.Drawing.Size(183, 17);
            this.lblprompt.TabIndex = 0;
            this.lblprompt.Text = "Enter a number of seconds:";
            // 
            // lbloutput
            // 
            this.lbloutput.Location = new System.Drawing.Point(210, 107);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(100, 23);
            this.lbloutput.TabIndex = 1;
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(45, 217);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 23);
            this.convertBtn.TabIndex = 2;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(203, 217);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 3;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(350, 217);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(240, 43);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 22);
            this.inputTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 323);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblprompt);
            this.Name = "Form1";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprompt;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

