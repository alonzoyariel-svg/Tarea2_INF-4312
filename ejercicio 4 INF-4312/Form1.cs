namespace ejercicio_4_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsumar_Click(object sender, EventArgs e)
        {
          
            double numero1, numero2, resultado;

    
            bool esNumero1Valido = double.TryParse(txtnumero1.Text, out numero1);
            bool esNumero2Valido = double.TryParse(txtnumero2.Text, out numero2);

         
            if (esNumero1Valido && esNumero2Valido)
            {
     
                resultado = numero1 + numero2;

       
                lblresultado.Text = $"Resultado: {resultado}";
            }
            else
            {
            
                lblresultado.Text = "Error: Ingrese números válidos.";
                MessageBox.Show("Por favor, ingrese solo valores numéricos en ambas cajas.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
