using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion13
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch reloj = new Stopwatch();
            ctrPresentacion13 contrl = new ctrPresentacion13();
            contrl.LlenarLista();
            Impresion.ImprimeProductos(contrl.Productos);
            Impresion.EsperaTecla();
            List<clsProductosInventario> lista = new List<clsProductosInventario>();
            reloj.Start();
            foreach (var item in contrl.Productos)
            {
                if (item.Existencias > 0 && item.PrecioPublico < 12)
                    lista.Add(item);
            }
            reloj.Stop();
            Impresion.ImprimeProductos(lista);
            Impresion.ImprimeTiempo(reloj.ElapsedTicks);
            Impresion.EsperaTecla();
            List<clsProductosInventario> lista2 = new List<clsProductosInventario>();
            reloj.Reset();
            reloj.Start();
            lista2.AddRange(from o in contrl.Productos where o.Existencias > 0 && o.PrecioPublico < 12 select o);
            reloj.Stop();
            Impresion.ImprimeProductos(lista2);
            Impresion.ImprimeTiempo(reloj.ElapsedTicks);
            Impresion.EsperaTecla();
            var lista3 = (from o in contrl.Productos group o by o.Costo into g select new { g.Key, Total = g.Count() }).ToList();
            foreach (var item in lista3)
            {
                Console.WriteLine("Total: {0} Costo: {1}", item.Total, item.Key);
            }
            Impresion.EsperaTecla();
        }
    }
}
