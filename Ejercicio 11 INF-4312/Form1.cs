namespace Ejercicio_11_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
 
            DateTime fechaSeleccionada = dtpfecha.Value;

            string textoFecha = fechaSeleccionada.ToLongDateString();

            lblfecha.Text = $"Fecha Elegida: {textoFecha}";
         
            MessageBox.Show($"La fecha seleccionada es: {textoFecha}", "Fecha Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
