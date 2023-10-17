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
    public partial class Ejercicio5 : Form
    {
        private Dictionary<char, List<string>> palabrasPorLetra = new Dictionary<char, List<string>>();
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnAgregarPalabra_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();
            if (!string.IsNullOrEmpty(palabra))
            {
                char primeraLetra = palabra[0];

                // Agrega la palabra a la lista de todas las palabras
                lstTodasLasPalabras.Items.Add(palabra);

                if (!palabrasPorLetra.ContainsKey(primeraLetra))
                {
                    palabrasPorLetra[primeraLetra] = new List<string>();
                }

                palabrasPorLetra[primeraLetra].Add(palabra);
                ActualizarListaPalabrasPorLetra();
                txtPalabra.Clear();
            }
        }

        private void ActualizarListaPalabrasPorLetra()
        {
            lstPalabrasPorLetra.Items.Clear();
            foreach (var par in palabrasPorLetra)
            {
                lstPalabrasPorLetra.Items.Add($"Lista {par.Key}: {string.Join(", ", par.Value)}");
            }
        }


        private void ActualizarListaPalabras()
        {
            lstPalabrasPorLetra.Items.Clear();
            foreach (var par in palabrasPorLetra)
            {
                lstPalabrasPorLetra.Items.Add($"Lista {par.Key}: {string.Join(", ", par.Value)}");
            }
        }

        private void txtPalabra_Enter(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();
            if (!string.IsNullOrEmpty(palabra))
            {
                char primeraLetra = palabra[0];

                lstTodasLasPalabras.Items.Add(palabra);

                if (!palabrasPorLetra.ContainsKey(primeraLetra))
                {
                    palabrasPorLetra[primeraLetra] = new List<string>();
                }

                palabrasPorLetra[primeraLetra].Add(palabra);
                ActualizarListaPalabrasPorLetra();
                txtPalabra.Clear();
            }
        }
    }
}
