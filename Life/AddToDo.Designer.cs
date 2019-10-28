namespace MML.Life
{
    partial class AddToDo
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
            this.txtToDo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtToDo
            // 
            this.txtToDo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtToDo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtToDo.Location = new System.Drawing.Point(4, 4);
            this.txtToDo.Name = "txtToDo";
            this.txtToDo.Size = new System.Drawing.Size(390, 20);
            this.txtToDo.TabIndex = 0;
            this.txtToDo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtToDo_KeyDown);
            // 
            // AddToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 28);
            this.ControlBox = false;
            this.Controls.Add(this.txtToDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(398, 28);
            this.MinimumSize = new System.Drawing.Size(398, 28);
            this.Name = "AddToDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToDo;
    }
}