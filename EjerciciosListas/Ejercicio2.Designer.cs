namespace EjerciciosListas
{
    partial class Ejercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstPares = new ListBox();
            lstImpares = new ListBox();
            btnGenerar = new Button();
            label1 = new Label();
            lblNumerosGenerados = new Label();
            SuspendLayout();
            // 
            // lstPares
            // 
            lstPares.FormattingEnabled = true;
            lstPares.ItemHeight = 15;
            lstPares.Location = new Point(90, 81);
            lstPares.Name = "lstPares";
            lstPares.Size = new Size(170, 154);
            lstPares.TabIndex = 0;
            lstPares.SelectedIndexChanged += lstPares_SelectedIndexChanged;
            // 
            // lstImpares
            // 
            lstImpares.FormattingEnabled = true;
            lstImpares.ItemHeight = 15;
            lstImpares.Location = new Point(446, 81);
            lstImpares.Name = "lstImpares";
            lstImpares.Size = new Size(176, 154);
            lstImpares.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.Green;
            btnGenerar.Location = new Point(277, 212);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(137, 23);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar Numeros";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(200, 26);
            label1.Name = "label1";
            label1.Size = new Size(328, 37);
            label1.TabIndex = 3;
            label1.Text = "Ejercicio 2 Pares e Impares";
            // 
            // lblNumerosGenerados
            // 
            lblNumerosGenerados.AutoSize = true;
            lblNumerosGenerados.Location = new Point(174, 262);
            lblNumerosGenerados.Name = "lblNumerosGenerados";
            lblNumerosGenerados.Size = new Size(114, 15);
            lblNumerosGenerados.TabIndex = 4;
            lblNumerosGenerados.Text = "Números generados";
            lblNumerosGenerados.Click += lblNumerosGenerados_Click;
            // 
            // Ejercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNumerosGenerados);
            Controls.Add(label1);
            Controls.Add(btnGenerar);
            Controls.Add(lstImpares);
            Controls.Add(lstPares);
            Name = "Ejercicio2";
            Text = "Ejercicio 2 - Pares Impares";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPares;
        private ListBox lstImpares;
        private Button btnGenerar;
        private Label label1;
        private Label lblNumerosGenerados;
    }
}