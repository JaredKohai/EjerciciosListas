namespace EjerciciosListas
{
    partial class Ejercicio7
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
            txtPalabra = new TextBox();
            btnVerificar = new Button();
            lblResultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(317, 97);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(100, 23);
            txtPalabra.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(327, 138);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.Red;
            lblResultado.Location = new Point(300, 204);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(134, 37);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(241, 22);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 3;
            label1.Text = "¿Es un palindromo?";
            // 
            // Ejercicio7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(btnVerificar);
            Controls.Add(txtPalabra);
            Name = "Ejercicio7";
            Text = "Ejercicio7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalabra;
        private Button btnVerificar;
        private Label lblResultado;
        private Label label1;
    }
}