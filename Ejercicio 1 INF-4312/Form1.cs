namespace Practica_2_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txtnombre.Text;
            string matricula = txtmatricula.Text;
            string mensaje = $"Datos Ingresados:\n\n" +
                             $"Nombre Completo: {nombreCompleto}\n" +
                             $"Matrícula: {matricula}";

            MessageBox.Show(mensaje, "Información Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtnombre.Clear();
            txtmatricula.Clear();
        }

private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
