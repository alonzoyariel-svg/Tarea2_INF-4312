namespace Ejercicio_6_INF_4312
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
            cbbcolores = new ComboBox();
            Btncambiar = new Button();
            SuspendLayout();
            // 
            // cbbcolores
            // 
            cbbcolores.AutoCompleteCustomSource.AddRange(new string[] { "Rojo", "Verde", "Azul" });
            cbbcolores.FormattingEnabled = true;
            cbbcolores.Items.AddRange(new object[] { "Rojo", "Verde", "Azul" });
            cbbcolores.Location = new Point(65, 52);
            cbbcolores.Name = "cbbcolores";
            cbbcolores.Size = new Size(121, 23);
            cbbcolores.TabIndex = 0;
            cbbcolores.Text = "Elige";
            // 
            // Btncambiar
            // 
            Btncambiar.Location = new Point(65, 109);
            Btncambiar.Name = "Btncambiar";
            Btncambiar.Size = new Size(75, 23);
            Btncambiar.TabIndex = 1;
            Btncambiar.Text = "Cambiar";
            Btncambiar.UseVisualStyleBackColor = true;
            Btncambiar.Click += BtnCambiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 276);
            Controls.Add(Btncambiar);
            Controls.Add(cbbcolores);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbbcolores;
        private Button Btncambiar;
    }
}
