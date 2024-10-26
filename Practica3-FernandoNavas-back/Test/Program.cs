using Data;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Pais_Datos p = new Pais_Datos();
            List<Pais> listado = p.Listado();
            Pais temp = new Pais();
           // temp.nombre = "Estados Unidos";
           // temp.codigo = "1";
           // p.Insertar(temp);
            foreach (Pais pais in listado) { 
                Console.WriteLine(pais.idPais+" "+pais.nombre+" "+pais.codigo);
            }
            Console.ReadKey();
            Console.WriteLine("Ciudad bucar con codigo 593");
            p.Buscar(593);
            Console.ReadKey();
            */
           // PaisLogica pl = new LogicaNegocio.PaisLogica();
            List<Pais> listadoPais = new List<Pais>();
           //  listadoPais = pl.Listado();
            foreach (var item in listadoPais) { 
                 Console.WriteLine(item.nombre+ " " + item.codigo);
            }
            Console.ReadKey();
        }
    }
}
