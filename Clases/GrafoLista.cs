using System.Collections.Generic;
using System.Text;

namespace ProyectoEstructura.Clases
{
    internal class GrafoLista
    {
        public int Vertice;  //Número de vértices
        public List<int>[] listaAdyacencia;  //Lista de adyacencia

        public GrafoLista(int vertices)
        {
            Vertice = vertices;
            listaAdyacencia = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                listaAdyacencia[i] = new List<int>();
            }
        }

        // Método para agregar una arista dirigida al grafo
        public void AgregarArista(int origen, int destino)
        {
            listaAdyacencia[origen].Add(destino);

        }

        public void EliminarVertice(int vertice)
        {

            for (int i = 0; i < Vertice; i++)
            {
                listaAdyacencia[i].Remove(vertice);
            }

            // Reducir la cantidad de vértices
            Vertice--;
        }

        public bool EsVerticeFuente(int vertice)
        {
            foreach (var lista in listaAdyacencia)
            {
                if (lista.Contains(vertice))
                {
                    return false; // El vértice no es fuente, ya que tiene al menos una arista entrante.
                }
            }

            return true; // El vértice es fuente, ya que no tiene aristas entrantes.
        }

        public bool EsVerticeValido(int vertice)
        {
            return vertice >= 0 && vertice < Vertice;
        }
    }
}
