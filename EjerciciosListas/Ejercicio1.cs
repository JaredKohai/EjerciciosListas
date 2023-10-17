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
    public partial class Ejercicio1 : Form
    {
        private List<Producto> productos = new List<Producto>();
        private int productosDisponibles = 0;
        private int productosRetirados = 0;
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnRetirarProducto_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRetirar.Text, out int cantidadARetirar))
            {
                if (cantidadARetirar > 0)
                {
                    int indice = listBoxProductos.SelectedIndex;

                    if (indice >= 0 && indice < productos.Count)
                    {
                        Producto productoSeleccionado = productos[indice];

                        if (productoSeleccionado.Cantidad >= cantidadARetirar)
                        {
                            productoSeleccionado.Cantidad -= cantidadARetirar;
                            productosRetirados += cantidadARetirar;
                            lblRetirados.Text = "Retirados: " + productosRetirados;

                            // Actualiza el ListBox
                            listBoxProductos.Items[indice] = productoSeleccionado.ToString(); // Actualiza el elemento en el ListBox

                            if (productoSeleccionado.Cantidad == 0)
                            {
                                productos.RemoveAt(indice);
                                listBoxProductos.Items.RemoveAt(indice);
                                productosDisponibles--;
                                lblDisponibles.Text = "Disponibles: " + productosDisponibles;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay suficientes productos para retirar.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad a retirar debe ser mayor que cero.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa una cantidad válida.");
            }

            txtRetirar.Clear();
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cantidad = random.Next(1, 11);
            double precio = random.Next(1, 101) / 10.0;

            string nombreProducto = "Producto" + (productos.Count + 1);
            Producto nuevoProducto = new Producto(nombreProducto, cantidad, precio);
            productos.Add(nuevoProducto);

            listBoxProductos.Items.Add(nuevoProducto); // Agrega el objeto Producto directamente
            productosDisponibles++;
            lblDisponibles.Text = "Disponibles: " + productosDisponibles;
        }


        private void txtRetirar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRetirados_Click(object sender, EventArgs e)
        {

        }

        private void lblDisponibles_Click(object sender, EventArgs e)
        {

        }

        private void listBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
