namespace Card_Flip
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
            this.CardFacePictureBox = new System.Windows.Forms.PictureBox();
            this.CardBackPictureBox = new System.Windows.Forms.PictureBox();
            this.ShowBackButton = new System.Windows.Forms.Button();
            this.ShowFaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CardFacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CardFacePictureBox
            // 
            this.CardFacePictureBox.BackgroundImage = global::Card_Flip.Properties.Resources.Ace_Spades;
            this.CardFacePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CardFacePictureBox.Location = new System.Drawing.Point(402, 51);
            this.CardFacePictureBox.Name = "CardFacePictureBox";
            this.CardFacePictureBox.Size = new System.Drawing.Size(149, 223);
            this.CardFacePictureBox.TabIndex = 1;
            this.CardFacePictureBox.TabStop = false;
            this.CardFacePictureBox.Visible = false;
            this.CardFacePictureBox.Click += new System.EventHandler(this.CardFacePictureBox_Click);
            // 
            // CardBackPictureBox
            // 
            this.CardBackPictureBox.BackgroundImage = global::Card_Flip.Properties.Resources.Backface_Blue;
            this.CardBackPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CardBackPictureBox.Location = new System.Drawing.Point(78, 51);
            this.CardBackPictureBox.Name = "CardBackPictureBox";
            this.CardBackPictureBox.Size = new System.Drawing.Size(149, 223);
            this.CardBackPictureBox.TabIndex = 0;
            this.CardBackPictureBox.TabStop = false;
            this.CardBackPictureBox.Visible = false;
            this.CardBackPictureBox.Click += new System.EventHandler(this.CardBackPictureBox_Click);
            // 
            // ShowBackButton
            // 
            this.ShowBackButton.Location = new System.Drawing.Point(78, 300);
            this.ShowBackButton.Name = "ShowBackButton";
            this.ShowBackButton.Size = new System.Drawing.Size(149, 50);
            this.ShowBackButton.TabIndex = 2;
            this.ShowBackButton.Text = "Show the Card Back";
            this.ShowBackButton.UseVisualStyleBackColor = true;
            this.ShowBackButton.Click += new System.EventHandler(this.ShowBackButton_Click);
            // 
            // ShowFaceButton
            // 
            this.ShowFaceButton.Location = new System.Drawing.Point(402, 300);
            this.ShowFaceButton.Name = "ShowFaceButton";
            this.ShowFaceButton.Size = new System.Drawing.Size(149, 50);
            this.ShowFaceButton.TabIndex = 3;
            this.ShowFaceButton.Text = "Show the Card Face";
            this.ShowFaceButton.UseVisualStyleBackColor = true;
            this.ShowFaceButton.Click += new System.EventHandler(this.ShowFaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 401);
            this.Controls.Add(this.ShowFaceButton);
            this.Controls.Add(this.ShowBackButton);
            this.Controls.Add(this.CardFacePictureBox);
            this.Controls.Add(this.CardBackPictureBox);
            this.Name = "Form1";
            this.Text = "Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.CardFacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CardBackPictureBox;
        private System.Windows.Forms.PictureBox CardFacePictureBox;
        private System.Windows.Forms.Button ShowBackButton;
        private System.Windows.Forms.Button ShowFaceButton;
    }
}

