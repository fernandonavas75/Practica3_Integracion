using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Autor_Datos : IDatos<autor>
    {
        BibliotecaEntities contextoBd;
        public Autor_Datos() { 
            contextoBd = new BibliotecaEntities();
        }
        public bool Actualizar(autor item)
        {
            autor _autor =Buscar(item.idAutor);
            if (_autor == null) { 
                _autor.idAutor = item.idAutor;
                _autor.nombre = item.nombre;
                _autor.sexo= item.sexo;
                _autor.idPais = item.idPais;
                contextoBd.SaveChanges();
                return true;
            }else return false;
            // throw new NotImplementedException();
        }

        public autor Buscar(int id)
        {
            return contextoBd.autor.Where(p => p.idAutor == id).SingleOrDefault();
            // throw new NotImplementedException();
        }

        public bool Delete(autor item)
        {
            autor _autor = Buscar(item.idAutor);
            if (_autor != null)
            {
                contextoBd.autor.Remove(item);
                contextoBd.SaveChanges();
                return true;
            }
            else return false;
            // throw new NotImplementedException();
        }

        public bool Insertar(autor item)
        {
            try
            {
                contextoBd.autor.Add(item);
                contextoBd.SaveChanges();
                return true;
            }
            catch (Exception ex) { 
                return false;
            }
           // throw new NotImplementedException();
        }

        public List<autor> Listado()
        {
            return contextoBd.autor.ToList();
            // throw new NotImplementedException();
        }
    }
}
