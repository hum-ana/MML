using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
        double MonthBalance;
        string directoryIncome = "";
        string directoryExpenses = "";

        public MonthView()
        {
            InitializeComponent();
            directoryIncome = Environment.GetEnvironmentVariable("homepath") + "\\moneyINC.dat";
            directoryExpenses = Environment.GetEnvironmentVariable("homepath") + "\\moneyEXP.dat";
            expens = new List<Expenses>();
            incoms = new List<Income>();
            getData();
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

        public void getData()
        {
            if (File.Exists(directoryExpenses))
            {
                try
                {
                    using (BinReaderExpenses bre = new BinReaderExpenses(new FileStream(directoryExpenses, FileMode.Open)))
                    {
                        while (bre.PeekChar() > 0)
                        {
                            expens.Add(bre.ReadExpenses());
                        }
                    }

                    using (BinReaderIncome bri = new BinReaderIncome(new FileStream(directoryIncome, FileMode.Open)))
                    {
                        while (bri.PeekChar() > 0)
                        {
                            incoms.Add(bri.ReadIncome());
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There is a problem loading the file");
                    Console.ReadKey();
                }
            }
        }

        public void SaveData()
        {
            try
            {
                using (BinWriterExpenses bwe = new BinWriterExpenses(new FileStream(directoryExpenses, FileMode.Create)))
                {
                    for (int i = 0; i < expens.Count; i++)
                    {
                        bwe.WriteExpenses(expens[i]);
                    }
                }

                using (BinWriterIncome bwi = new BinWriterIncome(new FileStream(directoryIncome, FileMode.Create)))
                {
                    for (int i = 0; i < incoms.Count; i++)
                    {
                        bwi.WriteIncome(incoms[i]);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("There is a problem saving the file");
                Console.ReadKey();
            }
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
                    if (result == MonthNow.ToString("00") && exp.Date.Substring(exp.Date.LastIndexOf("/") + 1) == YearNow.ToString())
                    {
                        MonthExpenses += exp.Price;
                    }
                }
                lblTotalExpenses.Text = "Total expenses: " + MonthExpenses + "€";
                getBalance();
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
                    if (result == MonthNow.ToString("00") && inc.Date.Substring(inc.Date.LastIndexOf("/") + 1) == YearNow.ToString())
                    {
                        MonthIncomes += inc.Price;
                    }
                }
                lblTotalIncome.Text = "Total income: " + MonthIncomes + "€";
                getBalance();
            }
        }

        public void getBalance()
        {
            lblBalanceMonth.Text = "";
            if (MonthIncomes > 0 || MonthExpenses > 0)
            {
                MonthBalance = MonthIncomes - MonthExpenses;
                lblBalanceMonth.Text = "Balance: " + MonthBalance.ToString() + "€";
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

        private void BtnMonthData_Click(object sender, EventArgs e)
        {
            if (expens.Count > 0 || incoms.Count > 0)
            {
                MonthData.thisExpenses = new List<Expenses>();
                MonthData.thisIncome = new List<Income>();
                foreach (Expenses exp in expens)
                {
                    string result = exp.Date.Substring(exp.Date.IndexOf("/") + 1, (exp.Date.LastIndexOf("/")) - (exp.Date.IndexOf("/") + 1));
                    if (result == MonthNow.ToString("00") && exp.Date.Substring(exp.Date.LastIndexOf("/") + 1) == YearNow.ToString())
                    {
                        MonthData.thisExpenses.Add(exp);
                    }
                }
                foreach (Income inc in incoms)
                {
                    string result = inc.Date.Substring(inc.Date.IndexOf("/") + 1, (inc.Date.LastIndexOf("/")) - (inc.Date.IndexOf("/") + 1));
                    if (result == MonthNow.ToString("00") && inc.Date.Substring(inc.Date.LastIndexOf("/") + 1) == YearNow.ToString())
                    {
                        MonthData.thisIncome.Add(inc);
                    }
                }
                MonthData md = new MonthData();
                md.Show();
            }
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonthView_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}
