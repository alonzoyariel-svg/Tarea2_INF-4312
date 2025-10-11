namespace Ejercicio_13_INF_4312
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
            components = new System.ComponentModel.Container();
            Btniniciar = new Button();
            Btndetener = new Button();
            pgbprogreso = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Btniniciar
            // 
            Btniniciar.Location = new Point(12, 108);
            Btniniciar.Name = "Btniniciar";
            Btniniciar.Size = new Size(75, 23);
            Btniniciar.TabIndex = 0;
            Btniniciar.Text = "Iniciar";
            Btniniciar.UseVisualStyleBackColor = true;
            Btniniciar.Click += Btniniciar_Click;
            // 
            // Btndetener
            // 
            Btndetener.Location = new Point(140, 108);
            Btndetener.Name = "Btndetener";
            Btndetener.Size = new Size(75, 23);
            Btndetener.TabIndex = 1;
            Btndetener.Text = "Detener";
            Btndetener.UseVisualStyleBackColor = true;
            Btndetener.Click += Btndetener_Click;
            // 
            // pgbprogreso
            // 
            pgbprogreso.Location = new Point(12, 53);
            pgbprogreso.Name = "pgbprogreso";
            pgbprogreso.Size = new Size(203, 37);
            pgbprogreso.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 191);
            Controls.Add(pgbprogreso);
            Controls.Add(Btndetener);
            Controls.Add(Btniniciar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Btniniciar;
        private Button Btndetener;
        private ProgressBar pgbprogreso;
        private System.Windows.Forms.Timer timer1;
    }
}
