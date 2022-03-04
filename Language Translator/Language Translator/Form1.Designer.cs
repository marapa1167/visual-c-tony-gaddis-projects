namespace Language_Translator
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
            this.labelCommand = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonItalian = new System.Windows.Forms.Button();
            this.buttonSpanish = new System.Windows.Forms.Button();
            this.buttonGerman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(150, 24);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(299, 17);
            this.labelCommand.TabIndex = 0;
            this.labelCommand.Text = "Select a language and I will say Good Morning";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(149, 84);
            this.labelOutput.MinimumSize = new System.Drawing.Size(300, 50);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(300, 50);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // buttonItalian
            // 
            this.buttonItalian.Location = new System.Drawing.Point(52, 159);
            this.buttonItalian.Name = "buttonItalian";
            this.buttonItalian.Size = new System.Drawing.Size(106, 45);
            this.buttonItalian.TabIndex = 2;
            this.buttonItalian.Text = "Italian";
            this.buttonItalian.UseVisualStyleBackColor = true;
            this.buttonItalian.Click += new System.EventHandler(this.buttonItalian_Click);
            // 
            // buttonSpanish
            // 
            this.buttonSpanish.Location = new System.Drawing.Point(240, 159);
            this.buttonSpanish.Name = "buttonSpanish";
            this.buttonSpanish.Size = new System.Drawing.Size(96, 45);
            this.buttonSpanish.TabIndex = 3;
            this.buttonSpanish.Text = "Spanish";
            this.buttonSpanish.UseVisualStyleBackColor = true;
            this.buttonSpanish.Click += new System.EventHandler(this.buttonSpanish_Click);
            // 
            // buttonGerman
            // 
            this.buttonGerman.Location = new System.Drawing.Point(395, 159);
            this.buttonGerman.Name = "buttonGerman";
            this.buttonGerman.Size = new System.Drawing.Size(104, 45);
            this.buttonGerman.TabIndex = 4;
            this.buttonGerman.Text = "German";
            this.buttonGerman.UseVisualStyleBackColor = true;
            this.buttonGerman.Click += new System.EventHandler(this.buttonGerman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 258);
            this.Controls.Add(this.buttonGerman);
            this.Controls.Add(this.buttonSpanish);
            this.Controls.Add(this.buttonItalian);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelCommand);
            this.Name = "Form1";
            this.Text = "Language Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonItalian;
        private System.Windows.Forms.Button buttonSpanish;
        private System.Windows.Forms.Button buttonGerman;
    }
}

