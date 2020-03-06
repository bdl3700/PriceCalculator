namespace PriceCalculator
{
    partial class PriceCalculatorGUI
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.AccessoryRB = new System.Windows.Forms.RadioButton();
            this.AmmoRB = new System.Windows.Forms.RadioButton();
            this.FirearmRB = new System.Windows.Forms.RadioButton();
            this.CostTB = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HeaderLabel.Location = new System.Drawing.Point(138, 56);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(304, 46);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Price Calculator";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TypeLabel.Location = new System.Drawing.Point(13, 145);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(81, 36);
            this.TypeLabel.TabIndex = 1;
            this.TypeLabel.Text = "Type";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CostLabel.Location = new System.Drawing.Point(385, 145);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(76, 36);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost";
            // 
            // AccessoryRB
            // 
            this.AccessoryRB.AutoSize = true;
            this.AccessoryRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AccessoryRB.Location = new System.Drawing.Point(19, 211);
            this.AccessoryRB.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.AccessoryRB.Name = "AccessoryRB";
            this.AccessoryRB.Size = new System.Drawing.Size(178, 35);
            this.AccessoryRB.TabIndex = 3;
            this.AccessoryRB.TabStop = true;
            this.AccessoryRB.Text = "Accessory";
            this.AccessoryRB.UseVisualStyleBackColor = true;
            // 
            // AmmoRB
            // 
            this.AmmoRB.AutoSize = true;
            this.AmmoRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AmmoRB.Location = new System.Drawing.Point(19, 279);
            this.AmmoRB.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.AmmoRB.Name = "AmmoRB";
            this.AmmoRB.Size = new System.Drawing.Size(128, 35);
            this.AmmoRB.TabIndex = 4;
            this.AmmoRB.TabStop = true;
            this.AmmoRB.Text = "Ammo";
            this.AmmoRB.UseVisualStyleBackColor = true;
            // 
            // FirearmRB
            // 
            this.FirearmRB.AutoSize = true;
            this.FirearmRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FirearmRB.Location = new System.Drawing.Point(19, 347);
            this.FirearmRB.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.FirearmRB.Name = "FirearmRB";
            this.FirearmRB.Size = new System.Drawing.Size(144, 35);
            this.FirearmRB.TabIndex = 5;
            this.FirearmRB.TabStop = true;
            this.FirearmRB.Text = "Firearm";
            this.FirearmRB.UseVisualStyleBackColor = true;
            // 
            // CostTB
            // 
            this.CostTB.BackColor = System.Drawing.Color.White;
            this.CostTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CostTB.Location = new System.Drawing.Point(391, 207);
            this.CostTB.Name = "CostTB";
            this.CostTB.Size = new System.Drawing.Size(130, 38);
            this.CostTB.TabIndex = 7;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(385, 278);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(87, 32);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalTB
            // 
            this.TotalTB.BackColor = System.Drawing.Color.White;
            this.TotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.TotalTB.Location = new System.Drawing.Point(391, 347);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(130, 38);
            this.TotalTB.TabIndex = 10;
            this.TotalTB.ReadOnly = true;
            // 
            // PriceCalculatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 512);
            this.Controls.Add(this.TotalTB);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.CostTB);
            this.Controls.Add(this.FirearmRB);
            this.Controls.Add(this.AmmoRB);
            this.Controls.Add(this.AccessoryRB);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.HeaderLabel);
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "PriceCalculatorGUI";
            this.Text = "Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.RadioButton AccessoryRB;
        private System.Windows.Forms.RadioButton AmmoRB;
        private System.Windows.Forms.RadioButton FirearmRB;
        private System.Windows.Forms.TextBox CostTB;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTB;
    }
}

