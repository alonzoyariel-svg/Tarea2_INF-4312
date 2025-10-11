namespace Ejercicio_12_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnconvertir_Click(object sender, EventArgs e)
        {
            double celsius;
            double fahrenheit;

            bool esNumeroValido = double.TryParse(txtTemperatura.Text, out celsius);

            if (esNumeroValido)
            {
                fahrenheit = (celsius * 9 / 5) + 32;

                lblresultado.Text =
                    $"{celsius:N2}°C es igual a {fahrenheit:N2}°F";

            }
            else
            {
                lblresultado.Text = "Error: Ingrese un valor numérico válido.";
                MessageBox.Show(
                    "Por favor, ingrese solo números en el campo de temperatura.",
                    "Error de Entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
