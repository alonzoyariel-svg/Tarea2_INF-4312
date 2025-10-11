namespace ejercicio_2_INF_4312
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
            Btncambiar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Btncambiar
            // 
            Btncambiar.Location = new Point(44, 62);
            Btncambiar.Name = "Btncambiar";
            Btncambiar.Size = new Size(75, 23);
            Btncambiar.TabIndex = 0;
            Btncambiar.Text = "Cambiar ";
            Btncambiar.UseVisualStyleBackColor = true;
            Btncambiar.Click += Btncambiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 23);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "Texto Estandar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(171, 124);
            Controls.Add(label1);
            Controls.Add(Btncambiar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btncambiar;
        private Label label1;
    }
}
