using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        private string direccion;
        private string empresa;
        private string supervisor;
        private DateTime fecha;
        private string codigo;
        private string carrera;
        private string alumnos;
        private int creditos;

        public string Direccion
        {
            get { return direccion; } 
            set { direccion = value; } 
        }
        public string Empresa
        {
            get { return empresa; } 
            set { empresa = value; } 
        }
        public string Supervisor
        {
            get { return supervisor; } 
            set { supervisor = value; } 
        }
        public DateTime Fecha
        {
            get { return fecha; } 
            set { fecha = value; } 
        }
        public string Codigo       
        {
            get { return codigo; } 
            set { codigo = value; }
        }
        public string Carrera
        {
            get { return carrera; } 
            set { carrera = value; } 
        }
        public string Alumnos
        {
            get { return alumnos; } 
            set { alumnos = value; } 
        }
        public int Creditos
        {
            get { return creditos ; } 
            set { creditos = value; }
        }

        
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string Experiencia()
        {
            return "No se ha implementado el metodo Experiencia";
        }
        public string Enseñar()
        {
            return "No se ha implementado el metodo Enseñar";
        }

    }
}
