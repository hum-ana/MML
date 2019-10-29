using System;
using System.Windows.Forms;

namespace MML.Life
{
    public partial class AddToDo : Form
    {
        public AddToDo()
        {
            InitializeComponent();
        }

        private void TxtToDo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ToDo t = new ToDo();
                t.Name = txtToDo.Text;
                t.Done = false;
                t.Date = DateTime.Now.ToString();
                MonthWork.ToDos.Add(t);
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
