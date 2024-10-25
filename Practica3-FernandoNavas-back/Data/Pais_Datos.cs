using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Pais_Datos : IDatos<Pais>
    {
        BibliotecaEntities contextoBd;
        public Pais_Datos() // constructor
        {
            contextoBd = new BibliotecaEntities(); // inicializnod el cotexto
        }
        public bool Actualizar(Pais item)
        {
            Pais _pais= Buscar(item.idPais);
            if(_pais==null)
            {
                _pais.nombre= item.nombre;
                _pais.codigo= item.codigo;
                contextoBd.SaveChanges();
                return true;
            }else return false;
            throw new NotImplementedException();
        }

        public Pais Buscar(int id)
        {
            return contextoBd.Pais.Where(p=>p.idPais==id).SingleOrDefault();
            // throw new NotImplementedException();
        }

        public bool Delete(Pais item)
        {
            // por codificar hablar con luchito//
            throw new NotImplementedException();
        }

        public bool Insertar(Pais item)
        {
            try
            {
                contextoBd.Pais.Add(item);
                contextoBd.SaveChanges(); // Se va a guardar en a tabla de la base de datos
                return true;

            }
            catch (Exception ex) { 
                return false;
                throw new NotImplementedException();
            }
            
        }

        public List<Pais> Listado()
        {
            return contextoBd.Pais.ToList(); 
            throw new NotImplementedException();
        }
    }
}
