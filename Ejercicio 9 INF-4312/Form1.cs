namespace Ejercicio_9_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
            string entrada = txtinsertar.Text.Trim();

            double numeroConvertido;

            bool esNumeroValido = double.TryParse(entrada, out numeroConvertido);

            if (esNumeroValido)
            {
                MessageBox.Show(
                    $"Éxito. La entrada \"{entrada}\" es un número válido.",
                    "Validación Correcta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    $"Error. La entrada \"{entrada}\" no es un número válido. Por favor, ingrese solo dígitos.",
                    "Error de Entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtinsertar.Clear();
                txtinsertar.Focus();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
