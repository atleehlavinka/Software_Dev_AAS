
namespace MovieSelector
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
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.outputAllTimes = new System.Windows.Forms.Label();
            this.outputMovieTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Movie";
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.Items.AddRange(new object[] {
            "Thor: Ragnarok",
            "Dunkirk",
            "Alien: Covenant",
            "War for the Planet of the Apes"});
            this.listBoxMovies.Location = new System.Drawing.Point(208, 143);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(153, 147);
            this.listBoxMovies.TabIndex = 1;
            this.listBoxMovies.SelectedIndexChanged += new System.EventHandler(this.listBoxMovies_SelectedIndexChanged);
            this.listBoxMovies.MouseEnter += new System.EventHandler(this.listBoxMovies_MouseEnter);
            this.listBoxMovies.MouseLeave += new System.EventHandler(this.listBoxMovies_MouseLeave);
            // 
            // outputAllTimes
            // 
            this.outputAllTimes.AutoSize = true;
            this.outputAllTimes.Location = new System.Drawing.Point(452, 143);
            this.outputAllTimes.Name = "outputAllTimes";
            this.outputAllTimes.Size = new System.Drawing.Size(0, 13);
            this.outputAllTimes.TabIndex = 2;
            // 
            // outputMovieTime
            // 
            this.outputMovieTime.AutoSize = true;
            this.outputMovieTime.Location = new System.Drawing.Point(118, 336);
            this.outputMovieTime.Name = "outputMovieTime";
            this.outputMovieTime.Size = new System.Drawing.Size(0, 13);
            this.outputMovieTime.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 447);
            this.Controls.Add(this.outputMovieTime);
            this.Controls.Add(this.outputAllTimes);
            this.Controls.Add(this.listBoxMovies);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMovies;
        private System.Windows.Forms.Label outputAllTimes;
        private System.Windows.Forms.Label outputMovieTime;
    }
}

