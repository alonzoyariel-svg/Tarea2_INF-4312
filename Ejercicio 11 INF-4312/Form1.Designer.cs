namespace Ejercicio_11_INF_4312
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
            dtpfecha = new DateTimePicker();
            Btnmostrar = new Button();
            lblfecha = new Label();
            SuspendLayout();
            // 
            // dtpfecha
            // 
            dtpfecha.Location = new Point(55, 33);
            dtpfecha.Name = "dtpfecha";
            dtpfecha.Size = new Size(200, 23);
            dtpfecha.TabIndex = 0;
            // 
            // Btnmostrar
            // 
            Btnmostrar.Location = new Point(61, 87);
            Btnmostrar.Name = "Btnmostrar";
            Btnmostrar.Size = new Size(75, 23);
            Btnmostrar.TabIndex = 1;
            Btnmostrar.Text = "Mostrar";
            Btnmostrar.UseVisualStyleBackColor = true;
            Btnmostrar.Click += Btnmostrar_Click;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Location = new Point(176, 91);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(38, 15);
            lblfecha.TabIndex = 2;
            lblfecha.Text = "Fecha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 198);
            Controls.Add(lblfecha);
            Controls.Add(Btnmostrar);
            Controls.Add(dtpfecha);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpfecha;
        private Button Btnmostrar;
        private Label lblfecha;
    }
}
