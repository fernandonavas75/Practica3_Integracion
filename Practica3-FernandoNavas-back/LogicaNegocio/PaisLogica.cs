using Data;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    internal class PaisLogica
    {
        public List<Pais> Listado()
        {
            List<Pais> p = new List<Pais>();
            // List<Pais_Datos> lista = new List<Pais_Datos>();
            Pais_Datos pais_Datos = new Pais_Datos();
            return p = pais_Datos.Listado();
        }
        public void insertar(Pais p)
        {
            // Todo el codigo que mi logica de ndegocio requiera
            Pais_Datos pais_datos = new Pais_Datos();
            if (pais_datos.Insertar(p) == true)
            {
                Console.WriteLine("Exito");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
