namespace Program2
{
    partial class DeliveryCostCalculator
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
            this.weightLbl = new System.Windows.Forms.Label();
            this.distLbl = new System.Windows.Forms.Label();
            this.daysLbl = new System.Windows.Forms.Label();
            this.weightTxtBox = new System.Windows.Forms.TextBox();
            this.distTxtBox = new System.Windows.Forms.TextBox();
            this.daysTxtBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.aCostLbl = new System.Windows.Forms.Label();
            this.bCostLbl = new System.Windows.Forms.Label();
            this.cCostLbl = new System.Windows.Forms.Label();
            this.aCostOutputLbl = new System.Windows.Forms.Label();
            this.bCostOutputLbl = new System.Windows.Forms.Label();
            this.cCostOutputLbl = new System.Windows.Forms.Label();
            this.lowestCostOutputLbl = new System.Windows.Forms.Label();
            this.lowestCostLbl = new System.Windows.Forms.Label();
            this.headerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(32, 46);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(90, 13);
            this.weightLbl.TabIndex = 0;
            this.weightLbl.Text = "Package Weight:";
            // 
            // distLbl
            // 
            this.distLbl.AutoSize = true;
            this.distLbl.Location = new System.Drawing.Point(32, 75);
            this.distLbl.Name = "distLbl";
            this.distLbl.Size = new System.Drawing.Size(90, 13);
            this.distLbl.TabIndex = 1;
            this.distLbl.Text = "Distance in Miles:";
            // 
            // daysLbl
            // 
            this.daysLbl.AutoSize = true;
            this.daysLbl.Location = new System.Drawing.Point(42, 101);
            this.daysLbl.Name = "daysLbl";
            this.daysLbl.Size = new System.Drawing.Size(75, 13);
            this.daysLbl.TabIndex = 2;
            this.daysLbl.Text = "Delivery Days:";
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Location = new System.Drawing.Point(123, 43);
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.weightTxtBox.TabIndex = 3;
            // 
            // distTxtBox
            // 
            this.distTxtBox.Location = new System.Drawing.Point(123, 72);
            this.distTxtBox.Name = "distTxtBox";
            this.distTxtBox.Size = new System.Drawing.Size(100, 20);
            this.distTxtBox.TabIndex = 4;
            // 
            // daysTxtBox
            // 
            this.daysTxtBox.Location = new System.Drawing.Point(123, 98);
            this.daysTxtBox.Name = "daysTxtBox";
            this.daysTxtBox.Size = new System.Drawing.Size(100, 20);
            this.daysTxtBox.TabIndex = 5;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(45, 134);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(158, 23);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calculate Costs";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // aCostLbl
            // 
            this.aCostLbl.AutoSize = true;
            this.aCostLbl.Location = new System.Drawing.Point(29, 178);
            this.aCostLbl.Name = "aCostLbl";
            this.aCostLbl.Size = new System.Drawing.Size(88, 13);
            this.aCostLbl.TabIndex = 7;
            this.aCostLbl.Text = "Company A Cost:";
            // 
            // bCostLbl
            // 
            this.bCostLbl.AutoSize = true;
            this.bCostLbl.Location = new System.Drawing.Point(29, 213);
            this.bCostLbl.Name = "bCostLbl";
            this.bCostLbl.Size = new System.Drawing.Size(88, 13);
            this.bCostLbl.TabIndex = 8;
            this.bCostLbl.Text = "Company B Cost:";
            // 
            // cCostLbl
            // 
            this.cCostLbl.AutoSize = true;
            this.cCostLbl.Location = new System.Drawing.Point(29, 249);
            this.cCostLbl.Name = "cCostLbl";
            this.cCostLbl.Size = new System.Drawing.Size(88, 13);
            this.cCostLbl.TabIndex = 9;
            this.cCostLbl.Text = "Company C Cost:";
            // 
            // aCostOutputLbl
            // 
            this.aCostOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aCostOutputLbl.Location = new System.Drawing.Point(123, 177);
            this.aCostOutputLbl.Name = "aCostOutputLbl";
            this.aCostOutputLbl.Size = new System.Drawing.Size(88, 20);
            this.aCostOutputLbl.TabIndex = 10;
            // 
            // bCostOutputLbl
            // 
            this.bCostOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bCostOutputLbl.Location = new System.Drawing.Point(123, 212);
            this.bCostOutputLbl.Name = "bCostOutputLbl";
            this.bCostOutputLbl.Size = new System.Drawing.Size(88, 18);
            this.bCostOutputLbl.TabIndex = 11;
            // 
            // cCostOutputLbl
            // 
            this.cCostOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cCostOutputLbl.Location = new System.Drawing.Point(123, 248);
            this.cCostOutputLbl.Name = "cCostOutputLbl";
            this.cCostOutputLbl.Size = new System.Drawing.Size(88, 20);
            this.cCostOutputLbl.TabIndex = 12;
            // 
            // lowestCostOutputLbl
            // 
            this.lowestCostOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestCostOutputLbl.Location = new System.Drawing.Point(168, 299);
            this.lowestCostOutputLbl.Name = "lowestCostOutputLbl";
            this.lowestCostOutputLbl.Size = new System.Drawing.Size(88, 20);
            this.lowestCostOutputLbl.TabIndex = 13;
            // 
            // lowestCostLbl
            // 
            this.lowestCostLbl.AutoSize = true;
            this.lowestCostLbl.Location = new System.Drawing.Point(12, 300);
            this.lowestCostLbl.Name = "lowestCostLbl";
            this.lowestCostLbl.Size = new System.Drawing.Size(150, 13);
            this.lowestCostLbl.TabIndex = 14;
            this.lowestCostLbl.Text = "The Lowest Cost Company is: ";
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Location = new System.Drawing.Point(30, 13);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(198, 13);
            this.headerLbl.TabIndex = 15;
            this.headerLbl.Text = "Please enter your shipping details below:";
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 349);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.lowestCostLbl);
            this.Controls.Add(this.lowestCostOutputLbl);
            this.Controls.Add(this.cCostOutputLbl);
            this.Controls.Add(this.bCostOutputLbl);
            this.Controls.Add(this.aCostOutputLbl);
            this.Controls.Add(this.cCostLbl);
            this.Controls.Add(this.bCostLbl);
            this.Controls.Add(this.aCostLbl);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.daysTxtBox);
            this.Controls.Add(this.distTxtBox);
            this.Controls.Add(this.weightTxtBox);
            this.Controls.Add(this.daysLbl);
            this.Controls.Add(this.distLbl);
            this.Controls.Add(this.weightLbl);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label distLbl;
        private System.Windows.Forms.Label daysLbl;
        private System.Windows.Forms.TextBox weightTxtBox;
        private System.Windows.Forms.TextBox distTxtBox;
        private System.Windows.Forms.TextBox daysTxtBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label aCostLbl;
        private System.Windows.Forms.Label bCostLbl;
        private System.Windows.Forms.Label cCostLbl;
        private System.Windows.Forms.Label aCostOutputLbl;
        private System.Windows.Forms.Label bCostOutputLbl;
        private System.Windows.Forms.Label cCostOutputLbl;
        private System.Windows.Forms.Label lowestCostOutputLbl;
        private System.Windows.Forms.Label lowestCostLbl;
        private System.Windows.Forms.Label headerLbl;
    }
}

