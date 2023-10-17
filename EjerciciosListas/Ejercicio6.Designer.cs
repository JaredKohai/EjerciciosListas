namespace EjerciciosListas
{
    partial class Ejercicio6
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
            btnInvertir = new Button();
            lblPalabraInvertida = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(235, 132);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(100, 23);
            txtPalabra.TabIndex = 0;
            // 
            // btnInvertir
            // 
            btnInvertir.Location = new Point(245, 172);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(75, 23);
            btnInvertir.TabIndex = 1;
            btnInvertir.Text = "Invertir";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // lblPalabraInvertida
            // 
            lblPalabraInvertida.AutoSize = true;
            lblPalabraInvertida.Location = new Point(413, 140);
            lblPalabraInvertida.Name = "lblPalabraInvertida";
            lblPalabraInvertida.Size = new Size(95, 15);
            lblPalabraInvertida.TabIndex = 2;
            lblPalabraInvertida.Text = "Palabra invertida";
            lblPalabraInvertida.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(331, 33);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 3;
            label1.Text = "Palabra invertida";
            // 
            // Ejercicio6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblPalabraInvertida);
            Controls.Add(btnInvertir);
            Controls.Add(txtPalabra);
            Name = "Ejercicio6";
            Text = "Ejercicio6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalabra;
        private Button btnInvertir;
        private Label lblPalabraInvertida;
        private Label label1;
    }
}