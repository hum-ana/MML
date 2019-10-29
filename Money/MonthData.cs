using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MML.Money
{
    public partial class MonthData : Form
    {
        public static List<Expenses> thisExpenses;
        public static List<Income> thisIncome;
        public List<Expenses> deleteExpenses = new List<Expenses>();
        public List<Income> deleteIncome = new List<Income>();
        public Label lblExpenses;
        public Label lblIncome;

        public MonthData()
        {
            InitializeComponent();
            PutData();
        }

        private void MonthData_Deactivate(object sender, EventArgs e)
        {
            DeleteExpenses();
            DeleteIncome();
            this.Close();
        }

        public void PutData()
        {
            int y = 60;
            int y2 = 60;

            if (thisExpenses.Count > 0)
            {
                foreach (Expenses exp in thisExpenses)
                {
                    lblExpenses = new Label();
                    lblExpenses.Location = new Point(40, y);
                    lblExpenses.Size = new Size(450, 20);
                    lblExpenses.BackColor = Color.FromArgb(40, 40, 40);
                    lblExpenses.ForeColor = SystemColors.ButtonFace;
                    lblExpenses.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    lblExpenses.Text = exp.Date + "  " + exp.Name + "  " + exp.category + "  " + exp.Price + "€";
                    lblExpenses.Tag = exp;
                    lblExpenses.Click += new EventHandler(lblExpensesClick);

                    Controls.Add(lblExpenses);
                    y += 50;
                }
            }

            if (thisIncome.Count > 0)
            {
                foreach (Income inc in thisIncome)
                {
                    lblIncome = new Label();
                    lblIncome.Location = new Point(550, y2);
                    lblIncome.Size = new Size(450, 20);
                    lblIncome.BackColor = Color.FromArgb(40, 40, 40);
                    lblIncome.ForeColor = SystemColors.ButtonFace;
                    lblIncome.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    lblIncome.Text = inc.Date + "  " + inc.Name + "  " + inc.category + "  " + inc.Price + "€";
                    lblIncome.Tag = inc;
                    lblIncome.Click += new EventHandler(lblIncomeClick);

                    Controls.Add(lblIncome);
                    y2 += 50;
                }
            }
        }

        void lblExpensesClick(object sender, EventArgs e)
        {
            if (((Label)sender).ForeColor == SystemColors.ButtonFace)
            {
                ((Label)sender).ForeColor = SystemColors.AppWorkspace;
                ((Label)sender).Font = new Font("Consolas", 12F, FontStyle.Strikeout, GraphicsUnit.Point, ((byte)(0)));
                deleteExpenses.Add((Expenses)((Label)sender).Tag);
            }
            else
            {
                ((Label)sender).ForeColor = SystemColors.ButtonFace;
                ((Label)sender).Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                deleteExpenses.Remove((Expenses)((Label)sender).Tag);
            }
        }

        void DeleteExpenses()
        {
            if (deleteExpenses.Count > 0)
            {
                for (int i = 0; i < deleteExpenses.Count; i++)
                {
                    MonthView.expens.Remove(deleteExpenses[i]);
                }
            }
        }

        void lblIncomeClick(object sender, EventArgs e)
        {
            if (((Label)sender).ForeColor == SystemColors.ButtonFace)
            {
                ((Label)sender).ForeColor = SystemColors.AppWorkspace;
                ((Label)sender).Font = new Font("Consolas", 12F, FontStyle.Strikeout, GraphicsUnit.Point, ((byte)(0)));
                deleteIncome.Add((Income)((Label)sender).Tag);
            }
            else
            {
                ((Label)sender).ForeColor = SystemColors.ButtonFace;
                ((Label)sender).Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                deleteIncome.Remove((Income)((Label)sender).Tag);
            }
        }

        void DeleteIncome()
        {
            if (deleteIncome.Count > 0)
            {
                for (int i = 0; i < deleteIncome.Count; i++)
                {
                    MonthView.incoms.Remove(deleteIncome[i]);
                }
            }
        }
    }
}
