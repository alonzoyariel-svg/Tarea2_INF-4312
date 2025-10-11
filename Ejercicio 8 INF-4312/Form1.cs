namespace Ejercicio_8_INF_4312
{
    public partial class Form1 : Form
    {
        private int contadorToques = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btntocar_Click(object sender, EventArgs e)
        {
            
            contadorToques++;
            this.Text = $"Toques: {contadorToques}";
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {

            lblconteo.Text = $"El botón Btntocar ha sido presionado {contadorToques} veces.";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
