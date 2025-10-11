namespace Ejercicio_16_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valor1 = 0;
        string operacion = "";
        bool seRequiereNuevoNumero = true;

        private void BtnDigito_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (seRequiereNuevoNumero)
            {
                txtDisplay.Text = b.Text;
                seRequiereNuevoNumero = false;
            }
            else
            {
                if (txtDisplay.Text == "0" && b.Text != ",")
                {
                    txtDisplay.Text = b.Text;
                }
                else
                {
                    txtDisplay.Text += b.Text;
                }
            }
        }

        private void BtnOperacion_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (double.TryParse(txtDisplay.Text, out valor1))
            {
                operacion = b.Text;
                seRequiereNuevoNumero = true;
                this.Text = $"Calculadora - {valor1} {operacion}";
            }
            else
            {
                MessageBox.Show("Entrada inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            double valor2;
            double resultado = 0;

            if (double.TryParse(txtDisplay.Text, out valor2))
            {
                switch (operacion)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        break;
                    case "-":
                        resultado = valor1 - valor2;
                        break;
                    case "*":
                        resultado = valor1 * valor2;
                        break;
                    case "/":
                        if (valor2 != 0)
                        {
                            resultado = valor1 / valor2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    default:
                        resultado = valor2;
                        break;
                }

                txtDisplay.Text = resultado.ToString();
                valor1 = resultado;
                operacion = "";
                seRequiereNuevoNumero = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            valor1 = 0;
            operacion = "";
            seRequiereNuevoNumero = true;
            this.Text = "Calculadora";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
