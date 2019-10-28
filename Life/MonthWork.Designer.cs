namespace MML.Life
{
    partial class MonthWork
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
            this.lblMonthName = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.btnToDo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonthName
            // 
            this.lblMonthName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMonthName.Font = new System.Drawing.Font("Consolas", 26.25F);
            this.lblMonthName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMonthName.Location = new System.Drawing.Point(0, 0);
            this.lblMonthName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblMonthName.Size = new System.Drawing.Size(800, 58);
            this.lblMonthName.TabIndex = 1;
            this.lblMonthName.Text = "October - 2019";
            this.lblMonthName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // monthCalendar
            // 
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Location = new System.Drawing.Point(63, 110);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHours.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotalHours.Location = new System.Drawing.Point(121, 281);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(75, 32);
            this.lblTotalHours.TabIndex = 3;
            this.lblTotalHours.Text = "180h";
            // 
            // btnToDo
            // 
            this.btnToDo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToDo.Location = new System.Drawing.Point(656, 421);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(79, 26);
            this.btnToDo.TabIndex = 4;
            this.btnToDo.Text = "Add TO-DO";
            this.btnToDo.UseVisualStyleBackColor = false;
            this.btnToDo.Click += new System.EventHandler(this.BtnToDo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(754, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MonthWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.lblMonthName);
            this.Name = "MonthWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.MonthWork_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblMonthName;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.Button btnExit;
    }
}