using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ArchivoTextoPersona : ICrud<Persona>
    {
        private string fileName = "Persona.txt";
        public string Actualizar(Persona personaEditada)
        {
            // Crear un string con los datos de la persona editada
            string nuevaLinea = personaEditada.ToString();

            // Crear un archivo temporal para almacenar los datos actualizados
            string tempFile = Path.GetTempFileName();

            // Abrir el archivo original en modo de lectura y el archivo temporal en modo de escritura
            using (StreamReader reader = new StreamReader(fileName))
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Dividir la línea en partes utilizando el delimitador ';' y verificar la identificación
                    string[] parts = line.Split(';');
                    if (parts.Length > 0 && parts[0] == personaEditada.Identificacion)
                    {
                        // Si la identificación coincide, escribir la nueva línea en el archivo temporal
                        writer.WriteLine(nuevaLinea);
                        continue; // Saltar al siguiente ciclo de lectura sin escribir la línea original
                    }

                    // Si la identificación no coincide, escribir la línea original en el archivo temporal
                    writer.WriteLine(line);
                }
            }

            // Reemplazar el archivo original con el archivo temporal
            File.Delete(fileName);
            File.Move(tempFile, fileName);

            // Devolver un mensaje indicando que la persona ha sido actualizada
            return "La persona ha sido actualizada con éxito.";
        }
        public string Agregar(Persona persona)
        {
            try
            {
                // Verifica si el archivo existe y lo crea si no existe
                if (!File.Exists(fileName))
                {
                    File.Create(fileName).Close(); // Crea el archivo y lo cierra inmediatamente
                }

                // Abre el archivo en modo de lectura para verificar si la persona ya existe
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Divide la línea en partes utilizando el delimitador ';' y verifica la identificación
                        string[] parts = line.Split(';');
                        if (parts.Length > 0 && parts[0] == persona.Identificacion.ToString())
                        {
                            return "La persona ya existe en el archivo.";
                        }
                    }
                }

                // Abre el archivo en modo de escritura (Append)
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    // Escribe la información de la persona en una nueva línea en el archivo
                    writer.WriteLine(persona.ToString());
                }
                ReorganizarArchivo();
                return "Persona agregada exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar la persona: {ex.Message}";
            }
        }

        public Persona Consultar(string id)
        {
            Persona persona = null;
            try
            {
                // Verifica si el archivo existe
                if (File.Exists(fileName))
                {
                    // Abre el archivo en modo de lectura para verificar si la persona existe
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Divide la línea en partes utilizando el delimitador ';' y verifica la identificación
                            string[] parts = line.Split(';');
                            if (parts.Length > 0 && parts[0] == id.ToString())
                            {
                                // Se encontró la persona, crea una instancia de Persona con la información y devuélvela
                                persona = new Persona
                                {
                                    Identificacion = parts[0],
                                    Nombre = parts[1],
                                    Edad = int.Parse(parts[2]),
                                    Sexo = parts[3],
                                    Pulsacion = decimal.Parse(parts[4]),
                                };
                                return persona;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la lectura del archivo
                // Aquí puedes registrar el error o manejarlo de alguna otra manera según tus necesidades
                Console.WriteLine("Error al consultar la persona: " + ex.Message);
            }

            // Si no se encuentra la persona o ocurre algún error, devuelve null
            return persona;
        }

        public string Eliminar(string id)
        {
            try
            {
                // Crear un archivo temporal para almacenar los datos sin la persona a eliminar
                string tempFile = Path.GetTempFileName();

                // Abrir el archivo original en modo de lectura y el archivo temporal en modo de escritura
                using (StreamReader reader = new StreamReader(fileName))
                using (StreamWriter writer = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Divide la línea en partes utilizando el delimitador ';' y verifica la identificación
                        string[] parts = line.Split(';');
                        if (parts.Length > 0 && parts[0] == id)
                        {
                            // Si la identificación coincide con la persona a eliminar, no escribimos esa línea en el archivo temporal
                            continue;
                        }

                        // Si la identificación no coincide, escribimos la línea original en el archivo temporal
                        writer.WriteLine(line);
                    }
                }

                // Reemplazar el archivo original con el archivo temporal
                File.Delete(fileName);
                File.Move(tempFile, fileName);

                // Devolver un mensaje indicando que la persona ha sido eliminada
                return "La persona ha sido eliminada con éxito.";
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la eliminación del archivo
                // Aquí puedes registrar el error o manejarlo de alguna otra manera según tus necesidades
                return $"Error al eliminar la persona: {ex.Message}";
            }
        }
        public List<Persona> ObtenerLista()
        {
            List<Persona> listaPersonas = new List<Persona>();
            try
            {
                // Verifica si el archivo existe
                if (File.Exists(fileName))
                {
                    // Abre el archivo en modo de lectura para leer todas las personas
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Divide la línea en partes utilizando el delimitador ';' y crea una instancia de Persona
                            string[] parts = line.Split(';');
                            if (parts.Length >= 5)
                            {
                                Persona persona = new Persona
                                {
                                    Identificacion = parts[0],
                                    Nombre = parts[1],
                                    Edad = int.Parse(parts[2]),
                                    Sexo = parts[3],
                                    Pulsacion = decimal.Parse(parts[4]),
                                };
                                // Agrega la persona a la lista
                                listaPersonas.Add(persona);
                            }
                        }

                        // Mueve el cursor al final del archivo para estar listo para la escritura
                        reader.BaseStream.Seek(0, SeekOrigin.End);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la lectura del archivo
                // Aquí puedes registrar el error o manejarlo de alguna otra manera según tus necesidades
                Console.WriteLine("Error al obtener la lista de personas: " + ex.Message);
            }

            // Devuelve la lista de personas, puede contener elementos o estar vacía si ocurre algún error
            return listaPersonas;
        }

        public void ReorganizarArchivo()
        {
            try
            {
                // Crear un archivo temporal para almacenar los datos sin líneas en blanco
                string tempFile = Path.GetTempFileName();

                // Abrir el archivo original en modo de lectura y el archivo temporal en modo de escritura
                using (StreamReader reader = new StreamReader(fileName))
                using (StreamWriter writer = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Verificar si la línea no está en blanco
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            // Escribir la línea en el archivo temporal si no está en blanco
                            writer.WriteLine(line);
                        }
                    }

                    // Mueve el cursor al final del archivo para estar listo para la escritura
                    reader.BaseStream.Seek(0, SeekOrigin.End);

                }

                // Reemplazar el archivo original con el archivo temporal
                File.Delete(fileName);
                File.Move(tempFile, fileName);

            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la reorganización del archivo
                // Aquí puedes registrar el error o manejarlo de alguna otra manera según tus necesidades
                Console.WriteLine("Error al reorganizar el archivo: " + ex.Message);
            }
        }

    }
}
