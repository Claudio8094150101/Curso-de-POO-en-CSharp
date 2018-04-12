using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion11
{
    public class clsMostrarArrayList
    {
        ArrayList Lista;

        public clsMostrarArrayList()
        {
            Lista = new ArrayList();
        }

        public void CapturaDatos()
        {
            string cadena;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Dame el dato {0}: ", i + 1);
                cadena = Console.ReadLine();
                Lista.Add(cadena);
            }
            Lista.Add(1);
            Lista.Add(2);
        }

        public void ImprimeDatos()
        {
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
