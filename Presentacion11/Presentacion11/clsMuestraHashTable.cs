using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Presentacion11
{
    public class clsMuestraHashTable
    {
        Hashtable Tabla;

        public clsMuestraHashTable()
        {
            Tabla = new Hashtable();
        }

        public void AgregarDatos()
        {
            Tabla.Add("C001", "Producto 1");
            Tabla.Add("B123", "Producto 3");
            Tabla.Add("J452", "Producto 4");
            Tabla.Add("z099", "Producto 5");
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("Existen {0} elementos, dame la clave del producto:", Tabla.Count);
            string cadena = Console.ReadLine();
            if (Tabla[cadena] == null)
                Console.WriteLine("El elemento no existe");
            else
            {
                Console.WriteLine("El elemento encontrado es:");
                Console.WriteLine(Tabla[cadena]);
            }
            Console.ReadKey();
        }

        public void EliminarElemento(string key)
        {
            Tabla.Remove(key);
        }
    }
}
