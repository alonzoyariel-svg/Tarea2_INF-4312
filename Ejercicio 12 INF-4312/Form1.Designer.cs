namespace Ejercicio_12_INF_4312
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
            Btnconvertir = new Button();
            lblresultado = new Label();
            txtTemperatura = new TextBox();
            SuspendLayout();
            // 
            // Btnconvertir
            // 
            Btnconvertir.Location = new Point(161, 81);
            Btnconvertir.Name = "Btnconvertir";
            Btnconvertir.Size = new Size(75, 23);
            Btnconvertir.TabIndex = 0;
            Btnconvertir.Text = "Convertir ";
            Btnconvertir.UseVisualStyleBackColor = true;
            Btnconvertir.Click += Btnconvertir_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(163, 29);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(73, 15);
            lblresultado.TabIndex = 1;
            lblresultado.Text = "Temperatura";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(33, 26);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(100, 23);
            txtTemperatura.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 271);
            Controls.Add(txtTemperatura);
            Controls.Add(lblresultado);
            Controls.Add(Btnconvertir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btnconvertir;
        private Label lblresultado;
        private TextBox txtTemperatura;
    }
}
