using System;
using System.Windows.Forms;

namespace MML.Money
{
    public partial class AddExpenses : Form
    {
        Expenses exp;

        public AddExpenses()
        {
            InitializeComponent();
            cboCategory.DataSource = Enum.GetValues(typeof(Expenses.Categories));
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Expenses.Categories saveCategory;
            Enum.TryParse<Expenses.Categories>(cboCategory.SelectedValue.ToString(), out saveCategory);
            exp = new Expenses(txtName.Text, Convert.ToDouble(txtPrice.Text), saveCategory, dtpDate.Value.ToShortDateString());
            MonthView.expens.Add(exp);
            this.Close();
        }
    }
}
