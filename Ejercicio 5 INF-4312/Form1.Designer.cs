namespace Ejercicio_5_INF_4312
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
            rbtn1 = new RadioButton();
            rbtn2 = new RadioButton();
            rbtn3 = new RadioButton();
            Btnmostrar = new Button();
            lblelegida = new Label();
            txtelegido = new TextBox();
            SuspendLayout();
            // 
            // rbtn1
            // 
            rbtn1.AutoSize = true;
            rbtn1.Location = new Point(51, 31);
            rbtn1.Name = "rbtn1";
            rbtn1.Size = new Size(73, 19);
            rbtn1.TabIndex = 0;
            rbtn1.TabStop = true;
            rbtn1.Text = "Opcion 1";
            rbtn1.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            rbtn2.AutoSize = true;
            rbtn2.Location = new Point(51, 56);
            rbtn2.Name = "rbtn2";
            rbtn2.Size = new Size(73, 19);
            rbtn2.TabIndex = 1;
            rbtn2.TabStop = true;
            rbtn2.Text = "Opcion 2";
            rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn3
            // 
            rbtn3.AutoSize = true;
            rbtn3.Location = new Point(51, 81);
            rbtn3.Name = "rbtn3";
            rbtn3.Size = new Size(73, 19);
            rbtn3.TabIndex = 2;
            rbtn3.TabStop = true;
            rbtn3.Text = "Opcion 3";
            rbtn3.UseVisualStyleBackColor = true;
            // 
            // Btnmostrar
            // 
            Btnmostrar.Location = new Point(49, 139);
            Btnmostrar.Name = "Btnmostrar";
            Btnmostrar.Size = new Size(75, 23);
            Btnmostrar.TabIndex = 3;
            Btnmostrar.Text = "Mostrar";
            Btnmostrar.UseVisualStyleBackColor = true;
            // 
            // lblelegida
            // 
            lblelegida.AutoSize = true;
            lblelegida.Location = new Point(46, 198);
            lblelegida.Name = "lblelegida";
            lblelegida.Size = new Size(0, 15);
            lblelegida.TabIndex = 4;
            // 
            // txtelegido
            // 
            txtelegido.Location = new Point(49, 189);
            txtelegido.Name = "txtelegido";
            txtelegido.Size = new Size(100, 23);
            txtelegido.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 283);
            Controls.Add(txtelegido);
            Controls.Add(lblelegida);
            Controls.Add(Btnmostrar);
            Controls.Add(rbtn3);
            Controls.Add(rbtn2);
            Controls.Add(rbtn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtn1;
        private RadioButton rbtn2;
        private RadioButton rbtn3;
        private Button Btnmostrar;
        private Label lblelegida;
        private TextBox txtelegido;
    }
}
