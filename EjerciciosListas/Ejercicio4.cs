using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosListas//
{
    public partial class Ejercicio4 : Form
    {
        private List<Producto> listaProductos = new List<Producto>();

        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProducto.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresa un nombre de producto válido.");
                return;
            }

            if (int.TryParse(txtCantidadProducto.Text, out int cantidad))
            {
                if (double.TryParse(txtPrecioProducto.Text, out double precio))
                {
                    Producto nuevoProducto = new Producto(nombre, cantidad, precio);
                    listaProductos.Add(nuevoProducto);
                    ActualizarListaProductos();
                    CalcularCostoTotal();
                }
                else
                {
                    MessageBox.Show("Ingresa un precio válido.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa una cantidad válida.");
            }

            txtNombreProducto.Clear();
            txtCantidadProducto.Clear();
            txtPrecioProducto.Clear();
        }

        private void CalcularCostoTotal()
        {
            double costoTotal = listaProductos.Sum(p => p.Precio * p.Cantidad);
            lblCostoTotal.Text = "Costo Total de Compra: $" + costoTotal.ToString("F2");
        }



        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string claveProducto = Microsoft.VisualBasic.Interaction.InputBox("Ingresa la clave o nombre del producto a eliminar:", "Eliminar Producto", "");

            if (!string.IsNullOrWhiteSpace(claveProducto))
            {
                Producto productoAEliminar = listaProductos.FirstOrDefault(p => p.Nombre.Equals(claveProducto, StringComparison.OrdinalIgnoreCase));
                if (productoAEliminar != null)
                {
                    listaProductos.Remove(productoAEliminar);
                    ActualizarListaProductos();
                    CalcularCostoTotal();
                }
                else
                {
                    MessageBox.Show("El producto no se encontró en la lista.");
                }
            }
        }


        private void ActualizarListaProductos()
        {
            lstProductos.Items.Clear();
            foreach (var producto in listaProductos.OrderBy(p => p.Nombre))
            {
                // Calcula el precio total por producto
                double precioTotalPorProducto = producto.Precio * producto.Cantidad;

                // Formatea el texto para mostrar tanto el precio unitario como el precio total
                string itemText = $"{producto.Nombre} - Cantidad: {producto.Cantidad} - Precio Unitario: ${producto.Precio:F2} - Precio Total: ${precioTotalPorProducto:F2}";

                lstProductos.Items.Add(itemText);
            }
        }




        private void btnVerClaves_Click(object sender, EventArgs e)
        {
            // Crear una ventana secundaria para mostrar las claves
            Form ventanaClaves = new Form();
            ventanaClaves.Text = "Claves de Productos";

            // Crear un control ListBox para mostrar las claves
            ListBox lstClaves = new ListBox();
            lstClaves.Dock = DockStyle.Fill;

            // Agregar las claves de los productos a la lista
            foreach (var producto in listaProductos)
            {
                lstClaves.Items.Add(producto.Nombre);
            }

            // Agregar el control ListBox a la ventana secundaria
            ventanaClaves.Controls.Add(lstClaves);

            // Mostrar la ventana secundaria
            ventanaClaves.ShowDialog();
        }


    }
}
