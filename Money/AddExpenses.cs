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
            cboCategory.DataSource = Enum.GetValues(typeof(CategoriesExpenses));
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CategoriesExpenses saveCategory;
            Enum.TryParse<CategoriesExpenses>(cboCategory.SelectedValue.ToString(), out saveCategory);
            exp = new Expenses(txtName.Text, Convert.ToDouble(txtPrice.Text), saveCategory, dtpDate.Value.ToShortDateString());
            MonthView.expens.Add(exp);
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
