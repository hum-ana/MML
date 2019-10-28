using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MML.Life
{
    public partial class MonthWork : Form
    {
        public static List<string> ToDos;
        CheckBox chk;

        public MonthWork()
        {
            InitializeComponent();
            lblTotalHours.Text = HoursWorked();
            lblMonthName.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("MMMM", CultureInfo.InvariantCulture) + " - " + DateTime.Now.Year;
            ToDos = new List<string>();
        }

        public static int MondaysToThursdayInMonth(DateTime thisMonth)
        {
            int mondays = 0;
            int tuesdays = 0;
            int wednesdays = 0;
            int thursday = 0;

            int month = thisMonth.Month;
            int year = thisMonth.Year;
            int daysThisMonth = DateTime.DaysInMonth(year, month);
            DateTime beginingOfThisMonth = new DateTime(year, month, 1);
            for (int i = 0; i < daysThisMonth; i++)
            {
                if (beginingOfThisMonth.AddDays(i).DayOfWeek == DayOfWeek.Monday)
                {
                    mondays++;
                }
                if (beginingOfThisMonth.AddDays(i).DayOfWeek == DayOfWeek.Tuesday)
                {
                    tuesdays++;
                }
                if (beginingOfThisMonth.AddDays(i).DayOfWeek == DayOfWeek.Wednesday)
                {
                    wednesdays++;
                }
                if (beginingOfThisMonth.AddDays(i).DayOfWeek == DayOfWeek.Thursday)
                {
                    thursday++;
                }
            }
            return mondays + tuesdays + wednesdays + thursday;
        }

        public static int FridayInMonth(DateTime thisMonth)
        {
            int fridays = 0;
            int month = thisMonth.Month;
            int year = thisMonth.Year;
            int daysThisMonth = DateTime.DaysInMonth(year, month);
            DateTime beginingOfThisMonth = new DateTime(year, month, 1);
            for (int i = 0; i < daysThisMonth; i++)
            {
                if (beginingOfThisMonth.AddDays(i).DayOfWeek == DayOfWeek.Friday)
                {
                    fridays++;
                }
            }
            return fridays;
        }

        public static string HoursWorked()
        {
            int EigthHours = MondaysToThursdayInMonth(DateTime.Now);
            int SevenHours = FridayInMonth(DateTime.Now);
            string TotalHours = (EigthHours * 8) + (SevenHours * 7) + "h";
            return TotalHours;
        }

        private void BtnToDo_Click(object sender, EventArgs e)
        {
            AddToDo f = new AddToDo();
            f.ShowDialog(this);
        }

        public void LoadToDos()
        {
            int y = 100;
            if (ToDos.Count > 0)
            {
                foreach (string s in ToDos)
                {
                    chk = new CheckBox();
                    chk.Location = new Point(400, y);
                    chk.BackColor = Color.FromArgb(40, 40, 40);
                    chk.ForeColor = SystemColors.ButtonFace;
                    chk.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    chk.Text = s.ToString();

                    Controls.Add(chk);
                    y += 40;
                }
            }
        }

        private void MonthWork_Activated(object sender, EventArgs e)
        {
            LoadToDos();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
