namespace Calorie_Counter
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
            this.inputPromptLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.pearPictureBox = new System.Windows.Forms.PictureBox();
            this.orangePictureBox = new System.Windows.Forms.PictureBox();
            this.cherryPictureBox = new System.Windows.Forms.PictureBox();
            this.bananaPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pearPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPromptLabel
            // 
            this.inputPromptLabel.AutoSize = true;
            this.inputPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPromptLabel.Location = new System.Drawing.Point(308, 42);
            this.inputPromptLabel.Name = "inputPromptLabel";
            this.inputPromptLabel.Size = new System.Drawing.Size(114, 17);
            this.inputPromptLabel.TabIndex = 4;
            this.inputPromptLabel.Text = "Total Calories:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(311, 91);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 23);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(311, 272);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(311, 208);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 33);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pearPictureBox
            // 
            this.pearPictureBox.BackgroundImage = global::Calorie_Counter.Properties.Resources.PearCalories;
            this.pearPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pearPictureBox.Location = new System.Drawing.Point(158, 193);
            this.pearPictureBox.Name = "pearPictureBox";
            this.pearPictureBox.Size = new System.Drawing.Size(121, 142);
            this.pearPictureBox.TabIndex = 3;
            this.pearPictureBox.TabStop = false;
            this.pearPictureBox.Click += new System.EventHandler(this.pearPictureBox_Click);
            // 
            // orangePictureBox
            // 
            this.orangePictureBox.BackgroundImage = global::Calorie_Counter.Properties.Resources.OrangeCalories;
            this.orangePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orangePictureBox.Location = new System.Drawing.Point(21, 193);
            this.orangePictureBox.Name = "orangePictureBox";
            this.orangePictureBox.Size = new System.Drawing.Size(131, 142);
            this.orangePictureBox.TabIndex = 2;
            this.orangePictureBox.TabStop = false;
            this.orangePictureBox.Click += new System.EventHandler(this.orangePictureBox_Click);
            // 
            // cherryPictureBox
            // 
            this.cherryPictureBox.BackgroundImage = global::Calorie_Counter.Properties.Resources.AppleCalories;
            this.cherryPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cherryPictureBox.Location = new System.Drawing.Point(158, 28);
            this.cherryPictureBox.Name = "cherryPictureBox";
            this.cherryPictureBox.Size = new System.Drawing.Size(121, 159);
            this.cherryPictureBox.TabIndex = 1;
            this.cherryPictureBox.TabStop = false;
            this.cherryPictureBox.Click += new System.EventHandler(this.cherryPictureBox_Click);
            // 
            // bananaPictureBox
            // 
            this.bananaPictureBox.BackgroundImage = global::Calorie_Counter.Properties.Resources.BananaCalories;
            this.bananaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bananaPictureBox.Location = new System.Drawing.Point(21, 28);
            this.bananaPictureBox.Name = "bananaPictureBox";
            this.bananaPictureBox.Size = new System.Drawing.Size(131, 159);
            this.bananaPictureBox.TabIndex = 0;
            this.bananaPictureBox.TabStop = false;
            this.bananaPictureBox.Click += new System.EventHandler(this.bananaPictureBox_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.resetButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(425, 356);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputPromptLabel);
            this.Controls.Add(this.pearPictureBox);
            this.Controls.Add(this.orangePictureBox);
            this.Controls.Add(this.cherryPictureBox);
            this.Controls.Add(this.bananaPictureBox);
            this.Name = "Form1";
            this.Text = "Calorie Counter";
            ((System.ComponentModel.ISupportInitialize)(this.pearPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bananaPictureBox;
        private System.Windows.Forms.PictureBox cherryPictureBox;
        private System.Windows.Forms.PictureBox orangePictureBox;
        private System.Windows.Forms.PictureBox pearPictureBox;
        private System.Windows.Forms.Label inputPromptLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
    }
}

