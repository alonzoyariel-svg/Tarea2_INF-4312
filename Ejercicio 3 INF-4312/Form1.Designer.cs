namespace Ejercicio_3_INF_4312
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btnmostrar = new Button();
            txtcontenido = new TextBox();
            label1 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // Btnmostrar
            // 
            Btnmostrar.Location = new Point(55, 108);
            Btnmostrar.Name = "Btnmostrar";
            Btnmostrar.Size = new Size(75, 23);
            Btnmostrar.TabIndex = 0;
            Btnmostrar.Text = "Mostrar";
            Btnmostrar.UseVisualStyleBackColor = true;
            Btnmostrar.Click += Btnmostrar_Click;
            // 
            // txtcontenido
            // 
            txtcontenido.Location = new Point(47, 42);
            txtcontenido.Name = "txtcontenido";
            txtcontenido.Size = new Size(100, 23);
            txtcontenido.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 17);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Inserte Datos";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(102, 164);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 229);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(txtcontenido);
            Controls.Add(Btnmostrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btnmostrar;
        private TextBox txtcontenido;
        private Label label1;
        private Label lblResultado;
    }
}
