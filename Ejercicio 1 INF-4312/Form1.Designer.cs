namespace Practica_2_INF_4312
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btniniciar = new Button();
            txtnombre = new TextBox();
            txtmatricula = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Name = "label1";
            label1.Size = new Size(281, 15);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al formulario de NOMBRE y MATRICULA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 166);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Matricula";
            // 
            // btniniciar
            // 
            btniniciar.Location = new Point(199, 287);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(75, 23);
            btniniciar.TabIndex = 3;
            btniniciar.Text = "Iniciar";
            btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.BtnInicio_Click);

            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(28, 118);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 4;
            // 
            // txtmatricula
            // 
            txtmatricula.Location = new Point(28, 194);
            txtmatricula.Name = "txtmatricula";
            txtmatricula.Size = new Size(100, 23);
            txtmatricula.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 450);
            Controls.Add(txtmatricula);
            Controls.Add(txtnombre);
            Controls.Add(btniniciar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btniniciar;
        private TextBox txtnombre;
        private TextBox txtmatricula;
    }
}
