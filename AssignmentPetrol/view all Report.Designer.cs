namespace AssignmentPetrol
{
    partial class view_all_Report
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
            this.btnCustomerReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRedeemptionReport = new System.Windows.Forms.Button();
            this.btnTransactionReport = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.Location = new System.Drawing.Point(139, 129);
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Size = new System.Drawing.Size(100, 35);
            this.btnCustomerReport.TabIndex = 22;
            this.btnCustomerReport.Text = "Customer Report";
            this.btnCustomerReport.UseVisualStyleBackColor = true;
            this.btnCustomerReport.Click += new System.EventHandler(this.btnCustomerReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(294, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 36);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRedeemptionReport
            // 
            this.btnRedeemptionReport.Location = new System.Drawing.Point(139, 228);
            this.btnRedeemptionReport.Name = "btnRedeemptionReport";
            this.btnRedeemptionReport.Size = new System.Drawing.Size(100, 35);
            this.btnRedeemptionReport.TabIndex = 20;
            this.btnRedeemptionReport.Text = "Redemption Report";
            this.btnRedeemptionReport.UseVisualStyleBackColor = true;
            this.btnRedeemptionReport.Click += new System.EventHandler(this.btnRedeemptionReport_Click);
            // 
            // btnTransactionReport
            // 
            this.btnTransactionReport.Location = new System.Drawing.Point(139, 175);
            this.btnTransactionReport.Name = "btnTransactionReport";
            this.btnTransactionReport.Size = new System.Drawing.Size(100, 35);
            this.btnTransactionReport.TabIndex = 19;
            this.btnTransactionReport.Text = "Transaction Report";
            this.btnTransactionReport.UseVisualStyleBackColor = true;
            this.btnTransactionReport.Click += new System.EventHandler(this.btnTransactionReport_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(224, 315);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(64, 36);
            this.btnMainMenu.TabIndex = 23;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(135, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Report Menu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(50, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 27);
            this.label8.TabIndex = 33;
            this.label8.Text = "PETRON LOYALTY SYSTEM";
            // 
            // view_all_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(364, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnCustomerReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRedeemptionReport);
            this.Controls.Add(this.btnTransactionReport);
            this.Name = "view_all_Report";
            this.Text = "view_all_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRedeemptionReport;
        private System.Windows.Forms.Button btnTransactionReport;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}