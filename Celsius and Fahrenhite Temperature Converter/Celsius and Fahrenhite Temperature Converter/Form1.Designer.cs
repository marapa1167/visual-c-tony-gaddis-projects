namespace Celsius_and_Fahrenhite_Temperature_Converter
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
            this.labelTempPrompt = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonCelsius = new System.Windows.Forms.Button();
            this.buttonFahrenheit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTempPrompt
            // 
            this.labelTempPrompt.AutoSize = true;
            this.labelTempPrompt.Location = new System.Drawing.Point(3, 36);
            this.labelTempPrompt.Name = "labelTempPrompt";
            this.labelTempPrompt.Size = new System.Drawing.Size(151, 17);
            this.labelTempPrompt.TabIndex = 0;
            this.labelTempPrompt.Text = "Enter the temperature:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(3, 98);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(158, 17);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.Text = "Converted temperature:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(176, 36);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 22);
            this.textBoxInput.TabIndex = 2;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(176, 98);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(100, 22);
            this.textBoxOutput.TabIndex = 3;
            // 
            // buttonCelsius
            // 
            this.buttonCelsius.Location = new System.Drawing.Point(54, 141);
            this.buttonCelsius.Name = "buttonCelsius";
            this.buttonCelsius.Size = new System.Drawing.Size(100, 44);
            this.buttonCelsius.TabIndex = 4;
            this.buttonCelsius.Text = "Convert to Celsius";
            this.buttonCelsius.UseVisualStyleBackColor = true;
            this.buttonCelsius.Click += new System.EventHandler(this.buttonCelsius_Click);
            // 
            // buttonFahrenheit
            // 
            this.buttonFahrenheit.Location = new System.Drawing.Point(181, 141);
            this.buttonFahrenheit.Name = "buttonFahrenheit";
            this.buttonFahrenheit.Size = new System.Drawing.Size(95, 44);
            this.buttonFahrenheit.TabIndex = 5;
            this.buttonFahrenheit.Text = "Convert to Fahrenheit";
            this.buttonFahrenheit.UseVisualStyleBackColor = true;
            this.buttonFahrenheit.Click += new System.EventHandler(this.buttonFahrenheit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(54, 201);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 46);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(181, 201);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(95, 46);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 270);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonFahrenheit);
            this.Controls.Add(this.buttonCelsius);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelTempPrompt);
            this.Name = "Form1";
            this.Text = "Celsius and Fahrenheit Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTempPrompt;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonCelsius;
        private System.Windows.Forms.Button buttonFahrenheit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

