using MML.Money;
using System;
using System.Windows.Forms;

namespace MML
{
    public partial class Principal : Form
    {

        public void getDate()
        {
            string dateNow;
            dateNow = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "";
            lblDate.Text = dateNow;
        }


        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            getDate();
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            Calendar f = new Calendar();
            f.Show(this);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnMonthView_Click(object sender, EventArgs e)
        {
            MonthView f = new MonthView();
            f.Show(this);
        }
    }
}
