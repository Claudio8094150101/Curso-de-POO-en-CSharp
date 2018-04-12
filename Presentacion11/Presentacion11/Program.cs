using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion11
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMostrarArrayList Muestra = new clsMostrarArrayList();
            Muestra.CapturaDatos();
            Muestra.ImprimeDatos();
            //clsMuestraHashTable MuestraH;
            //MuestraH = new clsMuestraHashTable();
            //MuestraH.AgregarDatos();
            //MuestraH.ImprimirDatos();
            //MuestraH.EliminarElemento("C001");
            //MuestraH.ImprimirDatos();
        }
    }
}
