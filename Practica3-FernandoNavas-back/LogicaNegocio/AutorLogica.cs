using Data;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    internal class AutorLogica
    {
        public List<autor> Listado()
        {
            List<autor> a = new List<autor>();
            Autor_Datos autor_datos = new Autor_Datos();
            // List<Pais_Datos> lista = new List<Pais_Datos>();
            return a = autor_datos.Listado();
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
