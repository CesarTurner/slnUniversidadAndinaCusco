using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        private string apellidos;
        private string nombres;
        private string dni;
        private string lugarNacimiento;
        private DateTime fechaNacimiento;
        private string profesion;

        // Propiedades
        public string Apellidos
        {
            get { return apellidos; } 
            set { apellidos = value; } 
        }
        public string Nombre
        {
            get { return nombres; } 
            set { nombres = value; }
        }
        public string Dni
        {
            get { return dni; } 
            set { dni = value; } 
        }
        public string LugarNacimiento
        {
            get { return lugarNacimiento; }
            set { lugarNacimiento = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; } 
        }
        public string Profesion
        {
            get { return profesion; } 
            set { profesion = value; } 
        }
        //Declarar metodos u operaciones
        public string Enseñar()
            {
                return "No se ha implementado el metodo Enseñar";
            }
        public string Matricular()
        {
            return "No se ha implementado el metodo Matricular";
        }
        public string Aprobar()
        {
            return "No se ha implementado el metodo Aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el metodo Desaprobar";
        }
    }
}
