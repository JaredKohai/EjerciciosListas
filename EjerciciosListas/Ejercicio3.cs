using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosListas
{
    public partial class Ejercicio3 : Form
    {
        private List<Alumno> alumnos = new List<Alumno>();
        public Ejercicio3()
        {
            InitializeComponent();
        }
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            // Obtener nombre y calificación del alumno
            string nombre = txtNombre.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingresa un nombre de alumno.");
                return;
            }

            if (double.TryParse(txtCalificacion.Text, out double calificacion))
            {
                // Crear un objeto Alumno
                Alumno nuevoAlumno = new Alumno(nombre, calificacion);
                alumnos.Add(nuevoAlumno);

                // Mostrar al alumno en la lista correspondiente
                if (calificacion >= 7)
                {
                    lstAprobados.Items.Add(nuevoAlumno);
                }
                else
                {
                    lstReprobados.Items.Add(nuevoAlumno);
                }

                // Limpiar las cajas de texto
                txtNombre.Clear();
                txtCalificacion.Clear();
            }
            else
            {
                MessageBox.Show("Ingresa una calificación válida.");
            }
        }
    }
}
