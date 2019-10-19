using System;
using System.Windows.Forms;

namespace MML.Money
{
    public partial class AddIncome : Form
    {
        Income inco;

        public AddIncome()
        {
            InitializeComponent();
            cboCategory.DataSource = Enum.GetValues(typeof(Income.Categories));
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Income.Categories saveCategory;
            Enum.TryParse<Income.Categories>(cboCategory.SelectedValue.ToString(), out saveCategory);
            inco = new Income(txtName.Text, Convert.ToDouble(txtPrice.Text), saveCategory, dtpDate.Value.ToShortDateString());
            MonthView.incoms.Add(inco);
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
