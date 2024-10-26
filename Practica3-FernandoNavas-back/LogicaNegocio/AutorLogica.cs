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
        public List<autor> ListaAutorXPais()
        {
            List<autor> autores = new List<autor>();
            Autor_Datos a_datos = new Autor_Datos();
            autores=a_datos.Listado();
            return autores.Where(a=>a.idPais==1).ToList();
        } 
        /*
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
        */
    }
}
