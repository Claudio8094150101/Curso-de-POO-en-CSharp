using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion8
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesConContacto cliente = new clsClientesConContacto(0, "Marcos Hernandez",
                                                                        "001",
                                                                        "HEHM",
                                                                        1, "Marcos Hernandez",
                                                                        "23333", "", "mx@yahoo.com",
                                                                        "Av TIGRE", "119", "",
                                                                        "La Cueva del Jaguar",
                                                                        "Tuxtla Gutierrez",
                                                                        "Chiapas", "29096");

            intSalidas Impresion;
            string cadena = Console.ReadLine();
            if (cadena == "1")
                Impresion = new clsImpresion();
            else
                Impresion = new clsArchivos();
            try
            {
                Impresion.ImprimeCliente(cliente);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ocurrio un error: " + e.Message);
                Console.ReadKey();
            }
        }
    }
}
