
namespace MyTunes
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
            this.label1 = new System.Windows.Forms.Label();
            this.songsListBox = new System.Windows.Forms.ListBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "        Make as many selections as you want by\r\n                       holding do" +
    "wn the Ctrl Key\r\nClick the Done Button after making your selections";
            // 
            // songsListBox
            // 
            this.songsListBox.FormattingEnabled = true;
            this.songsListBox.Items.AddRange(new object[] {
            "Linkin Park - Numb",
            "Six A.M. - We Will Not Go Quietly",
            "Skillet - Feel Invincible",
            "Yelawolf - Till It\'s Gone",
            "Nine Inch Nails - Somewhat Damaged",
            "You Me At Six - Room To Breathe",
            "Dorothy - Raise Hell",
            "Nonpoint - Left For You",
            "Santana - Put Your Lights On"});
            this.songsListBox.Location = new System.Drawing.Point(16, 78);
            this.songsListBox.Name = "songsListBox";
            this.songsListBox.Size = new System.Drawing.Size(242, 134);
            this.songsListBox.TabIndex = 1;
            this.songsListBox.SelectedIndexChanged += new System.EventHandler(this.songsListBox_SelectedIndexChanged);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(100, 231);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 2;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(13, 268);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 16);
            this.outputLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 333);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.songsListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox songsListBox;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label outputLabel;
    }
}

