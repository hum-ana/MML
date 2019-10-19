using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace MML.Money
{
    public partial class MonthView : Form
    {
        int MonthNow;
        int YearNow;
        string DateNow;
        public static List<Expenses> expens;
        double MonthExpenses;
        public static List<Income> incoms;
        double MonthIncomes;

        public MonthView()
        {
            InitializeComponent();
            expens = new List<Expenses>();
            incoms = new List<Income>();
        }

        private void MonthView_Activate(object sender, EventArgs e)
        {
            getExpenses();
            getIncome();
        }

        private void MonthView_Load(object sender, EventArgs e)
        {
            getDate();
        }

        public void getDate()
        {
            MonthNow = DateTime.Now.Month;
            YearNow = DateTime.Now.Year;
            DateNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("MMMM", CultureInfo.InvariantCulture) + " - " + YearNow;
            lblMonth.Text = DateNow;
        }

        public void getExpenses()
        {
            if (expens.Count > 0)
            {
                MonthExpenses = 0;
                lblTotalExpenses.Text = "Total expenses: " + MonthExpenses + "€";
                foreach (Expenses exp in expens)
                {
                    string result = exp.Date.Substring(exp.Date.IndexOf("/") + 1, (exp.Date.LastIndexOf("/")) - (exp.Date.IndexOf("/") + 1));
                    if (result == MonthNow.ToString() && exp.Date.Substring(exp.Date.LastIndexOf("/")+1) == YearNow.ToString())
                    {
                        MonthExpenses += exp.Price;
                    }
                }
                lblTotalExpenses.Text = "Total expenses: " + MonthExpenses + "€";
            }
        }

        public void getIncome()
        {
            if (incoms.Count > 0)
            {
                MonthIncomes = 0;
                lblTotalIncome.Text = "Total income: " + MonthExpenses + "€";
                foreach (Income inc in incoms)
                {
                    string result = inc.Date.Substring(inc.Date.IndexOf("/") + 1, (inc.Date.LastIndexOf("/")) - (inc.Date.IndexOf("/") + 1));
                    if (result == MonthNow.ToString() && inc.Date.Substring(inc.Date.LastIndexOf("/") + 1) == YearNow.ToString())
                    {
                        MonthIncomes += inc.Price;
                    }
                }
                lblTotalIncome.Text = "Total income: " + MonthIncomes + "€";
            }
        }

        private void BtnNextMonth_Click(object sender, EventArgs e)
        {
            MonthNow++;
            if (MonthNow == 13)
            {
                MonthNow = 1;
                YearNow++;
            }
            DateNow = new DateTime(DateTime.Now.Year, MonthNow, DateTime.Now.Day).ToString("MMMM", CultureInfo.InvariantCulture) + " - " + YearNow;
            lblMonth.Text = DateNow;
            getExpenses();
            getIncome();
        }

        private void BtnLastMonth_Click(object sender, EventArgs e)
        {
            MonthNow--;
            if (MonthNow == 0)
            {
                MonthNow = 12;
                YearNow--;
            }
            DateNow = new DateTime(DateTime.Now.Year, MonthNow, DateTime.Now.Day).ToString("MMMM", CultureInfo.InvariantCulture) + " - " + YearNow;
            lblMonth.Text = DateNow;
            getExpenses();
            getIncome();
        }

        private void BtnExpenses_Click(object sender, EventArgs e)
        {
            AddExpenses f = new AddExpenses();
            f.Show(this);
        }

        private void BtnIncome_Click(object sender, EventArgs e)
        {
            AddIncome f = new AddIncome();
            f.Show(this);
        }
    }
}
