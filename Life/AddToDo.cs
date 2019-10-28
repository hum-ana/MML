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
                MonthWork.ToDos.Add(txtToDo.Text);
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
