using System.IO;
namespace Ejercicio_15_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            // Configurar el filtro para mostrar solo archivos de texto
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            // Mostrar el cuadro de diálogo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Usar la instrucción 'using' asegura que el StreamReader se cierre automáticamente
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        // Leer todo el contenido del archivo y asignarlo al TextBox
                        txtContenidoArchivo.Text = sr.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Configurar el filtro para guardar como archivo de texto
            saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";

            // Mostrar el cuadro de diálogo
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Usar la instrucción 'using' asegura que el StreamWriter se cierre automáticamente
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        // Escribir el contenido del TextBox al archivo
                        sw.Write(txtContenidoArchivo.Text);
                        MessageBox.Show("Archivo guardado exitosamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error de Escritura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
