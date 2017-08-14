using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Mundo
{
    /// <summary>
    /// Clase principal del mundo
    /// </summary>
    public class Sistema
    {

        /// <summary>
        /// Diccionario que usa como llave el codigo del cliente, y como valor usa una lista con los codigos de los productos que el cliente de la llave compró
        /// </summary>
        private Dictionary<int, List<int>> diccionario;

        /// <summary>
        /// Diccionario que usa como llave el codigo del producto, y como valor usa el nombre del producto respectivo
        /// </summary>
        private Dictionary<int, string> productos;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Sistema()
        {
            // Se inicializa el diccionario de productos con tamanio 1852
            productos = new Dictionary<int, string>(1852);
            diccionario = new Dictionary<int, List<int>>();
            List<int> lista = new List<int>();
            List<List<int>> listaDeListas = new List<List<int>>();
            lista.Add(29);
            lista.Add(28);
            lista.Add(27);
            lista.Add(26);
            diccionario.Add(1, lista);
            lista.Clear();
            lista.Add(29);
            lista.Add(28);
            lista.Add(27);
            diccionario.Add(2, lista);
            lista.Clear();
            lista.Add(29);
            lista.Add(28);
            lista.Add(27);
            diccionario.Add(3, lista);

        }
        

        /// <summary>
        /// Agrega a su respectivo diccionario, el codigo del cliente como llave y la lista de codigos de productos como valor
        /// </summary>
        /// <param name="codigoProducto"> Codigo del cliente </param>
        /// <param name="listaCodigosClientes"> Lista con los codigos de los productos que compró el cliente </param>
        public void agregarADiccionario(int codigoProducto, List<int> listaCodigosClientes)
        {
            diccionario.Add(codigoProducto, listaCodigosClientes);

        }


        /// <summary>
        /// Agrega un producto a su respectivo diccionario
        /// </summary>
        /// <param name="codigoProducto"> Codigo del producto </param>
        /// <param name="nombrePRoducto"> Nombre del producto </param>
        public void agregarProducto(int codigoProducto, string nombreProducto)
        {
            productos.Add(codigoProducto, nombreProducto);
        }


        /// <summary>
        /// Obtiene la lista de productos que compró el cliente del codigo pasado por parametro
        /// </summary>
        /// <param name="codCliente"> codigo del cliente </param>
        /// <returns> Devuelve la lista de productos complados por el cliente del codigo< /returns>
        public List<int> ObtenerListaProductos(int codCliente)
        {
            return diccionario[codCliente];

        }

        /// <summary>
        /// Obtiene una lista de productos comunes entre 2 listas de productos
        /// </summary>
        /// <param name="lista1"> lista con codigos de productos #1 </param>
        /// <param name="lista2"> lista con con codigos de productos #2 </param>
        /// <returns> Devuelve una lista de productos comunes entre lista1 y lista2 </returns>
        public List<int> productosComunesEntre(List<int> lista1, List<int> lista2)
        {
            return lista1.Intersect(lista2).ToList<int>();

        }


        /// <summary>
        /// Obtiene una lista de productos de la lista2 que no se encuentran en la lista1
        /// </summary>
        /// <param name="lista1"> lista de codigos de productos #1 </param>
        /// <param name="lista2"> lista de codigos de productos #2 </param>
        /// <returns></returns>
        public List<int> productosARecomendar(List<int> lista1, List<int> lista2)
        {
            return lista1.Except(lista2).ToList<int>();
        }


        /// <summary>
        /// Obtiene el nombre del producto del codigo pasado por parametro
        /// </summary>
        /// <param name="codigoProducto"> codigo del producto </param>
        /// <returns> devuelve el nombre del producto identificado por el codigo del parametro</returns>
        public string obtenerNombrePRoducto(int codigoProducto)
        {
            return productos[codigoProducto];
        }

        public List<int> clientesSimilares(int codCliente)
        {
            List<int> similares = new List<int>();
            List<int> pro = ObtenerListaProductos(codCliente);
            List<int> temporal = new List<int>();
            int num = pro.Count;
            int contador = 0;
            int temp = 0;


            foreach (KeyValuePair<int, List<int>> list in diccionario)
            {
                foreach (int item in list.Value)
                {
                    temp = item;
                    for (int i = 0; i < num; i++)
                    {


                        if (item == pro[i])
                        {
                            contador++;
                        }
                    }


                }
                if (contador >= 3)
                {
                    similares.Add(list.Key);
                    contador = 0;
                }

            }
            return similares;

        }

        // Get y set


        /// <summary>
        /// get y set del diccionario de compras
        /// </summary>
        public Dictionary<int, List<int>> Diccionario { get { return diccionario; } set { diccionario = value; } }

        /// <summary>
        /// get y set del diccionario de productos
        /// </summary>
        public Dictionary<int, string> Productos { get { return productos; } set { productos = value; }}
    }
}

