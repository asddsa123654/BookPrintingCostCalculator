using System;
using System.Windows.Forms;

namespace BookPrintingCostCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Вхідні дані
            decimal pricePerPage = numericPricePerPage.Value;  // Вартість 1 сторінки
            int numberOfPages = (int)numericNumberOfPages.Value;  // Кількість сторінок
            int numberOfCopies = (int)numericNumberOfCopies.Value;  // Кількість екземплярів
            bool isUrgent = chkUrgent.Checked;  // Умови виконання замовлення (терміново чи ні)

            // Розрахунок вартості
            decimal totalCost = pricePerPage * numberOfPages * numberOfCopies;

            // Якщо термінове, додаємо націнку (наприклад, 20%)
            if (isUrgent)
            {
                totalCost *= 1.2m;
            }

            // Виведення результату
            lblTotalCost.Text = $"Загальна вартість: {totalCost:C2}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Очищення полів
            numericPricePerPage.Value = 0;
            numericNumberOfPages.Value = 0;
            numericNumberOfCopies.Value = 0;
            chkUrgent.Checked = false;
            lblTotalCost.Text = "Загальна вартість: 0";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
