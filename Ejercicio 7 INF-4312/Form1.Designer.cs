namespace Ejercicio_7_INF_4312
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
            Btninsertar = new Button();
            ltblista = new ListBox();
            txtinsertar = new TextBox();
            SuspendLayout();
            // 
            // Btninsertar
            // 
            Btninsertar.Location = new Point(99, 83);
            Btninsertar.Name = "Btninsertar";
            Btninsertar.Size = new Size(75, 23);
            Btninsertar.TabIndex = 0;
            Btninsertar.Text = "Insertar";
            Btninsertar.UseVisualStyleBackColor = true;
            Btninsertar.Click += Btninsertar_Click;
            // 
            // ltblista
            // 
            ltblista.FormattingEnabled = true;
            ltblista.ItemHeight = 15;
            ltblista.Location = new Point(30, 125);
            ltblista.Name = "ltblista";
            ltblista.Size = new Size(120, 94);
            ltblista.TabIndex = 1;
            // 
            // txtinsertar
            // 
            txtinsertar.Location = new Point(30, 31);
            txtinsertar.Multiline = true;
            txtinsertar.Name = "txtinsertar";
            txtinsertar.Size = new Size(134, 37);
            txtinsertar.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 297);
            Controls.Add(txtinsertar);
            Controls.Add(ltblista);
            Controls.Add(Btninsertar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btninsertar;
        private ListBox ltblista;
        private TextBox txtinsertar;
    }
}
