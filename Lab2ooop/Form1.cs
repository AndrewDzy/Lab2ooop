using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2ooop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddVectors_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txtVector1XAddSubtract.Text);
            double y1 = double.Parse(txtVector1YAddSubtract.Text);
            double z1 = double.Parse(txtVector1ZAddSubtract.Text);

            double x2 = double.Parse(txtVector2XAddSubtract.Text);
            double y2 = double.Parse(txtVector2YAddSubtract.Text);
            double z2 = double.Parse(txtVector2ZAddSubtract.Text);

            double sumX = x1 + x2;
            double sumY = y1 + y2;
            double sumZ = z1 + z2;

            lblResultVectorAddSubtract.Text = $"Сума векторів: ({sumX}, {sumY}, {sumZ})";
        }

        private void btnSubtractVectors_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txtVector1XAddSubtract.Text);
            double y1 = double.Parse(txtVector1YAddSubtract.Text);
            double z1 = double.Parse(txtVector1ZAddSubtract.Text);

            double x2 = double.Parse(txtVector2XAddSubtract.Text);
            double y2 = double.Parse(txtVector2YAddSubtract.Text);
            double z2 = double.Parse(txtVector2ZAddSubtract.Text);

            double diffX = x1 - x2;
            double diffY = y1 - y2;
            double diffZ = z1 - z2;

            lblResultVectorAddSubtract.Text = $"Різниця векторів: ({diffX}, {diffY}, {diffZ})";
        }

        private void btnCalculateDotProduct_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txtVector1XDot.Text);
            double y1 = double.Parse(txtVector1YDot.Text);
            double z1 = double.Parse(txtVector1ZDot.Text);

            double x2 = double.Parse(txtVector2XDot.Text);
            double y2 = double.Parse(txtVector2YDot.Text);
            double z2 = double.Parse(txtVector2ZDot.Text);

            double dotProduct = x1 * x2 + y1 * y2 + z1 * z2;

            lblDotProductResult.Text = $"Скалярний добуток: {dotProduct}";
        }

        private void btnCalculateVectorLength_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtVectorXLength.Text);
            double y = double.Parse(txtVectorYLength.Text);
            double z = double.Parse(txtVectorZLength.Text);

            double length = Math.Sqrt(x * x + y * y + z * z);

            lblVectorLengthResult.Text = $"Довжина вектора: {length}";
        }

        private void btnCalculateAngleCosine_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txtVector1XCosine.Text);
            double y1 = double.Parse(txtVector1YCosine.Text);
            double z1 = double.Parse(txtVector1ZCosine.Text);

            double x2 = double.Parse(txtVector2XCosine.Text);
            double y2 = double.Parse(txtVector2YCosine.Text);
            double z2 = double.Parse(txtVector2ZCosine.Text);

            double dotProduct = x1 * x2 + y1 * y2 + z1 * z2;
            double vector1Length = Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
            double vector2Length = Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);
            double cosine = dotProduct / (vector1Length * vector2Length);

            lblAngleCosineResult.Text = $"Косинус кута між векторами: {cosine}";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtVector1XAddSubtract.KeyPress += TextBox_KeyPress;
            txtVector1YAddSubtract.KeyPress += TextBox_KeyPress;
            txtVector1ZAddSubtract.KeyPress += TextBox_KeyPress;
            txtVector2XAddSubtract.KeyPress += TextBox_KeyPress;
            txtVector2YAddSubtract.KeyPress += TextBox_KeyPress;
            txtVector2ZAddSubtract.KeyPress += TextBox_KeyPress;
            txtVector1XAddSubtract.Validating += TextBox_Validating;
            txtVector1YAddSubtract.Validating += TextBox_Validating;
            txtVector1ZAddSubtract.Validating += TextBox_Validating;
            txtVector2XAddSubtract.Validating += TextBox_Validating;
            txtVector2YAddSubtract.Validating += TextBox_Validating;
            txtVector2ZAddSubtract.Validating += TextBox_Validating;
        }

        // Обробник події KeyPress для перевірки введення лише цифр
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Дозволяємо використання тільки одного десяткового роздільника
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("Поле не може бути порожнім!");
                textBox.Text = "0"; // або будь-яке інше значення за замовчуванням
            }
        }
    }
}
