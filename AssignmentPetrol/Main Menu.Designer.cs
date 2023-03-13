namespace AssignmentPetrol
{
    partial class Main_Menu
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRedeemPoint = new System.Windows.Forms.Button();
            this.btnBuyItem = new System.Windows.Forms.Button();
            this.btnRegisterCust = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(340, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 36);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(124, 269);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(160, 35);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnRedemPoint_Click);
            // 
            // btnRedeemPoint
            // 
            this.btnRedeemPoint.Location = new System.Drawing.Point(124, 216);
            this.btnRedeemPoint.Name = "btnRedeemPoint";
            this.btnRedeemPoint.Size = new System.Drawing.Size(160, 35);
            this.btnRedeemPoint.TabIndex = 14;
            this.btnRedeemPoint.Text = "Redeem Point";
            this.btnRedeemPoint.UseVisualStyleBackColor = true;
            this.btnRedeemPoint.Click += new System.EventHandler(this.btnRedeemPoint_Click);
            // 
            // btnBuyItem
            // 
            this.btnBuyItem.Location = new System.Drawing.Point(124, 163);
            this.btnBuyItem.Name = "btnBuyItem";
            this.btnBuyItem.Size = new System.Drawing.Size(160, 35);
            this.btnBuyItem.TabIndex = 13;
            this.btnBuyItem.Text = "Buy Item";
            this.btnBuyItem.UseVisualStyleBackColor = true;
            this.btnBuyItem.Click += new System.EventHandler(this.btnBuyItem_Click);
            // 
            // btnRegisterCust
            // 
            this.btnRegisterCust.Location = new System.Drawing.Point(124, 117);
            this.btnRegisterCust.Name = "btnRegisterCust";
            this.btnRegisterCust.Size = new System.Drawing.Size(160, 35);
            this.btnRegisterCust.TabIndex = 18;
            this.btnRegisterCust.Text = "Register New Customer";
            this.btnRegisterCust.UseVisualStyleBackColor = true;
            this.btnRegisterCust.Click += new System.EventHandler(this.btnRegisterCust_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(68, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 27);
            this.label8.TabIndex = 31;
            this.label8.Text = "PETRON LOYALTY SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(161, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Main Menu";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(417, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRegisterCust);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRedeemPoint);
            this.Controls.Add(this.btnBuyItem);
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnRedeemPoint;
        private System.Windows.Forms.Button btnBuyItem;
        private System.Windows.Forms.Button btnRegisterCust;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}