namespace DemoFigure12_13
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
            this.checkBoxOnions = new System.Windows.Forms.CheckBox();
            this.checkBoxGreenPepper = new System.Windows.Forms.CheckBox();
            this.checkBoxPepperoni = new System.Windows.Forms.CheckBox();
            this.checkBoxSausage = new System.Windows.Forms.CheckBox();
            this.radioButtonPickUp = new System.Windows.Forms.RadioButton();
            this.radioButtonDelivery = new System.Windows.Forms.RadioButton();
            this.radioButtonDineIn = new System.Windows.Forms.RadioButton();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Order Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Toppings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dining Options";
            // 
            // checkBoxOnions
            // 
            this.checkBoxOnions.AutoSize = true;
            this.checkBoxOnions.Location = new System.Drawing.Point(32, 161);
            this.checkBoxOnions.Name = "checkBoxOnions";
            this.checkBoxOnions.Size = new System.Drawing.Size(59, 17);
            this.checkBoxOnions.TabIndex = 3;
            this.checkBoxOnions.Text = "Onions";
            this.checkBoxOnions.UseVisualStyleBackColor = true;
            // 
            // checkBoxGreenPepper
            // 
            this.checkBoxGreenPepper.AutoSize = true;
            this.checkBoxGreenPepper.Location = new System.Drawing.Point(32, 196);
            this.checkBoxGreenPepper.Name = "checkBoxGreenPepper";
            this.checkBoxGreenPepper.Size = new System.Drawing.Size(92, 17);
            this.checkBoxGreenPepper.TabIndex = 4;
            this.checkBoxGreenPepper.Text = "Green Pepper";
            this.checkBoxGreenPepper.UseVisualStyleBackColor = true;
            // 
            // checkBoxPepperoni
            // 
            this.checkBoxPepperoni.AutoSize = true;
            this.checkBoxPepperoni.Location = new System.Drawing.Point(32, 235);
            this.checkBoxPepperoni.Name = "checkBoxPepperoni";
            this.checkBoxPepperoni.Size = new System.Drawing.Size(74, 17);
            this.checkBoxPepperoni.TabIndex = 5;
            this.checkBoxPepperoni.Text = "Pepperoni";
            this.checkBoxPepperoni.UseVisualStyleBackColor = true;
            // 
            // checkBoxSausage
            // 
            this.checkBoxSausage.AutoSize = true;
            this.checkBoxSausage.Location = new System.Drawing.Point(32, 276);
            this.checkBoxSausage.Name = "checkBoxSausage";
            this.checkBoxSausage.Size = new System.Drawing.Size(68, 17);
            this.checkBoxSausage.TabIndex = 6;
            this.checkBoxSausage.Text = "Sausage";
            this.checkBoxSausage.UseVisualStyleBackColor = true;
            this.checkBoxSausage.CheckedChanged += new System.EventHandler(this.checkBoxSausage_CheckedChanged);
            // 
            // radioButtonPickUp
            // 
            this.radioButtonPickUp.AutoSize = true;
            this.radioButtonPickUp.Location = new System.Drawing.Point(186, 161);
            this.radioButtonPickUp.Name = "radioButtonPickUp";
            this.radioButtonPickUp.Size = new System.Drawing.Size(63, 17);
            this.radioButtonPickUp.TabIndex = 7;
            this.radioButtonPickUp.TabStop = true;
            this.radioButtonPickUp.Text = "Pick Up";
            this.radioButtonPickUp.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelivery
            // 
            this.radioButtonDelivery.AutoSize = true;
            this.radioButtonDelivery.Location = new System.Drawing.Point(186, 196);
            this.radioButtonDelivery.Name = "radioButtonDelivery";
            this.radioButtonDelivery.Size = new System.Drawing.Size(63, 17);
            this.radioButtonDelivery.TabIndex = 8;
            this.radioButtonDelivery.TabStop = true;
            this.radioButtonDelivery.Text = "Delivery";
            this.radioButtonDelivery.UseVisualStyleBackColor = true;
            // 
            // radioButtonDineIn
            // 
            this.radioButtonDineIn.AutoSize = true;
            this.radioButtonDineIn.Location = new System.Drawing.Point(186, 235);
            this.radioButtonDineIn.Name = "radioButtonDineIn";
            this.radioButtonDineIn.Size = new System.Drawing.Size(59, 17);
            this.radioButtonDineIn.TabIndex = 9;
            this.radioButtonDineIn.TabStop = true;
            this.radioButtonDineIn.Text = "Dine In";
            this.radioButtonDineIn.UseVisualStyleBackColor = true;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(186, 276);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 316);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.radioButtonDineIn);
            this.Controls.Add(this.radioButtonDelivery);
            this.Controls.Add(this.radioButtonPickUp);
            this.Controls.Add(this.checkBoxSausage);
            this.Controls.Add(this.checkBoxPepperoni);
            this.Controls.Add(this.checkBoxGreenPepper);
            this.Controls.Add(this.checkBoxOnions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxOnions;
        private System.Windows.Forms.CheckBox checkBoxGreenPepper;
        private System.Windows.Forms.CheckBox checkBoxPepperoni;
        private System.Windows.Forms.CheckBox checkBoxSausage;
        private System.Windows.Forms.RadioButton radioButtonPickUp;
        private System.Windows.Forms.RadioButton radioButtonDelivery;
        private System.Windows.Forms.RadioButton radioButtonDineIn;
        private System.Windows.Forms.Label outputLabel;
    }
}

