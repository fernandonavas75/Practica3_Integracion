using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    //Interface
    public interface IDatos<T>
    {
        List<T> Listado();
        bool Insertar(T item );
        bool Actualizar(T item);
        bool Delete(T item);
        T Buscar(int id);
    }
}
