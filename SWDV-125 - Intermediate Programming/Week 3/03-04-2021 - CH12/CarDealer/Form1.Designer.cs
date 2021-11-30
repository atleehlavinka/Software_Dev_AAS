
namespace CarDealer
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
            this.elite = new System.Windows.Forms.CheckBox();
            this.cheetah = new System.Windows.Forms.CheckBox();
            this.centsible = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read about our new models:";
            // 
            // elite
            // 
            this.elite.AutoSize = true;
            this.elite.Location = new System.Drawing.Point(15, 46);
            this.elite.Name = "elite";
            this.elite.Size = new System.Drawing.Size(46, 17);
            this.elite.TabIndex = 1;
            this.elite.Text = "Elite";
            this.elite.UseVisualStyleBackColor = true;
            this.elite.CheckedChanged += new System.EventHandler(this.elite_CheckedChanged);
            // 
            // cheetah
            // 
            this.cheetah.AutoSize = true;
            this.cheetah.Location = new System.Drawing.Point(15, 78);
            this.cheetah.Name = "cheetah";
            this.cheetah.Size = new System.Drawing.Size(66, 17);
            this.cheetah.TabIndex = 2;
            this.cheetah.Text = "Cheetah";
            this.cheetah.UseVisualStyleBackColor = true;
            this.cheetah.CheckedChanged += new System.EventHandler(this.cheetah_CheckedChanged);
            // 
            // centsible
            // 
            this.centsible.AutoSize = true;
            this.centsible.Location = new System.Drawing.Point(15, 113);
            this.centsible.Name = "centsible";
            this.centsible.Size = new System.Drawing.Size(69, 17);
            this.centsible.TabIndex = 3;
            this.centsible.Text = "Centsible";
            this.centsible.UseVisualStyleBackColor = true;
            this.centsible.CheckedChanged += new System.EventHandler(this.centsible_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 222);
            this.Controls.Add(this.centsible);
            this.Controls.Add(this.cheetah);
            this.Controls.Add(this.elite);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Car Dealer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox elite;
        private System.Windows.Forms.CheckBox cheetah;
        private System.Windows.Forms.CheckBox centsible;
    }
}

