namespace EjerciciosListas
{
    partial class Ejercicio5
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
            btnAgregarPalabra = new Button();
            lstPalabrasPorLetra = new ListBox();
            label1 = new Label();
            lstTodasLasPalabras = new ListBox();
            SuspendLayout();
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(158, 107);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(100, 23);
            txtPalabra.TabIndex = 0;
            txtPalabra.Enter += txtPalabra_Enter;
            // 
            // btnAgregarPalabra
            // 
            btnAgregarPalabra.Location = new Point(171, 147);
            btnAgregarPalabra.Name = "btnAgregarPalabra";
            btnAgregarPalabra.Size = new Size(75, 23);
            btnAgregarPalabra.TabIndex = 1;
            btnAgregarPalabra.Text = "Agregar";
            btnAgregarPalabra.UseVisualStyleBackColor = true;
            btnAgregarPalabra.Click += btnAgregarPalabra_Click;
            // 
            // lstPalabrasPorLetra
            // 
            lstPalabrasPorLetra.FormattingEnabled = true;
            lstPalabrasPorLetra.ItemHeight = 15;
            lstPalabrasPorLetra.Location = new Point(408, 75);
            lstPalabrasPorLetra.Name = "lstPalabrasPorLetra";
            lstPalabrasPorLetra.Size = new Size(330, 289);
            lstPalabrasPorLetra.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 75);
            label1.Name = "label1";
            label1.Size = new Size(230, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingrese una palabra y haga clic en Agregar";
            // 
            // lstTodasLasPalabras
            // 
            lstTodasLasPalabras.FormattingEnabled = true;
            lstTodasLasPalabras.ItemHeight = 15;
            lstTodasLasPalabras.Location = new Point(64, 225);
            lstTodasLasPalabras.Name = "lstTodasLasPalabras";
            lstTodasLasPalabras.Size = new Size(289, 109);
            lstTodasLasPalabras.TabIndex = 4;
            // 
            // Ejercicio5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstTodasLasPalabras);
            Controls.Add(label1);
            Controls.Add(lstPalabrasPorLetra);
            Controls.Add(btnAgregarPalabra);
            Controls.Add(txtPalabra);
            Name = "Ejercicio5";
            Text = "Ejercicio5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalabra;
        private Button btnAgregarPalabra;
        private ListBox lstPalabrasPorLetra;
        private Label label1;
        private ListBox lstTodasLasPalabras;
    }
}