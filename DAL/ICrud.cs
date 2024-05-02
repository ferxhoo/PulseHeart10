using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICrud<T> where T : class
    {
        string Agregar(T entidad);
        T Consultar(string id);
        List<T> ObtenerLista();
        string Actualizar(T entidad);
        string Eliminar(string id);
    }
}
