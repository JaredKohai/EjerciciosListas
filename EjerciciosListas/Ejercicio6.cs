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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }
        private void btnInvertir_Click(object sender, EventArgs e)
        {
            // Obtener la palabra ingresada por el usuario
            string palabra = txtPalabra.Text;

            // Invertir la palabra
            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            string palabraInvertida = new string(caracteres);

            // Mostrar la palabra invertida en el Label
            lblPalabraInvertida.Text = "Palabra Invertida: " + palabraInvertida;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
