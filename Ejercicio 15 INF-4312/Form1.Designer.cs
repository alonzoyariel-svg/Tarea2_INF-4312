namespace Ejercicio_15_INF_4312
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
            BtnAbrir = new Button();
            BtnGuardar = new Button();
            txtContenidoArchivo = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // BtnAbrir
            // 
            BtnAbrir.Location = new Point(56, 150);
            BtnAbrir.Name = "BtnAbrir";
            BtnAbrir.Size = new Size(75, 23);
            BtnAbrir.TabIndex = 0;
            BtnAbrir.Text = "Abrir";
            BtnAbrir.UseVisualStyleBackColor = true;
            BtnAbrir.Click += BtnAbrir_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(206, 150);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 1;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // txtContenidoArchivo
            // 
            txtContenidoArchivo.Location = new Point(56, 28);
            txtContenidoArchivo.Multiline = true;
            txtContenidoArchivo.Name = "txtContenidoArchivo";
            txtContenidoArchivo.Size = new Size(225, 102);
            txtContenidoArchivo.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 305);
            Controls.Add(txtContenidoArchivo);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnAbrir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAbrir;
        private Button BtnGuardar;
        private TextBox txtContenidoArchivo;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
