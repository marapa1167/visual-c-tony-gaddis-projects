namespace Color_Mixer
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
            this.firstColorGroupBox = new System.Windows.Forms.GroupBox();
            this.secondColorGroupBox = new System.Windows.Forms.GroupBox();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.RedRadioButtonFirst = new System.Windows.Forms.RadioButton();
            this.BlueRadioButtonFirst = new System.Windows.Forms.RadioButton();
            this.yellowRadioButtonFirst = new System.Windows.Forms.RadioButton();
            this.redRadioButtonSecond = new System.Windows.Forms.RadioButton();
            this.blueRadioButtonSecond = new System.Windows.Forms.RadioButton();
            this.yellowRadioButtonSecond = new System.Windows.Forms.RadioButton();
            this.firstColorGroupBox.SuspendLayout();
            this.secondColorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstColorGroupBox
            // 
            this.firstColorGroupBox.Controls.Add(this.yellowRadioButtonFirst);
            this.firstColorGroupBox.Controls.Add(this.BlueRadioButtonFirst);
            this.firstColorGroupBox.Controls.Add(this.RedRadioButtonFirst);
            this.firstColorGroupBox.Location = new System.Drawing.Point(29, 56);
            this.firstColorGroupBox.Name = "firstColorGroupBox";
            this.firstColorGroupBox.Size = new System.Drawing.Size(205, 149);
            this.firstColorGroupBox.TabIndex = 0;
            this.firstColorGroupBox.TabStop = false;
            this.firstColorGroupBox.Text = "Select the first color";
            // 
            // secondColorGroupBox
            // 
            this.secondColorGroupBox.Controls.Add(this.redRadioButtonSecond);
            this.secondColorGroupBox.Controls.Add(this.blueRadioButtonSecond);
            this.secondColorGroupBox.Controls.Add(this.yellowRadioButtonSecond);
            this.secondColorGroupBox.Location = new System.Drawing.Point(293, 56);
            this.secondColorGroupBox.Name = "secondColorGroupBox";
            this.secondColorGroupBox.Size = new System.Drawing.Size(204, 149);
            this.secondColorGroupBox.TabIndex = 0;
            this.secondColorGroupBox.TabStop = false;
            this.secondColorGroupBox.Text = "Select the second color";
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(101, 211);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(77, 29);
            this.mixButton.TabIndex = 0;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(356, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 29);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // RedRadioButtonFirst
            // 
            this.RedRadioButtonFirst.AutoSize = true;
            this.RedRadioButtonFirst.Location = new System.Drawing.Point(37, 37);
            this.RedRadioButtonFirst.Name = "RedRadioButtonFirst";
            this.RedRadioButtonFirst.Size = new System.Drawing.Size(55, 21);
            this.RedRadioButtonFirst.TabIndex = 0;
            this.RedRadioButtonFirst.TabStop = true;
            this.RedRadioButtonFirst.Text = "Red";
            this.RedRadioButtonFirst.UseVisualStyleBackColor = true;
            // 
            // BlueRadioButtonFirst
            // 
            this.BlueRadioButtonFirst.AutoSize = true;
            this.BlueRadioButtonFirst.Location = new System.Drawing.Point(37, 65);
            this.BlueRadioButtonFirst.Name = "BlueRadioButtonFirst";
            this.BlueRadioButtonFirst.Size = new System.Drawing.Size(57, 21);
            this.BlueRadioButtonFirst.TabIndex = 1;
            this.BlueRadioButtonFirst.TabStop = true;
            this.BlueRadioButtonFirst.Text = "Blue";
            this.BlueRadioButtonFirst.UseVisualStyleBackColor = true;
            // 
            // yellowRadioButtonFirst
            // 
            this.yellowRadioButtonFirst.AutoSize = true;
            this.yellowRadioButtonFirst.Location = new System.Drawing.Point(37, 98);
            this.yellowRadioButtonFirst.Name = "yellowRadioButtonFirst";
            this.yellowRadioButtonFirst.Size = new System.Drawing.Size(69, 21);
            this.yellowRadioButtonFirst.TabIndex = 2;
            this.yellowRadioButtonFirst.TabStop = true;
            this.yellowRadioButtonFirst.Text = "Yellow";
            this.yellowRadioButtonFirst.UseVisualStyleBackColor = true;
            // 
            // redRadioButtonSecond
            // 
            this.redRadioButtonSecond.AutoSize = true;
            this.redRadioButtonSecond.Location = new System.Drawing.Point(28, 37);
            this.redRadioButtonSecond.Name = "redRadioButtonSecond";
            this.redRadioButtonSecond.Size = new System.Drawing.Size(55, 21);
            this.redRadioButtonSecond.TabIndex = 3;
            this.redRadioButtonSecond.TabStop = true;
            this.redRadioButtonSecond.Text = "Red";
            this.redRadioButtonSecond.UseVisualStyleBackColor = true;
            // 
            // blueRadioButtonSecond
            // 
            this.blueRadioButtonSecond.AutoSize = true;
            this.blueRadioButtonSecond.Location = new System.Drawing.Point(28, 65);
            this.blueRadioButtonSecond.Name = "blueRadioButtonSecond";
            this.blueRadioButtonSecond.Size = new System.Drawing.Size(57, 21);
            this.blueRadioButtonSecond.TabIndex = 4;
            this.blueRadioButtonSecond.TabStop = true;
            this.blueRadioButtonSecond.Text = "Blue";
            this.blueRadioButtonSecond.UseVisualStyleBackColor = true;
            // 
            // yellowRadioButtonSecond
            // 
            this.yellowRadioButtonSecond.AutoSize = true;
            this.yellowRadioButtonSecond.Location = new System.Drawing.Point(28, 98);
            this.yellowRadioButtonSecond.Name = "yellowRadioButtonSecond";
            this.yellowRadioButtonSecond.Size = new System.Drawing.Size(69, 21);
            this.yellowRadioButtonSecond.TabIndex = 5;
            this.yellowRadioButtonSecond.TabStop = true;
            this.yellowRadioButtonSecond.Text = "Yellow";
            this.yellowRadioButtonSecond.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 347);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.secondColorGroupBox);
            this.Controls.Add(this.firstColorGroupBox);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.firstColorGroupBox.ResumeLayout(false);
            this.firstColorGroupBox.PerformLayout();
            this.secondColorGroupBox.ResumeLayout(false);
            this.secondColorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox firstColorGroupBox;
        private System.Windows.Forms.RadioButton yellowRadioButtonFirst;
        private System.Windows.Forms.RadioButton BlueRadioButtonFirst;
        private System.Windows.Forms.RadioButton RedRadioButtonFirst;
        private System.Windows.Forms.GroupBox secondColorGroupBox;
        private System.Windows.Forms.RadioButton redRadioButtonSecond;
        private System.Windows.Forms.RadioButton blueRadioButtonSecond;
        private System.Windows.Forms.RadioButton yellowRadioButtonSecond;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
    }
}

