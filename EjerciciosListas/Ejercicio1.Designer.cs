namespace EjerciciosListas
{
    partial class Ejercicio1
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
            lblDisponibles = new Label();
            lblRetirados = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRetirar = new TextBox();
            btnAgregarProducto = new Button();
            btnRetirarProducto = new Button();
            listBoxProductos = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblDisponibles
            // 
            lblDisponibles.AutoSize = true;
            lblDisponibles.Location = new Point(189, 67);
            lblDisponibles.Name = "lblDisponibles";
            lblDisponibles.Size = new Size(13, 15);
            lblDisponibles.TabIndex = 0;
            lblDisponibles.Text = "0";
            // 
            // lblRetirados
            // 
            lblRetirados.AutoSize = true;
            lblRetirados.Location = new Point(189, 92);
            lblRetirados.Name = "lblRetirados";
            lblRetirados.Size = new Size(13, 15);
            lblRetirados.TabIndex = 1;
            lblRetirados.Text = "0";
            lblRetirados.Click += lblRetirados_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 67);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 2;
            label3.Text = "Productos disponibles:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 92);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidades retiradas:";
            // 
            // txtRetirar
            // 
            txtRetirar.Location = new Point(50, 136);
            txtRetirar.Name = "txtRetirar";
            txtRetirar.Size = new Size(100, 23);
            txtRetirar.TabIndex = 4;
            txtRetirar.TextChanged += txtRetirar_TextChanged;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(447, 243);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(75, 23);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnRetirarProducto
            // 
            btnRetirarProducto.Location = new Point(156, 136);
            btnRetirarProducto.Name = "btnRetirarProducto";
            btnRetirarProducto.Size = new Size(75, 23);
            btnRetirarProducto.TabIndex = 6;
            btnRetirarProducto.Text = "Retirar";
            btnRetirarProducto.UseVisualStyleBackColor = true;
            btnRetirarProducto.Click += btnRetirarProducto_Click;
            // 
            // listBoxProductos
            // 
            listBoxProductos.FormattingEnabled = true;
            listBoxProductos.ItemHeight = 15;
            listBoxProductos.Location = new Point(342, 38);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(285, 199);
            listBoxProductos.TabIndex = 7;
            listBoxProductos.SelectedIndexChanged += listBoxProductos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 37);
            label1.TabIndex = 8;
            label1.Text = "Ejercicio 1 - Tienda";
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBoxProductos);
            Controls.Add(btnRetirarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtRetirar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblRetirados);
            Controls.Add(lblDisponibles);
            Name = "Ejercicio1";
            Text = "Ejercicio1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDisponibles;
        private Label lblRetirados;
        private Label label3;
        private Label label4;
        private TextBox txtRetirar;
        private Button btnAgregarProducto;
        private Button btnRetirarProducto;
        private ListBox listBoxProductos;
        private Label label1;
    }
}