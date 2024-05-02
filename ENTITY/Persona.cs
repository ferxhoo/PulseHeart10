using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }    
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public decimal Pulsacion { get; set; }
        public Persona() { }
        public Persona(string identificacion, string nombre, int edad, string sexo, decimal pulsaciones)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Pulsacion = pulsaciones;
        }
        public decimal CalcularPulsacion(string sexo, int edad) 
        {
            decimal Pulsacion = 0;
            switch (sexo)
            {
                case "Masculino":
                    Pulsacion = (210 - edad) / 10;
                    break;
                case "Femenino":
                    Pulsacion = (220 - edad) / 10;
                    break;
            }
            return Pulsacion;
        }
        public override string ToString()
        {
            return $"{Identificacion};{Nombre};{Edad};{Sexo};{Pulsacion}";
        }
    }
}
