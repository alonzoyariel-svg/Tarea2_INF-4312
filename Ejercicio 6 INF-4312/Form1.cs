using System.Windows.Forms; 
using System.Drawing;

namespace Ejercicio_6_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
           
            string colorSeleccionado = cbbcolores.SelectedItem?.ToString();

           
            if (!string.IsNullOrEmpty(colorSeleccionado))
            {
               
                switch (colorSeleccionado)
                {
                    case "Rojo":
                       
                        this.BackColor = Color.Red;
                        break;
                    case "Verde":
                        this.BackColor = Color.Green;
                        break;
                    case "Azul":
                        this.BackColor = Color.Blue;
                        break;
                    default:
                        MessageBox.Show("Color no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un color de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}