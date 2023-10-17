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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Limpiar las listas y el label
            lstPares.Items.Clear();
            lstImpares.Items.Clear();
            lblNumerosGenerados.Text = ""; // Limpiar el contenido del label

            // Generar números aleatorios y separarlos en pares e impares
            Random random = new Random();
            int cantidadNumeros = 10; // Puedes ajustar la cantidad de números a generar
            List<int> numeros = new List<int>();

            for (int i = 0; i < cantidadNumeros; i++)
            {
                int numero = random.Next(1, 101); // Genera números aleatorios entre 1 y 100
                numeros.Add(numero);

                if (numero % 2 == 0)
                {
                    // Número par
                    lstPares.Items.Add(numero);
                }
                else
                {
                    // Número impar
                    lstImpares.Items.Add(numero);
                }
            }

            // Construir una cadena con los números generados y mostrarla en el label
            lblNumerosGenerados.Text = "Números Generados: " + string.Join(", ", numeros);
        }

        private void lblNumerosGenerados_Click(object sender, EventArgs e)
        {

        }

        private void lstPares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
