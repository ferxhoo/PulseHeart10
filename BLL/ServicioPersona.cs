using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioPersona
    {
        private ICrud<Persona> data;
        public ServicioPersona()
        {
            data = new ArchivoTextoPersona();
        }
        public string AgregarPersona(Persona persona)
        {
            return data.Agregar(persona);
        }
        public List<Persona> ObtenerListaPersona()
        {
            return data.ObtenerLista();
        }
        public string EliminarPersona(string identificacion)
        {
            return data.Eliminar(identificacion);
        }
        public Persona ConsultarPersona(string identificacion)
        {
            return data.Consultar(identificacion);
        }

        public string ActualizarPersona(string id, Persona personaEditada)
        {
            string identificacion = personaEditada.Identificacion;
            if (id != identificacion)
            {
                return "No puedes cambiar la identificacion";
            }
            else
            {
                return data.Actualizar(personaEditada);
            }
        }
    }
}
