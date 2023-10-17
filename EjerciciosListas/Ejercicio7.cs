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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Obtener la palabra ingresada por el usuario
            string palabra = txtPalabra.Text.ToLower(); // Convertir a minúsculas para evitar diferencias de mayúsculas y minúsculas
            string palabraInvertida = InvertirPalabra(palabra);

            // Verificar si la palabra es un palíndromo
            bool esPalindromo = palabra == palabraInvertida;

            // Mostrar el resultado en el Label
            lblResultado.Text = esPalindromo ? "Es un palíndromo" : "No es un palíndromo";
        }

        private string InvertirPalabra(string palabra)
        {
            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
