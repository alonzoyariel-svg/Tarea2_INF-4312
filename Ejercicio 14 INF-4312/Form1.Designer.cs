namespace Ejercicio_14_INF_4312
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
            Tcpestaña = new TabControl();
            tabPage1 = new TabPage();
            lblPestaña1 = new Label();
            tabPage2 = new TabPage();
            lblPestaña2 = new Label();
            tabPage3 = new TabPage();
            lblPestaña3 = new Label();
            Tcpestaña.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // Tcpestaña
            // 
            Tcpestaña.Controls.Add(tabPage1);
            Tcpestaña.Controls.Add(tabPage2);
            Tcpestaña.Controls.Add(tabPage3);
            Tcpestaña.Location = new Point(12, 12);
            Tcpestaña.Name = "Tcpestaña";
            Tcpestaña.SelectedIndex = 0;
            Tcpestaña.Size = new Size(407, 201);
            Tcpestaña.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblPestaña1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(399, 173);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pestaña UNO";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblPestaña1
            // 
            lblPestaña1.AutoSize = true;
            lblPestaña1.Location = new Point(32, 21);
            lblPestaña1.Name = "lblPestaña1";
            lblPestaña1.Size = new Size(132, 15);
            lblPestaña1.TabIndex = 0;
            lblPestaña1.Text = "Contenido de Pestaña 1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblPestaña2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(399, 173);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pestaña DOS";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPestaña2
            // 
            lblPestaña2.AutoSize = true;
            lblPestaña2.Location = new Point(35, 19);
            lblPestaña2.Name = "lblPestaña2";
            lblPestaña2.Size = new Size(132, 15);
            lblPestaña2.TabIndex = 0;
            lblPestaña2.Text = "Contenido de Pestaña 2";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblPestaña3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(399, 173);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Pestaña TRES";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblPestaña3
            // 
            lblPestaña3.AutoSize = true;
            lblPestaña3.Location = new Point(29, 24);
            lblPestaña3.Name = "lblPestaña3";
            lblPestaña3.Size = new Size(132, 15);
            lblPestaña3.TabIndex = 0;
            lblPestaña3.Text = "Contenido de Pestaña 3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 225);
            Controls.Add(Tcpestaña);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Tcpestaña.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tcpestaña;
        private TabPage tabPage1;
        private Label lblPestaña1;
        private TabPage tabPage2;
        private Label lblPestaña2;
        private TabPage tabPage3;
        private Label lblPestaña3;
    }
}
