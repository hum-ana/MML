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
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMonth.Location = new System.Drawing.Point(211, 9);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(189, 41);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "September";
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
            // MonthView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(605, 295);
            this.ControlBox = false;
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnLastMonth);
            this.Controls.Add(this.lblMonth);
            this.Name = "MonthView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.MonthView_Deactivate);
            this.Load += new System.EventHandler(this.MonthView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnExpenses;
    }
}