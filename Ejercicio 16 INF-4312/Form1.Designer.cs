namespace Ejercicio_16_INF_4312
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
            txtDisplay = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            bnt7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnMulti = new Button();
            btnDivision = new Button();
            btnResta = new Button();
            btnSuma = new Button();
            btnIgual = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(14, 13);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(330, 51);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(14, 170);
            btn1.Name = "btn1";
            btn1.Size = new Size(52, 44);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += BtnDigito_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(72, 170);
            btn2.Name = "btn2";
            btn2.Size = new Size(52, 44);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += BtnDigito_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(130, 170);
            btn3.Name = "btn3";
            btn3.Size = new Size(52, 44);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += BtnDigito_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(14, 120);
            btn4.Name = "btn4";
            btn4.Size = new Size(52, 44);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += BtnDigito_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(72, 120);
            btn5.Name = "btn5";
            btn5.Size = new Size(52, 44);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += BtnDigito_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(130, 120);
            btn6.Name = "btn6";
            btn6.Size = new Size(52, 44);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += BtnDigito_Click;
            // 
            // bnt7
            // 
            bnt7.Location = new Point(14, 70);
            bnt7.Name = "bnt7";
            bnt7.Size = new Size(52, 44);
            bnt7.TabIndex = 7;
            bnt7.Text = "7";
            bnt7.UseVisualStyleBackColor = true;
            bnt7.Click += BtnDigito_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(72, 70);
            btn8.Name = "btn8";
            btn8.Size = new Size(52, 44);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += BtnDigito_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(130, 70);
            btn9.Name = "btn9";
            btn9.Size = new Size(52, 44);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += BtnDigito_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(14, 220);
            btn0.Name = "btn0";
            btn0.Size = new Size(168, 44);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += BtnDigito_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMulti.Location = new Point(188, 70);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(75, 44);
            btnMulti.TabIndex = 11;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += BtnOperacion_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivision.Location = new Point(269, 70);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(75, 44);
            btnDivision.TabIndex = 12;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += BtnOperacion_Click;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResta.Location = new Point(188, 120);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(75, 44);
            btnResta.TabIndex = 13;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += BtnOperacion_Click;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuma.Location = new Point(269, 120);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(75, 94);
            btnSuma.TabIndex = 14;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += BtnOperacion_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(188, 170);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(75, 94);
            btnIgual.TabIndex = 15;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += BtnIgual_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(269, 220);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 44);
            btnClear.TabIndex = 16;
            btnClear.Text = "⌫";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 277);
            Controls.Add(btnClear);
            Controls.Add(btnIgual);
            Controls.Add(btnSuma);
            Controls.Add(btnResta);
            Controls.Add(btnDivision);
            Controls.Add(btnMulti);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(bnt7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button bnt7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnMulti;
        private Button btnDivision;
        private Button btnResta;
        private Button btnSuma;
        private Button btnIgual;
        private Button btnClear;
    }
}
