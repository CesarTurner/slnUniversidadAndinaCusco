using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        private string apellidos;
        private string nombres;
        private string codigo;
        private string profesion;
        private string dni;
        private DateTime fechanacimiento;
        private string experiencia;

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
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
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
        public string Experiencia
        {
            get { return experiencia; }
            set { experiencia = value; }
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string TomarDecisiones()
        {
            return "No se ha implementado el metodo tomar decisiones";
        }
        public string Promover()
        {
            return "No se ha implementado el metodo promover";
        }
        public string Controlar()
        {
            return "No se ha implementado el metodo controlar";
        }

    }

}
