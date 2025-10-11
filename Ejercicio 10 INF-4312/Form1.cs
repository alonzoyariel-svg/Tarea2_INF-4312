namespace Ejercicio_10_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
            // 1. Obtener el nombre del TextBox txtnombre
            string nombre = txtnombre.Text;

            // 2. Obtener la matrícula del TextBox txtmatricula
            string matricula = txtmatricula.Text;

            // 3. Construir el mensaje completo
            string mensaje = $"Hola, soy {nombre} y mi matrícula es {matricula}.";

            // 4. Mostrar el mensaje al usuario usando un MessageBox
            MessageBox.Show(mensaje, "Mi Presentación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
