namespace Ejercicio_9_INF_4312
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
            txtinsertar = new TextBox();
            SuspendLayout();
            // 
            // Btnmostrar
            // 
            Btnmostrar.Location = new Point(43, 101);
            Btnmostrar.Name = "Btnmostrar";
            Btnmostrar.Size = new Size(75, 23);
            Btnmostrar.TabIndex = 0;
            Btnmostrar.Text = "Mostrar";
            Btnmostrar.UseVisualStyleBackColor = true;
            Btnmostrar.Click += Btnmostrar_Click;
            // 
            // txtinsertar
            // 
            txtinsertar.Location = new Point(43, 48);
            txtinsertar.Multiline = true;
            txtinsertar.Name = "txtinsertar";
            txtinsertar.Size = new Size(115, 35);
            txtinsertar.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 247);
            Controls.Add(txtinsertar);
            Controls.Add(Btnmostrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btnmostrar;
        private TextBox txtinsertar;
    }
}
