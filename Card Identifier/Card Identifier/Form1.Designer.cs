namespace Card_Identifier
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
            this.JokerPictureBox = new System.Windows.Forms.PictureBox();
            this.AceOfHeatrsPictureBox = new System.Windows.Forms.PictureBox();
            this.KingOfDiamondsPictureBox = new System.Windows.Forms.PictureBox();
            this.JackOfSpadesPictureBox = new System.Windows.Forms.PictureBox();
            this.TwoOfSpadesPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.JokerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AceOfHeatrsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KingOfDiamondsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JackOfSpadesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoOfSpadesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommand.Location = new System.Drawing.Point(94, 29);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(433, 39);
            this.labelCommand.TabIndex = 0;
            this.labelCommand.Text = "Click a card to see its name";
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(101, 299);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(426, 56);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JokerPictureBox
            // 
            this.JokerPictureBox.BackgroundImage = global::Card_Identifier.Properties.Resources.Joker_Red;
            this.JokerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JokerPictureBox.Location = new System.Drawing.Point(524, 81);
            this.JokerPictureBox.Name = "JokerPictureBox";
            this.JokerPictureBox.Size = new System.Drawing.Size(103, 168);
            this.JokerPictureBox.TabIndex = 6;
            this.JokerPictureBox.TabStop = false;
            this.JokerPictureBox.Click += new System.EventHandler(this.JokerPictureBox_Click);
            // 
            // AceOfHeatrsPictureBox
            // 
            this.AceOfHeatrsPictureBox.BackgroundImage = global::Card_Identifier.Properties.Resources.Ace_Hearts;
            this.AceOfHeatrsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AceOfHeatrsPictureBox.Location = new System.Drawing.Point(396, 81);
            this.AceOfHeatrsPictureBox.Name = "AceOfHeatrsPictureBox";
            this.AceOfHeatrsPictureBox.Size = new System.Drawing.Size(103, 168);
            this.AceOfHeatrsPictureBox.TabIndex = 5;
            this.AceOfHeatrsPictureBox.TabStop = false;
            this.AceOfHeatrsPictureBox.Click += new System.EventHandler(this.AceOfHeatrsPictureBox_Click);
            // 
            // KingOfDiamondsPictureBox
            // 
            this.KingOfDiamondsPictureBox.BackgroundImage = global::Card_Identifier.Properties.Resources.King_Diamonds;
            this.KingOfDiamondsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KingOfDiamondsPictureBox.Location = new System.Drawing.Point(140, 81);
            this.KingOfDiamondsPictureBox.Name = "KingOfDiamondsPictureBox";
            this.KingOfDiamondsPictureBox.Size = new System.Drawing.Size(103, 168);
            this.KingOfDiamondsPictureBox.TabIndex = 4;
            this.KingOfDiamondsPictureBox.TabStop = false;
            this.KingOfDiamondsPictureBox.Click += new System.EventHandler(this.KingOfDiamondsPictureBox_Click);
            // 
            // JackOfSpadesPictureBox
            // 
            this.JackOfSpadesPictureBox.BackgroundImage = global::Card_Identifier.Properties.Resources.Jack_Spades;
            this.JackOfSpadesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JackOfSpadesPictureBox.Location = new System.Drawing.Point(264, 81);
            this.JackOfSpadesPictureBox.Name = "JackOfSpadesPictureBox";
            this.JackOfSpadesPictureBox.Size = new System.Drawing.Size(103, 168);
            this.JackOfSpadesPictureBox.TabIndex = 3;
            this.JackOfSpadesPictureBox.TabStop = false;
            this.JackOfSpadesPictureBox.Click += new System.EventHandler(this.JackOfSpadesPictureBox_Click);
            // 
            // TwoOfSpadesPictureBox
            // 
            this.TwoOfSpadesPictureBox.BackgroundImage = global::Card_Identifier.Properties.Resources._2_Clubs;
            this.TwoOfSpadesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TwoOfSpadesPictureBox.Location = new System.Drawing.Point(12, 81);
            this.TwoOfSpadesPictureBox.Name = "TwoOfSpadesPictureBox";
            this.TwoOfSpadesPictureBox.Size = new System.Drawing.Size(103, 168);
            this.TwoOfSpadesPictureBox.TabIndex = 2;
            this.TwoOfSpadesPictureBox.TabStop = false;
            this.TwoOfSpadesPictureBox.Click += new System.EventHandler(this.TwoOfSpadesPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 407);
            this.Controls.Add(this.JokerPictureBox);
            this.Controls.Add(this.AceOfHeatrsPictureBox);
            this.Controls.Add(this.KingOfDiamondsPictureBox);
            this.Controls.Add(this.JackOfSpadesPictureBox);
            this.Controls.Add(this.TwoOfSpadesPictureBox);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelCommand);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.JokerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AceOfHeatrsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KingOfDiamondsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JackOfSpadesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoOfSpadesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.PictureBox TwoOfSpadesPictureBox;
        private System.Windows.Forms.PictureBox JackOfSpadesPictureBox;
        private System.Windows.Forms.PictureBox KingOfDiamondsPictureBox;
        private System.Windows.Forms.PictureBox AceOfHeatrsPictureBox;
        private System.Windows.Forms.PictureBox JokerPictureBox;
    }
}

