using ProyectoEstructura.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoEstructura
{
    public partial class Arbol : Form
    {
        private ArbolBinario inventarioArbol;

        public Arbol()
        {
            InitializeComponent();
            inventarioArbol = new ArbolBinario();
        }

        #region Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén completos y que los campos numéricos sean válidos
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MostrarMensaje("Complete todos los campos.");
                return;
            }

            // Si la validación es exitosa, proceder con la inserción del producto
            string nombre = txtNombreProducto.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            double precio = double.Parse(txtPrecio.Text);

            Producto nuevoProducto = new Producto(nombre, cantidad, precio);
            inventarioArbol.Insertar(nuevoProducto);

            if (nuevoProducto != null)
            {
                MostrarMensaje($"Producto agregado:\n{nuevoProducto}");
            }
            else
            {
                MostrarMensaje("Producto no agregado.");
            }

            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén completos y que los campos numéricos sean válidos
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MostrarMensaje("Por favor, complete todos los campos.");
                return;
            }

            // Si la validación es exitosa, proceder con la actualización del producto
            string nombre = txtNombreProducto.Text;
            int nuevaCantidad = int.Parse(txtCantidad.Text);
            double nuevoPrecio = double.Parse(txtPrecio.Text);

            bool actualizado = inventarioArbol.ActualizarProducto(nombre, nuevaCantidad, nuevoPrecio);

            if (actualizado)
            {
                MostrarMensaje("Los atributos de cantidad y precio del producto han sido actualizados exitosamente.");
            }
            else
            {
                MostrarMensaje("Producto no encontrado. No se puede actualizar la cantidad.");
            }

            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén completos y que los campos numéricos sean válidos
            if (string.IsNullOrWhiteSpace(txtBuscarProducto.Text))
            {
                MostrarMensaje("Digite el nombre del producto a buscar.");
                return;
            }
            string nombre = txtBuscarProducto.Text;
            Producto productoEncontrado = inventarioArbol.Buscar(nombre);

            if (productoEncontrado != null)
            {
                MostrarMensaje($"Producto encontrado:\n{productoEncontrado}");
            }
            else
            {
                MostrarMensaje("Producto no encontrado.");
            }
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén completos y que los campos numéricos sean válidos
            if (string.IsNullOrWhiteSpace(txtBuscarProducto.Text))
            {
                MostrarMensaje("Digite el nombre del producto a buscar.");
                return;
            }

            string nombre = txtBuscarProducto.Text;

            bool eliminado = inventarioArbol.Eliminar(nombre);

            if (eliminado)
            {
                MostrarMensaje("Producto eliminado exitosamente.");
            }
            else
            {
                MostrarMensaje("Producto no encontrado. No se puede eliminar.");
            }
            LimpiarCampos();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Verificar si hay elementos en el inventario antes de imprimir
            if (inventarioArbol.EstaVacio())
            {
                MostrarMensaje("El inventario está vacío. No hay nada para imprimir.");
                return;
            }
            // Imprimir el inventario
            string inventario = inventarioArbol.ImprimirInOrden();
            MostrarMensaje("Inventario:\n" + inventario);
            txtImpresion.Text = "Inventario:\n" + inventario;
        }
        #endregion

        #region Métodos
        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtBuscarProducto.Clear();
            txtImpresion.Clear();
        }
        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Eventos que valida el txtPrecio para que solo contenga números
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es una tecla de control (por ejemplo, Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Eventos que valida el txtCantidad para que solo contenga números
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, se ignora la pulsación
                e.Handled = true;
            }
        }
        //Eventos que valida el txtImpresion para que no se digite o ingrese un dato
        private void txtImpresion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion
    }
}