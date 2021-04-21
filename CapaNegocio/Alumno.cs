using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        // Private (-) Public (+) Protected (#)
        // C# no se dice nada al ambito es privado por defecto
        // Atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimiento;
        // Propiedades
        //getter leer un atributo (Get)
        // setter escribir un atributo (Set)
        public string Apellidos
        {
            get { return apellidos; } // Lectura del atributo
            set { apellidos = value; } // Escritura del atributo
        }
        public string Nombre
        {
            get { return nombres; } // Lectura del atributo
            set { nombres = value; } // Escritura del atributo
        }
        public int Edad
        {
            get { return edad; } // Lectura del atributo
            set { edad = value; } // Escritura del atributo
        }
        public string LugarNacimiento
        {
            get { return this.lugarNacimiento; } // ambos son iguales
            set { this.lugarNacimiento = value; } //recomendable del estilo
        }

        //Declarar metodos u operaciones
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string AprobarExamen()
        {
            return "No se ha implementado el metodo AprobarExamen";
        }
        public string PresentarTarea()
        {
            return "No se ha implementado el metodo presentar tarea";
        }
    }
}
