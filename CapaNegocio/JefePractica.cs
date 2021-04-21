using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        private string apellidos;
        private string nombres;
        private string codigo;
        private string dni;
        private DateTime fechanacimiento;
        private string semestre;
        private string carrera;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechanacimiento; }
            set { fechanacimiento = value; }
        }
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public string Controlar()
        {
            return "No se ha implementado el metodo controlar";
        }
        public string Calificar()
        {
            return "No se ha implementado el metodo calificar";
        }
        public string Ayudar()
        {
            return "No se ha implementado el metodo ayudar";
        }
        public string Verificar()
        {
            return "No se ha implementado el metodo Verificar";
        }

    }
}
