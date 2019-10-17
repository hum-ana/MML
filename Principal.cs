using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MML
{
    public partial class Principal : Form
    {
        public string dateNow = "";

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            dateNow = DateTime.Now.Month + "/";
            dateNow += DateTime.Now.Day + "/";
            dateNow += DateTime.Now.Year + "";
            lblDate.Text = dateNow;
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
    }
}
