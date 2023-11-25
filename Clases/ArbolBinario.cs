using System;

namespace ProyectoEstructura.Clases
{
    public class Producto
    {
        // Propiedades para representar un producto
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        // Constructor para inicializar un producto con valores iniciales
        public Producto(string nombre, int cantidad, double precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
        // Método para obtener una representación de cadena del producto
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Cantidad: {Cantidad}, Precio: {Precio:C}";
        }
    }

    public class NodoArbol
    {
        // Nodo del árbol con un producto y referencias a nodos izquierdo y derecho
        public Producto Producto { get; set; }
        public NodoArbol Izquierdo { get; set; }
        public NodoArbol Derecho { get; set; }

        // Constructor para inicializar un nodo con un producto y sin hijos
        public NodoArbol(Producto producto)
        {
            Producto = producto;
            Izquierdo = null;
            Derecho = null;
        }
    }

    public class ArbolBinario
    {
        // Raíz del árbol binario
        private NodoArbol raiz;
        // Método público para insertar un producto en el árbol
        public void Insertar(Producto producto)
        {
            raiz = InsertarRec(raiz, producto);
        }
        // Método privado y recursivo para insertar un producto en el árbol
        private NodoArbol InsertarRec(NodoArbol raiz, Producto producto)
        {
            //Caso base si la raíz es nula se crea un nuevo nodo con el producto dado
            if (raiz == null)
            {
                return new NodoArbol(producto);
            }

            int comparacion = String.Compare(producto.Nombre, raiz.Producto.Nombre);

            if (comparacion < 0)
            {
                raiz.Izquierdo = InsertarRec(raiz.Izquierdo, producto);
            }
            else if (comparacion > 0)
            {
                raiz.Derecho = InsertarRec(raiz.Derecho, producto);
            }

            return raiz;
        }
        // Método público para buscar un producto por nombre
        public Producto Buscar(string nombre)
        {
            return BuscarRec(raiz, nombre);
        }

        // Método privado y recursivo para buscar un producto por nombre
        private Producto BuscarRec(NodoArbol raiz, string nombre)
        {
            //Caso base si la raíz es nula o el nombre coincide con el nombre del producto en la raíz devuelve el producto de la raíz o null si la raíz es nula
            if (raiz == null || String.Compare(nombre, raiz.Producto.Nombre) == 0)
            {
                return raiz?.Producto;
            }

            int comparacion = String.Compare(nombre, raiz.Producto.Nombre);

            if (comparacion < 0) // Si el nombre buscado es menor que el nombre del producto en la raíz la búsqueda continúa en el subárbol izquierdo de manera recursiva
            {
                return BuscarRec(raiz.Izquierdo, nombre);
            }
            else // Si el nombre buscado es mayor la búsqueda continúa en el subárbol derecho de manera recursiva
            {
                return BuscarRec(raiz.Derecho, nombre);
            }
        }

        // Método público para actualizar la cantidad y precio de un producto segun su nombre
        public bool ActualizarProducto(string nombre, int nuevaCantidad, double nuevoPrecio)
        {
            NodoArbol nodo = BuscarNodo(raiz, nombre);

            if (nodo != null)
            {
                nodo.Producto.Cantidad = nuevaCantidad;
                nodo.Producto.Precio = nuevoPrecio;
                return true;
            }

            return false;
        }
        // Método público para actualizar la cantidad y precio de un producto 
        private NodoArbol BuscarNodo(NodoArbol raiz, string nombre)
        {
            if (raiz == null || String.Compare(nombre, raiz.Producto.Nombre) == 0)
            {
                return raiz;
            }

            int comparacion = String.Compare(nombre, raiz.Producto.Nombre);

            if (comparacion < 0) 
            {
                return BuscarNodo(raiz.Izquierdo, nombre); 
            }
            else 
            {
                return BuscarNodo(raiz.Derecho, nombre); 
            }
        }
        // Método público para eliminar un producto por nombre
        public bool Eliminar(string nombre)
        {
            bool eliminado = false;
            raiz = EliminarRec(raiz, nombre, ref eliminado);
            return eliminado;
        }
        // Método privado y recursivo para eliminar un producto por nombre
        private NodoArbol EliminarRec(NodoArbol raiz, string nombre, ref bool eliminado)
        {
            // Caso base si la raíz es nula no hay nada que eliminar y devuelve null
            if (raiz == null)
            {
                return null;
            }

            int comparacion = String.Compare(nombre, raiz.Producto.Nombre);

            if (comparacion < 0) // Si el nombre buscado es menor que el nombre del producto en la raíz la eliminación continúa en el subárbol izquierdo de manera recursiva
            {
                raiz.Izquierdo = EliminarRec(raiz.Izquierdo, nombre, ref eliminado);
            }
            else if (comparacion > 0) // Si el nombre buscado es mayor la eliminación continúa en el subárbol derecho de manera recursiva
            {
                raiz.Derecho = EliminarRec(raiz.Derecho, nombre, ref eliminado);
            }
            else
            {
                // Si se encuentra el nodo con el nombre del producto a eliminar
                eliminado = true;

                if (raiz.Izquierdo == null)
                {
                    return raiz.Derecho;
                }
                else if (raiz.Derecho == null)
                {
                    return raiz.Izquierdo;
                }
                // Si el nodo tiene ambos subárboles, se reemplaza con el nodo mínimo del subárbol derecho
                raiz.Producto = EncontrarMinimo(raiz.Derecho).Producto;
                raiz.Derecho = EliminarRec(raiz.Derecho, raiz.Producto.Nombre, ref eliminado);
            }
            // Se devuelve la raíz actualizada del subárbol
            return raiz;
        }
        // Método privado para encontrar el nodo con el valor mínimo en un subárbol
        private NodoArbol EncontrarMinimo(NodoArbol raiz)
        {
            while (raiz.Izquierdo != null)
            {
                raiz = raiz.Izquierdo;
            }
            return raiz;
        }
        // Método público para imprimir el árbol en orden
        public string ImprimirInOrden()
        {
            return ImprimirInOrdenRec(raiz);
        }
        // Método privado y recursivo para imprimir el árbol en orden
        private string ImprimirInOrdenRec(NodoArbol raiz)
        {
            // Caso base
            if (raiz == null)
            {
                return "";
            }

            string izquierdo = ImprimirInOrdenRec(raiz.Izquierdo);
            string actual = $"\n {raiz.Producto} \n";
            string derecho = ImprimirInOrdenRec(raiz.Derecho);

            return izquierdo + actual + derecho;
        }
        // Método para saber si el inventario está vacio
        public bool EstaVacio()
        {
            return raiz == null;
        }
    }
}
