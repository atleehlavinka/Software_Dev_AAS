
namespace ManyButtons___634
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
            this.redButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.favoriteColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(14, 15);
            this.redButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(84, 29);
            this.redButton.TabIndex = 0;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.Location = new System.Drawing.Point(105, 15);
            this.whiteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(84, 29);
            this.whiteButton.TabIndex = 1;
            this.whiteButton.Text = "White";
            this.whiteButton.UseVisualStyleBackColor = true;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.Location = new System.Drawing.Point(196, 15);
            this.blueButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(84, 29);
            this.blueButton.TabIndex = 2;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // favoriteColor
            // 
            this.favoriteColor.Location = new System.Drawing.Point(287, 15);
            this.favoriteColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.favoriteColor.Name = "favoriteColor";
            this.favoriteColor.Size = new System.Drawing.Size(156, 29);
            this.favoriteColor.TabIndex = 3;
            this.favoriteColor.Text = "My Favorite Color";
            this.favoriteColor.UseVisualStyleBackColor = true;
            this.favoriteColor.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 124);
            this.Controls.Add(this.favoriteColor);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.redButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button favoriteColor;
    }
}

