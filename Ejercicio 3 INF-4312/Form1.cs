namespace Ejercicio_3_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
           
            string contenido = txtcontenido.Text;

            lblResultado.Text = contenido;

            MessageBox.Show("El texto ha sido transferido a la etiqueta.", "Transferencia Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
