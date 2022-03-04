namespace Change_Counter
{
    partial class ChangeCounter
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
            this.IntsructionLabel = new System.Windows.Forms.Label();
            this.OutputDescriptionLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TenCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.TwentyFiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.FiftyCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.FiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TenCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwentyFiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiftyCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiveCentsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IntsructionLabel
            // 
            this.IntsructionLabel.AutoSize = true;
            this.IntsructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntsructionLabel.Location = new System.Drawing.Point(140, 9);
            this.IntsructionLabel.Name = "IntsructionLabel";
            this.IntsructionLabel.Size = new System.Drawing.Size(153, 25);
            this.IntsructionLabel.TabIndex = 0;
            this.IntsructionLabel.Text = "Click the coins";
            // 
            // OutputDescriptionLabel
            // 
            this.OutputDescriptionLabel.AutoSize = true;
            this.OutputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputDescriptionLabel.Location = new System.Drawing.Point(386, 108);
            this.OutputDescriptionLabel.Name = "OutputDescriptionLabel";
            this.OutputDescriptionLabel.Size = new System.Drawing.Size(45, 17);
            this.OutputDescriptionLabel.TabIndex = 1;
            this.OutputDescriptionLabel.Text = "Total";
            // 
            // TotalLabel
            // 
            this.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLabel.Location = new System.Drawing.Point(369, 152);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(84, 40);
            this.TotalLabel.TabIndex = 2;
//            this.TotalLabel.Click += new System.EventHandler(this.TotalLabel_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(166, 275);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(91, 42);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TenCentsPictureBox
            // 
            this.TenCentsPictureBox.BackgroundImage = global::Change_Counter.Properties.Resources._10cents;
            this.TenCentsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TenCentsPictureBox.Location = new System.Drawing.Point(225, 67);
            this.TenCentsPictureBox.Name = "TenCentsPictureBox";
            this.TenCentsPictureBox.Size = new System.Drawing.Size(111, 79);
            this.TenCentsPictureBox.TabIndex = 7;
            this.TenCentsPictureBox.TabStop = false;
            this.TenCentsPictureBox.Click += new System.EventHandler(this.TenCentsPictureBox_Click);
            // 
            // TwentyFiveCentsPictureBox
            // 
            this.TwentyFiveCentsPictureBox.BackgroundImage = global::Change_Counter.Properties.Resources._25cents;
            this.TwentyFiveCentsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TwentyFiveCentsPictureBox.Location = new System.Drawing.Point(54, 168);
            this.TwentyFiveCentsPictureBox.Name = "TwentyFiveCentsPictureBox";
            this.TwentyFiveCentsPictureBox.Size = new System.Drawing.Size(120, 72);
            this.TwentyFiveCentsPictureBox.TabIndex = 6;
            this.TwentyFiveCentsPictureBox.TabStop = false;
            this.TwentyFiveCentsPictureBox.Click += new System.EventHandler(this.TwentyFiveCentsPictureBox_Click);
            // 
            // FiftyCentsPictureBox
            // 
            this.FiftyCentsPictureBox.BackgroundImage = global::Change_Counter.Properties.Resources._50cents;
            this.FiftyCentsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FiftyCentsPictureBox.Location = new System.Drawing.Point(225, 168);
            this.FiftyCentsPictureBox.Name = "FiftyCentsPictureBox";
            this.FiftyCentsPictureBox.Size = new System.Drawing.Size(111, 72);
            this.FiftyCentsPictureBox.TabIndex = 5;
            this.FiftyCentsPictureBox.TabStop = false;
            this.FiftyCentsPictureBox.Click += new System.EventHandler(this.FiftyCentsPictureBox_Click);
            // 
            // FiveCentsPictureBox
            // 
            this.FiveCentsPictureBox.BackgroundImage = global::Change_Counter.Properties.Resources._5cents;
            this.FiveCentsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FiveCentsPictureBox.Location = new System.Drawing.Point(54, 67);
            this.FiveCentsPictureBox.Name = "FiveCentsPictureBox";
            this.FiveCentsPictureBox.Size = new System.Drawing.Size(120, 79);
            this.FiveCentsPictureBox.TabIndex = 4;
            this.FiveCentsPictureBox.TabStop = false;
            this.FiveCentsPictureBox.Click += new System.EventHandler(this.FiveCentsPictureBox_Click);
            // 
            // ChangeCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 347);
            this.Controls.Add(this.TenCentsPictureBox);
            this.Controls.Add(this.TwentyFiveCentsPictureBox);
            this.Controls.Add(this.FiftyCentsPictureBox);
            this.Controls.Add(this.FiveCentsPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.OutputDescriptionLabel);
            this.Controls.Add(this.IntsructionLabel);
            this.Name = "ChangeCounter";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.TenCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwentyFiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiftyCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiveCentsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IntsructionLabel;
        private System.Windows.Forms.Label OutputDescriptionLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox FiveCentsPictureBox;
        private System.Windows.Forms.PictureBox FiftyCentsPictureBox;
        private System.Windows.Forms.PictureBox TwentyFiveCentsPictureBox;
        private System.Windows.Forms.PictureBox TenCentsPictureBox;
    }
}

