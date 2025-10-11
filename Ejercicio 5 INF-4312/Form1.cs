namespace Ejercicio_5_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
            string opcionSeleccionada = "";

      
            if (rbtn1.Checked)
            {
           
                opcionSeleccionada = rbtn1.Text;
            }
            else if (rbtn2.Checked)
            {
             
                opcionSeleccionada = rbtn2.Text;
            }
            else if (rbtn3.Checked)
            {

                opcionSeleccionada = rbtn3.Text;
            }

          
            if (!string.IsNullOrEmpty(opcionSeleccionada))
            {
               txtelegido.Text = $"Opción Elegida: {opcionSeleccionada}";
                MessageBox.Show($"Ha seleccionado: {opcionSeleccionada}", "Selección Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                txtelegido.Text = "Por favor, seleccione una opción.";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
