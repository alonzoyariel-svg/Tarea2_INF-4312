namespace ejercicio_4_INF_4312
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
            txtnumero1 = new TextBox();
            txtnumero2 = new TextBox();
            label1 = new Label();
            Btnsumar = new Button();
            lblresultado = new Label();
            SuspendLayout();
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(31, 54);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 0;
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(191, 54);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(100, 23);
            txtnumero2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 52);
            label1.Name = "label1";
            label1.Size = new Size(21, 21);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // Btnsumar
            // 
            Btnsumar.Location = new Point(204, 147);
            Btnsumar.Name = "Btnsumar";
            Btnsumar.Size = new Size(75, 23);
            Btnsumar.TabIndex = 3;
            Btnsumar.Text = "Sumar";
            Btnsumar.UseVisualStyleBackColor = true;
            Btnsumar.Click += Btnsumar_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(31, 98);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 21);
            lblresultado.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 265);
            Controls.Add(lblresultado);
            Controls.Add(Btnsumar);
            Controls.Add(label1);
            Controls.Add(txtnumero2);
            Controls.Add(txtnumero1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnumero1;
        private TextBox txtnumero2;
        private Label label1;
        private Button Btnsumar;
        private Label lblresultado;
    }
}
