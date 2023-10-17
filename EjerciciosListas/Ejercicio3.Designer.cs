namespace EjerciciosListas
{
    partial class Ejercicio3
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
            lstAprobados = new ListBox();
            lstReprobados = new ListBox();
            btnAgregarAlumno = new Button();
            lblNombre = new Label();
            lblCalificacion = new Label();
            lblAprobados = new Label();
            lblReprobados = new Label();
            txtNombre = new TextBox();
            txtCalificacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lstAprobados
            // 
            lstAprobados.FormattingEnabled = true;
            lstAprobados.ItemHeight = 15;
            lstAprobados.Location = new Point(191, 160);
            lstAprobados.Name = "lstAprobados";
            lstAprobados.Size = new Size(120, 94);
            lstAprobados.TabIndex = 0;
            // 
            // lstReprobados
            // 
            lstReprobados.FormattingEnabled = true;
            lstReprobados.ItemHeight = 15;
            lstReprobados.Location = new Point(398, 160);
            lstReprobados.Name = "lstReprobados";
            lstReprobados.Size = new Size(120, 94);
            lstReprobados.TabIndex = 1;
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.ForeColor = Color.Green;
            btnAgregarAlumno.Location = new Point(316, 274);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(75, 23);
            btnAgregarAlumno.TabIndex = 2;
            btnAgregarAlumno.Text = "Agregar Alumno";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(211, 347);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(116, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre del Alumno";
            // 
            // lblCalificacion
            // 
            lblCalificacion.AutoSize = true;
            lblCalificacion.Location = new Point(398, 347);
            lblCalificacion.Name = "lblCalificacion";
            lblCalificacion.Size = new Size(69, 15);
            lblCalificacion.TabIndex = 4;
            lblCalificacion.Text = "Calificación";
            // 
            // lblAprobados
            // 
            lblAprobados.AutoSize = true;
            lblAprobados.Location = new Point(211, 130);
            lblAprobados.Name = "lblAprobados";
            lblAprobados.Size = new Size(65, 15);
            lblAprobados.TabIndex = 5;
            lblAprobados.Text = "Aprobados";
            // 
            // lblReprobados
            // 
            lblReprobados.AutoSize = true;
            lblReprobados.Location = new Point(419, 130);
            lblReprobados.Name = "lblReprobados";
            lblReprobados.Size = new Size(70, 15);
            lblReprobados.TabIndex = 6;
            lblReprobados.Text = "Reprobados";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(211, 321);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(386, 321);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(100, 23);
            txtCalificacion.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 347);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(211, 63);
            label2.Name = "label2";
            label2.Size = new Size(293, 37);
            label2.TabIndex = 10;
            label2.Text = "Ejercicio 3 - Aprobados";
            // 
            // Ejercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCalificacion);
            Controls.Add(txtNombre);
            Controls.Add(lblReprobados);
            Controls.Add(lblAprobados);
            Controls.Add(lblCalificacion);
            Controls.Add(lblNombre);
            Controls.Add(btnAgregarAlumno);
            Controls.Add(lstReprobados);
            Controls.Add(lstAprobados);
            Name = "Ejercicio3";
            Text = "Ejercicio3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAprobados;
        private ListBox lstReprobados;
        private Button btnAgregarAlumno;
        private Label lblNombre;
        private Label lblCalificacion;
        private Label lblAprobados;
        private Label lblReprobados;
        private TextBox txtNombre;
        private TextBox txtCalificacion;
        private Label label1;
        private Label label2;
    }
}