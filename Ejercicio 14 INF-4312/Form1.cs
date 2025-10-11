namespace Ejercicio_14_INF_4312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TabPage tab1 = new TabPage("Pestaña UNO");
            Label lbl1 = new Label();
            lbl1.Text = "Contenido de Pestaña 1.";
            lbl1.Location = new Point(10, 10);
            tab1.Controls.Add(lbl1);
            Tcpestaña.TabPages.Add(tab1);

            TabPage tab2 = new TabPage("Pestaña DOS");
            Label lbl2 = new Label();
            lbl2.Text = "Contenido de Pestaña 2.";
            lbl2.Location = new Point(10, 10);
            tab2.Controls.Add(lbl2);
            Tcpestaña.TabPages.Add(tab2);

            TabPage tab3 = new TabPage("Pestaña DOS");
            Label lbl3 = new Label();
            lbl3.Text = "Contenido de Pestaña 3.";
            lbl3.Location = new Point(10, 10);
            tab3.Controls.Add(lbl3);
            Tcpestaña.TabPages.Add(tab3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
