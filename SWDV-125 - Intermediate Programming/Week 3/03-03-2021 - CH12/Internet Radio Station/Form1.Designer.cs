
namespace Internet_Radio_Station
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noComm = new System.Windows.Forms.RadioButton();
            this.limitComm = new System.Windows.Forms.RadioButton();
            this.withComm = new System.Windows.Forms.RadioButton();
            this.classical = new System.Windows.Forms.CheckBox();
            this.country = new System.Windows.Forms.CheckBox();
            this.jazz = new System.Windows.Forms.CheckBox();
            this.rock = new System.Windows.Forms.CheckBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Internet Radio Station";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select the subscription\r\nplan you prefer\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select the music genres\r\nyou want for your\r\npersonal station\r\n";
            // 
            // noComm
            // 
            this.noComm.AutoSize = true;
            this.noComm.Location = new System.Drawing.Point(48, 164);
            this.noComm.Name = "noComm";
            this.noComm.Size = new System.Drawing.Size(100, 17);
            this.noComm.TabIndex = 3;
            this.noComm.TabStop = true;
            this.noComm.Text = "Commercial-free";
            this.noComm.UseVisualStyleBackColor = true;
            this.noComm.CheckedChanged += new System.EventHandler(this.noComm_CheckedChanged);
            // 
            // limitComm
            // 
            this.limitComm.AutoSize = true;
            this.limitComm.Location = new System.Drawing.Point(48, 203);
            this.limitComm.Name = "limitComm";
            this.limitComm.Size = new System.Drawing.Size(120, 17);
            this.limitComm.TabIndex = 4;
            this.limitComm.TabStop = true;
            this.limitComm.Text = "Limited Commercials";
            this.limitComm.UseVisualStyleBackColor = true;
            this.limitComm.CheckedChanged += new System.EventHandler(this.limitComm_CheckedChanged);
            // 
            // withComm
            // 
            this.withComm.AutoSize = true;
            this.withComm.Location = new System.Drawing.Point(48, 240);
            this.withComm.Name = "withComm";
            this.withComm.Size = new System.Drawing.Size(109, 17);
            this.withComm.TabIndex = 5;
            this.withComm.TabStop = true;
            this.withComm.Text = "With Commercials";
            this.withComm.UseVisualStyleBackColor = true;
            this.withComm.CheckedChanged += new System.EventHandler(this.withComm_CheckedChanged);
            // 
            // classical
            // 
            this.classical.AutoSize = true;
            this.classical.Location = new System.Drawing.Point(257, 164);
            this.classical.Name = "classical";
            this.classical.Size = new System.Drawing.Size(67, 17);
            this.classical.TabIndex = 6;
            this.classical.Text = "Classical";
            this.classical.UseVisualStyleBackColor = true;
            this.classical.CheckedChanged += new System.EventHandler(this.classical_CheckedChanged);
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(257, 204);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(62, 17);
            this.country.TabIndex = 7;
            this.country.Text = "Country";
            this.country.UseVisualStyleBackColor = true;
            this.country.CheckedChanged += new System.EventHandler(this.country_CheckedChanged);
            // 
            // jazz
            // 
            this.jazz.AutoSize = true;
            this.jazz.Location = new System.Drawing.Point(257, 241);
            this.jazz.Name = "jazz";
            this.jazz.Size = new System.Drawing.Size(47, 17);
            this.jazz.TabIndex = 8;
            this.jazz.Text = "Jazz";
            this.jazz.UseVisualStyleBackColor = true;
            this.jazz.CheckedChanged += new System.EventHandler(this.jazz_CheckedChanged);
            // 
            // rock
            // 
            this.rock.AutoSize = true;
            this.rock.Location = new System.Drawing.Point(257, 281);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(52, 17);
            this.rock.TabIndex = 9;
            this.rock.Text = "Rock";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.CheckedChanged += new System.EventHandler(this.rock_CheckedChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(43, 342);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(19, 25);
            this.outputLabel.TabIndex = 10;
            this.outputLabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 390);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.jazz);
            this.Controls.Add(this.country);
            this.Controls.Add(this.classical);
            this.Controls.Add(this.withComm);
            this.Controls.Add(this.limitComm);
            this.Controls.Add(this.noComm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton noComm;
        private System.Windows.Forms.RadioButton limitComm;
        private System.Windows.Forms.RadioButton withComm;
        private System.Windows.Forms.CheckBox classical;
        private System.Windows.Forms.CheckBox country;
        private System.Windows.Forms.CheckBox jazz;
        private System.Windows.Forms.CheckBox rock;
        private System.Windows.Forms.Label outputLabel;
    }
}

