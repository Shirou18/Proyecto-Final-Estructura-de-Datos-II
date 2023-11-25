using ProyectoEstructura.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoEstructura
{
    public partial class Grafo : Form
    {
        private GrafoLista grafos;

        public Grafo()
        {
            InitializeComponent();
            grafos = null;
        }

        private void btnAgregarVertice_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén completos y que los campos numéricos sean válidos
            if (string.IsNullOrWhiteSpace(txtVertices.Text))
            {
                MostrarMensaje("Agregue la cantidad de vertices del grafo.");
                return;
            }

            int cantidadVertices = int.Parse(txtVertices.Text);

            // Crear el grafo solo si no existe
            if (grafos == null)
            {
                grafos = new GrafoLista(cantidadVertices);
                MostrarMensaje($"Grafo creado con {cantidadVertices} vértices.");
            }
            else
            {
                MostrarMensaje("El grafo ya ha sido creado.");
            }
        }

        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén completos y que los campos numéricos sean válidos
            if (string.IsNullOrWhiteSpace(txtOrigen.Text) || string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                MostrarMensaje("Ingrese origen y destino de la arista.");
                return;
            }

            int origen, destino;
            if (int.TryParse(txtOrigen.Text, out origen) && int.TryParse(txtDestino.Text, out destino))
            {
                if (grafos != null && grafos.EsVerticeValido(origen) && grafos.EsVerticeValido(destino))
                {
                    grafos.AgregarArista(origen, destino);
                    MostrarMensaje($"Arista agregada: {origen} -> {destino}");
                }
                else
                {
                    MostrarMensaje("Arista no válida. Uno o ambos vértices están fuera del rango.");
                }
            }
            else
            {
                MostrarMensaje("Ingrese valores numéricos válidos para origen y destino.");
            }

            txtOrigen.Clear();
            txtDestino.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (grafos != null)
            {
                Actualizar();
            }
            else
            {
                MostrarMensaje("Cree un grafo antes de imprimir.");
            }
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (grafos == null)
            {
                MostrarMensaje("Cree un grafo antes de realizar la comprobación.");
                return;
            }

            int verticeBuscado;
            if (int.TryParse(txtBuscarEliminarVertice.Text, out verticeBuscado))
            {
                if (grafos.EsVerticeValido(verticeBuscado))
                {
                    if (grafos.EsVerticeFuente(verticeBuscado))
                    {
                        MostrarMensaje("El vértice es fuente.");
                    }
                    else
                    {
                        MostrarMensaje("El vértice no es fuente.");
                    }
                }
                else
                {
                    MostrarMensaje("Ingrese un vértice válido para la comprobación.");
                }
            }
            else
            {
                MostrarMensaje("Ingrese un vértice válido para la comprobación.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grafos == null)
            {
                MostrarMensaje("Cree un grafo antes de intentar eliminar un vértice.");
                return;
            }

            int verticeEliminar;
            if (int.TryParse(txtBuscarEliminarVertice.Text, out verticeEliminar))
            {
                if (grafos.EsVerticeValido(verticeEliminar))
                {
                    grafos.EliminarVertice(verticeEliminar);
                    MostrarMensaje($"Vértice {verticeEliminar} eliminado.");
                }
                else
                {
                    MostrarMensaje("Ingrese un vértice válido para eliminar.");
                }
            }
            else
            {
                MostrarMensaje("Ingrese un vértice válido para eliminar.");
            }
        }


        #region Métodos
        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Actualizar()
        {
            txtImpresion.Clear();
            txtImpresion.AppendText("\nResultado del grafo ");
            for (int i = 0; i < grafos.Vertice; i++)
            {
                txtImpresion.AppendText($"Vertice {i}-->\n");
                foreach (var graf in grafos.listaAdyacencia[i])
                {
                    txtImpresion.AppendText($"{graf} \n");
                }
                txtImpresion.AppendText("\n");
            }
        }
        private void txtVertices_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es una tecla de control (por ejemplo, Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, se ignora la pulsación
                e.Handled = true;
            }
        }
        #endregion
    }
}
