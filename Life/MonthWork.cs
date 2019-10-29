using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace MML.Life
{
    public partial class MonthWork : Form
    {
        public static List<ToDo> ToDos;
        CheckBox chk;
        string directoryToDo;

        int DayNow;
        int MonthNow;
        int YearNow;
        string DateNow;

        public MonthWork()
        {
            InitializeComponent();
            directoryToDo = Environment.GetEnvironmentVariable("homepath") + "\\ToDos.dat";
            lblTotalHours.Text = HoursWorked();
            lblMonthName.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("MMMM", CultureInfo.InvariantCulture) + " - " + DateTime.Now.Year;
            ToDos = new List<ToDo>();
        }

        private void MonthWork_Load(object sender, EventArgs e)
        {
            getData();
            getDate();
            LoadToDos();
        }

        public void getDate()
        {
            DayNow = DateTime.Now.Day;
            MonthNow = DateTime.Now.Month;
            YearNow = DateTime.Now.Year;
            DateNow = DayNow + " - " + new DateTime(YearNow, MonthNow, DayNow).ToString("MMMM", CultureInfo.InvariantCulture) + " - " + YearNow;
            lblDay.Text = DateNow;
        }

        private void BtnToDo_Click(object sender, EventArgs e)
        {
            AddToDo f = new AddToDo();
            f.ShowDialog(this);
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

        public void LoadToDos()
        {
            int y = 40;
            pnlToDo.Controls.Clear();
            if (ToDos.Count > 0)
            {
                foreach (ToDo s in ToDos)
                {
                    if (s.Date.Split(' ')[0] == (DayNow + "/" + MonthNow + "/" + YearNow))
                    {
                        chk = new CheckBox();
                        chk.Location = new Point(20, y);
                        chk.BackColor = Color.FromArgb(40, 40, 40);
                        chk.ForeColor = SystemColors.ButtonFace;
                        chk.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                        chk.Click += new EventHandler(chkClick);
                        chk.Text = s.Name;
                        chk.Checked = s.Done;

                        pnlToDo.Controls.Add(chk);
                        y += 30;
                    }
                }
            }
        }

        void chkClick(object sender, EventArgs e)
        {

        }

        public void getData()
        {
            if (File.Exists(directoryToDo))
            {
                try
                {
                    using (BinReaderToDo bre = new BinReaderToDo(new FileStream(directoryToDo, FileMode.Open)))
                    {
                        while (bre.PeekChar() > 0)
                        {
                            ToDos.Add(bre.ReadToDo());
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
                using (BinWriterToDo bwe = new BinWriterToDo(new FileStream(directoryToDo, FileMode.Create)))
                {
                    for (int i = 0; i < ToDos.Count; i++)
                    {
                        bwe.WriteToDo(ToDos[i]);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("There is a problem saving the file");
                Console.ReadKey();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }

        private void BtnNextDay_Click(object sender, EventArgs e)
        {
            DayNow++;
            switch (MonthNow)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (DayNow == 32)
                    {
                        MonthNow++;
                        DayNow = 1;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (DayNow == 31)
                    {
                        MonthNow++;
                        DayNow = 1;
                    }
                    break;
                case 2:
                    if (DayNow == 29)
                    {
                        MonthNow++;
                        DayNow = 1;
                    }
                    break;
            }

            if (MonthNow == 13)
            {
                MonthNow = 1;
                YearNow++;
            }
            DateNow = DayNow + " - " + new DateTime(YearNow, MonthNow, DayNow).ToString("MMMM", CultureInfo.InvariantCulture) + " - " + YearNow;
            lblDay.Text = DateNow;
            LoadToDos();
        }

        private void BtnLastDay_Click(object sender, EventArgs e)
        {
            DayNow--;
            if (DayNow == 0)
            {
                MonthNow--;
            }
            switch (MonthNow)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (DayNow == 0)
                        DayNow = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (DayNow == 0)
                        DayNow = 30;
                    break;
                case 2:
                    if (DayNow == 0)
                        DayNow = 28;
                    break;
            }
            if (MonthNow == 0)
            {
                MonthNow = 12;
                YearNow--;
            }
            DateNow = DayNow + " - " + new DateTime(YearNow, MonthNow, DayNow).ToString("MMMM", CultureInfo.InvariantCulture) + " - " + YearNow;
            lblDay.Text = DateNow;
            LoadToDos();
        }

        private void LblDay_Click(object sender, EventArgs e)
        {
            getDate();
            LoadToDos();
        }
    }
}
