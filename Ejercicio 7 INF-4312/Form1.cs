namespace Ejercicio_7_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btninsertar_Click(object sender, EventArgs e)
        {
         
            string nuevoElemento = txtinsertar.Text.Trim(); 

         
            if (!string.IsNullOrEmpty(nuevoElemento))
            {
             
                ltblista.Items.Add(nuevoElemento);

             
                txtinsertar.Clear();

            
                txtinsertar.Focus();
            }
            else
            {
               
                MessageBox.Show("Por favor, ingrese un texto válido para añadir a la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
