namespace MML.Money
{
    partial class MonthView
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.btnIncome = new System.Windows.Forms.Button();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblBalanceMonth = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMonthData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonth.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMonth.Location = new System.Drawing.Point(0, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblMonth.Size = new System.Drawing.Size(605, 295);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "September - 2020";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLastMonth.Location = new System.Drawing.Point(12, 12);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(46, 36);
            this.btnLastMonth.TabIndex = 2;
            this.btnLastMonth.Text = "Last month";
            this.btnLastMonth.UseVisualStyleBackColor = false;
            this.btnLastMonth.Click += new System.EventHandler(this.BtnLastMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextMonth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextMonth.Location = new System.Drawing.Point(547, 12);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(46, 36);
            this.btnNextMonth.TabIndex = 3;
            this.btnNextMonth.Text = "Next month";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            this.btnNextMonth.Click += new System.EventHandler(this.BtnNextMonth_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExpenses.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpenses.Location = new System.Drawing.Point(12, 249);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(60, 34);
            this.btnExpenses.TabIndex = 4;
            this.btnExpenses.Text = "Add expenses";
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.BtnExpenses_Click);
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpenses.ForeColor = System.Drawing.Color.Brown;
            this.lblTotalExpenses.Location = new System.Drawing.Point(195, 129);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(171, 19);
            this.lblTotalExpenses.TabIndex = 5;
            this.lblTotalExpenses.Text = "Total expenses: 0€";
            this.lblTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIncome
            // 
            this.btnIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncome.Location = new System.Drawing.Point(533, 249);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(60, 34);
            this.btnIncome.TabIndex = 6;
            this.btnIncome.Text = "Add income";
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.BtnIncome_Click);
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncome.ForeColor = System.Drawing.Color.LightGreen;
            this.lblTotalIncome.Location = new System.Drawing.Point(195, 175);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(153, 19);
            this.lblTotalIncome.TabIndex = 7;
            this.lblTotalIncome.Text = "Total income: 0€";
            this.lblTotalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalanceMonth
            // 
            this.lblBalanceMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalanceMonth.AutoSize = true;
            this.lblBalanceMonth.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBalanceMonth.Location = new System.Drawing.Point(405, 149);
            this.lblBalanceMonth.Name = "lblBalanceMonth";
            this.lblBalanceMonth.Size = new System.Drawing.Size(90, 19);
            this.lblBalanceMonth.TabIndex = 8;
            this.lblBalanceMonth.Text = "Balance: ";
            this.lblBalanceMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(268, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 28);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMonthData
            // 
            this.btnMonthData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMonthData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMonthData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonthData.Location = new System.Drawing.Point(12, 142);
            this.btnMonthData.Name = "btnMonthData";
            this.btnMonthData.Size = new System.Drawing.Size(60, 34);
            this.btnMonthData.TabIndex = 11;
            this.btnMonthData.Text = "Month Data";
            this.btnMonthData.UseVisualStyleBackColor = false;
            this.btnMonthData.Click += new System.EventHandler(this.BtnMonthData_Click);
            // 
            // MonthView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(605, 295);
            this.ControlBox = false;
            this.Controls.Add(this.btnMonthData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblBalanceMonth);
            this.Controls.Add(this.lblTotalIncome);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnLastMonth);
            this.Controls.Add(this.lblMonth);
            this.Name = "MonthView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.MonthView_Activate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonthView_FormClosing);
            this.Load += new System.EventHandler(this.MonthView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblBalanceMonth;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMonthData;
    }
}