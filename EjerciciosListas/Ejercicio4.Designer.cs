namespace EjerciciosListas
{
    partial class Ejercicio4
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
            txtNombreProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPrecioProducto = new TextBox();
            btnAgregarProducto = new Button();
            txtClaveEliminarProducto = new TextBox();
            btnEliminarProducto = new Button();
            lstProductos = new ListBox();
            lblCostoTotal = new Label();
            txtCantidadProducto = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(183, 122);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 127);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 182);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio: ";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(183, 182);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(100, 23);
            txtPrecioProducto.TabIndex = 3;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = SystemColors.Control;
            btnAgregarProducto.ForeColor = Color.Green;
            btnAgregarProducto.Location = new Point(128, 223);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(75, 23);
            btnAgregarProducto.TabIndex = 4;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtClaveEliminarProducto
            // 
            txtClaveEliminarProducto.Location = new Point(699, 3);
            txtClaveEliminarProducto.Name = "txtClaveEliminarProducto";
            txtClaveEliminarProducto.Size = new Size(100, 23);
            txtClaveEliminarProducto.TabIndex = 5;
            txtClaveEliminarProducto.Text = "JaredB";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = SystemColors.Control;
            btnEliminarProducto.ForeColor = Color.Red;
            btnEliminarProducto.Location = new Point(380, 282);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(75, 23);
            btnEliminarProducto.TabIndex = 6;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(380, 107);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(408, 139);
            lstProductos.TabIndex = 7;
            // 
            // lblCostoTotal
            // 
            lblCostoTotal.AutoSize = true;
            lblCostoTotal.Location = new Point(380, 249);
            lblCostoTotal.Name = "lblCostoTotal";
            lblCostoTotal.Size = new Size(65, 15);
            lblCostoTotal.TabIndex = 8;
            lblCostoTotal.Text = "Costo total";
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Location = new Point(183, 153);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(100, 23);
            txtCantidadProducto.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 156);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(247, 21);
            label4.Name = "label4";
            label4.Size = new Size(345, 37);
            label4.TabIndex = 11;
            label4.Text = "Ordenamiento por Alfabeto";
            // 
            // Ejercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCantidadProducto);
            Controls.Add(lblCostoTotal);
            Controls.Add(lstProductos);
            Controls.Add(btnEliminarProducto);
            Controls.Add(txtClaveEliminarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombreProducto);
            Name = "Ejercicio4";
            Text = "Ejercicio4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private Label label1;
        private Label label2;
        private TextBox txtPrecioProducto;
        private Button btnAgregarProducto;
        private TextBox txtClaveEliminarProducto;
        private Button btnEliminarProducto;
        private ListBox lstProductos;
        private Label lblCostoTotal;
        private TextBox txtCantidadProducto;
        private Label label3;
        private Label label4;
    }
}