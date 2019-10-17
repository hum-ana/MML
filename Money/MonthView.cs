using System;
using System.Globalization;
using System.Windows.Forms;

namespace MML.Money
{
    public partial class MonthView : Form
    {
        int MonthNow;

        public MonthView()
        {
            InitializeComponent();
        }

        private void MonthView_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonthView_Load(object sender, EventArgs e)
        {
            getDate();
        }

        public void getDate()
        {
            MonthNow = DateTime.Now.Month;
            lblMonth.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("MMMM", CultureInfo.InvariantCulture);
        }

        private void BtnNextMonth_Click(object sender, EventArgs e)
        {
            MonthNow++;
            if (MonthNow == 13)
            {
                MonthNow = 1;
            }
            lblMonth.Text = new DateTime(DateTime.Now.Year, MonthNow, DateTime.Now.Day).ToString("MMMM", CultureInfo.InvariantCulture);
        }

        private void BtnLastMonth_Click(object sender, EventArgs e)
        {
            MonthNow--;
            if (MonthNow == 0)
            {
                MonthNow = 12;
            }
            lblMonth.Text = new DateTime(DateTime.Now.Year, MonthNow, DateTime.Now.Day).ToString("MMMM", CultureInfo.InvariantCulture);
        }

        private void BtnExpenses_Click(object sender, EventArgs e)
        {

        }
    }
}
