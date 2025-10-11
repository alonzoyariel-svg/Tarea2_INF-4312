namespace Ejercicio_8_INF_4312
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
            Btntocar = new Button();
            Btnmostrar = new Button();
            label1 = new Label();
            label2 = new Label();
            lblconteo = new Label();
            SuspendLayout();
            // 
            // Btntocar
            // 
            Btntocar.Location = new Point(55, 49);
            Btntocar.Name = "Btntocar";
            Btntocar.Size = new Size(75, 23);
            Btntocar.TabIndex = 0;
            Btntocar.Text = "Tocar";
            Btntocar.UseVisualStyleBackColor = true;
            Btntocar.Click += Btntocar_Click;
            // 
            // Btnmostrar
            // 
            Btnmostrar.Location = new Point(55, 136);
            Btnmostrar.Name = "Btnmostrar";
            Btnmostrar.Size = new Size(75, 23);
            Btnmostrar.TabIndex = 1;
            Btnmostrar.Text = "Mostrar";
            Btnmostrar.UseVisualStyleBackColor = true;
            Btnmostrar.Click += Btnmostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 23);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 2;
            label1.Text = "Tocar para acumular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 106);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 3;
            label2.Text = "Mostrar cantidad acumulada";
            // 
            // lblconteo
            // 
            lblconteo.AutoSize = true;
            lblconteo.Location = new Point(61, 181);
            lblconteo.Name = "lblconteo";
            lblconteo.Size = new Size(99, 15);
            lblconteo.TabIndex = 4;
            lblconteo.Text = "Mostrar Cantidad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 242);
            Controls.Add(lblconteo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btnmostrar);
            Controls.Add(Btntocar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btntocar;
        private Button Btnmostrar;
        private Label label1;
        private Label label2;
        private Label lblconteo;
    }
}
