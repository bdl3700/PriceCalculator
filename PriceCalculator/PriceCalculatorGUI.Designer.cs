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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceCalculatorGUI));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AccessoryRB = new System.Windows.Forms.RadioButton();
            this.AmmoRB = new System.Windows.Forms.RadioButton();
            this.FirearmRB = new System.Windows.Forms.RadioButton();
            this.NFAItemRB = new System.Windows.Forms.RadioButton();
            this.AddBCICheckBox = new System.Windows.Forms.CheckBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTB = new System.Windows.Forms.TextBox();
            this.RetailPriceLabel = new System.Windows.Forms.Label();
            this.RetailPriceTB = new System.Windows.Forms.TextBox();
            this.QuantityXLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SubTotalTB = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HeaderLabel.Location = new System.Drawing.Point(200, 56);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(304, 46);
            this.HeaderLabel.Text = "Price Calculator";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TypeLabel.Location = new System.Drawing.Point(13, 145);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(81, 36);
            this.TypeLabel.Text = "Type";
            // 
            // AccessoryRB
            // 
            this.AccessoryRB.AutoSize = true;
            this.AccessoryRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AccessoryRB.Location = new System.Drawing.Point(19, 211);
            this.AccessoryRB.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.AccessoryRB.Name = "AccessoryRB";
            this.AccessoryRB.Size = new System.Drawing.Size(178, 35);
            this.AccessoryRB.TabIndex = 2;
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
            this.AmmoRB.TabIndex = 3;
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
            this.FirearmRB.TabIndex = 4;
            this.FirearmRB.TabStop = true;
            this.FirearmRB.Text = "Firearm";
            this.FirearmRB.UseVisualStyleBackColor = true;
            //
            // NFAItemRB
            //
            this.NFAItemRB.AutoSize = true;
            this.NFAItemRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.NFAItemRB.Location = new System.Drawing.Point(19, 415);
            this.NFAItemRB.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.NFAItemRB.Name = "NFAItemRB";
            this.NFAItemRB.Size = new System.Drawing.Size(144, 35);
            this.NFAItemRB.TabIndex = 5;
            this.NFAItemRB.TabStop = true;
            this.NFAItemRB.Text = "NFA Item";
            this.NFAItemRB.UseVisualStyleBackColor = true;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CostLabel.Location = new System.Drawing.Point(385, 145);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(76, 36);
            this.CostLabel.Text = "Cost:";
            // 
            // CostTB
            // 
            this.CostTB.BackColor = System.Drawing.Color.White;
            this.CostTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CostTB.Location = new System.Drawing.Point(391, 195);
            this.CostTB.Name = "CostTB";
            this.CostTB.Size = new System.Drawing.Size(130, 38);
            this.CostTB.TabIndex = 0;
            // 
            // RetailPriceLabel
            // 
            this.RetailPriceLabel.AutoSize = true;
            this.RetailPriceLabel.Location = new System.Drawing.Point(385, 295);
            this.RetailPriceLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.RetailPriceLabel.Name = "RetailPriceLabel";
            this.RetailPriceLabel.Size = new System.Drawing.Size(87, 32);
            this.RetailPriceLabel.Text = "Retail Price:";
            // 
            // RetailPriceTB
            // 
            this.RetailPriceTB.BackColor = System.Drawing.Color.White;
            this.RetailPriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RetailPriceTB.Location = new System.Drawing.Point(391, 345);
            this.RetailPriceTB.Name = "RetailPriceTB";
            this.RetailPriceTB.ReadOnly = true;
            this.RetailPriceTB.Size = new System.Drawing.Size(130, 38);
            this.RetailPriceTB.TabStop = false;
            //
            // QuantityXLabel
            //
            this.QuantityXLabel.AutoSize = true;
            this.QuantityXLabel.Location = new System.Drawing.Point(533, 345);
            this.QuantityXLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.QuantityXLabel.Name = "QuantityXLabel";
            this.QuantityXLabel.Size = new System.Drawing.Size(85, 32);
            this.QuantityXLabel.Text = "x";
            //
            // QuantityLabel
            //
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(565, 295);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(85, 32);
            this.QuantityLabel.Text = "Quantity:";
            //
            // QuantityTB
            //
            this.QuantityTB.BackColor = System.Drawing.Color.White;
            this.QuantityTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.QuantityTB.Location = new System.Drawing.Point(571, 345);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(85, 38);
            this.QuantityTB.TabIndex = 1;
            this.QuantityTB.Text = "1";
            //
            // SubTotalLabel
            //
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(385, 435);
            this.SubTotalLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(87, 32);
            this.SubTotalLabel.Text = "SubTotal:";
            //
            // SubTotalTB
            //
            this.SubTotalTB.BackColor = System.Drawing.Color.White;
            this.SubTotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SubTotalTB.Location = new System.Drawing.Point(391, 485);
            this.SubTotalTB.Name = "SubTotalTB";
            this.SubTotalTB.ReadOnly = true;
            this.SubTotalTB.Size = new System.Drawing.Size(130, 38);
            this.SubTotalTB.TabStop = false;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(385, 575);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(87, 32);
            this.TotalLabel.Text = "Total W/ Tax:";
            // 
            // TotalTB
            // 
            this.TotalTB.BackColor = System.Drawing.Color.White;
            this.TotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.TotalTB.Location = new System.Drawing.Point(391, 625);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.ReadOnly = true;
            this.TotalTB.Size = new System.Drawing.Size(130, 38);
            this.TotalTB.TabStop = false;
            //
            // AddBCICheckBox
            //
            this.AddBCICheckBox.AutoSize = true;
            this.AddBCICheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddBCICheckBox.Location = new System.Drawing.Point(19, 483);
            this.AddBCICheckBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.AddBCICheckBox.Name = "AddBCICheckBox";
            this.AddBCICheckBox.Size = new System.Drawing.Size(144, 35);
            this.AddBCICheckBox.TabIndex = 5;
            this.AddBCICheckBox.TabStop = true;
            this.AddBCICheckBox.Text = "Add BCI Check";
            this.AddBCICheckBox.UseVisualStyleBackColor = true;
            this.AddBCICheckBox.Enabled = false;
            // 
            // PriceCalculatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 512);
            this.Controls.Add(this.RetailPriceTB);
            this.Controls.Add(this.RetailPriceLabel);
            this.Controls.Add(this.CostTB);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.TotalTB);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.FirearmRB);
            this.Controls.Add(this.AmmoRB);
            this.Controls.Add(this.AccessoryRB);
            this.Controls.Add(this.NFAItemRB);
            this.Controls.Add(this.AddBCICheckBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantityTB);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.SubTotalTB);
            this.Controls.Add(this.QuantityXLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 780);
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
        private System.Windows.Forms.RadioButton NFAItemRB;
        private System.Windows.Forms.CheckBox AddBCICheckBox;
        private System.Windows.Forms.TextBox CostTB;
        private System.Windows.Forms.Label RetailPriceLabel;
        private System.Windows.Forms.TextBox RetailPriceTB;
        private System.Windows.Forms.Label QuantityXLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TextBox SubTotalTB;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTB;
    }
}

