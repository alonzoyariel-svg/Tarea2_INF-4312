namespace Ejercicio_13_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pgbprogreso.Minimum = 0;
            pgbprogreso.Maximum = 100;
            pgbprogreso.Value = 0;
        }
        private void Btniniciar_Click(object sender, EventArgs e)
        {
            // Inicia el Timer. Esto hace que el evento Tick se ejecute cada 100ms.
            timer1.Start();
            Btniniciar.Enabled = false; // Deshabilitar el botón de inicio
            Btndetener.Enabled = true;  // Habilitar el botón de detener
        }

        private void Btndetener_Click(object sender, EventArgs e)
        {
            // Detiene el Timer.
            timer1.Stop();
            Btniniciar.Enabled = true; // Habilitar el botón de inicio
            Btndetener.Enabled = false; // Deshabilitar el botón de detener
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Este método se llama cada vez que el Timer "hace tick"

            if (pgbprogreso.Value < 100)
            {
                // 1. Incrementar el valor de la barra de progreso
                pgbprogreso.Value += 5;
            }
            else
            {
                // 2. Si la barra llega al 100%, la detiene y la reinicia
                timer1.Stop();
                MessageBox.Show("¡Progreso Completado!", "Finalizado");
                pgbprogreso.Value = 0; // Reiniciar la barra
                Btniniciar.Enabled = true;
                Btndetener.Enabled = false;
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        { 
        
        }

       
    } 
}
