using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        private string instrumentos;
        private DateTime agenda;
        private string asignatura;
        private DateTime horario;
        private string aforo;
        public string Instrumentos
        {
            get { return instrumentos; } // Lectura del atributo
            set { instrumentos = value; } // Escritura del atributo
        }
        public DateTime Agenda
        {
            get { return agenda ; } // Lectura del atributo
            set { agenda = value; } // Escritura del atributo
        }
        public string Asignatura
        {
            get { return asignatura ; } // Lectura del atributo
            set { asignatura = value; } // Escritura del atributo
        }
        public DateTime Horario
        {
            get { return horario; } // Lectura del atributo
            set { horario= value; } // Escritura del atributo
        }

        public string Aforo
        {
            get { return aforo; } // Lectura del atributo
            set { aforo = value; } // Escritura del atributo
        }
        //Declarar metodos u operaciones
        public string Experimentar()
        {
            return "No se ha implementado el metodo experimentar";
        }
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string Investigar()
        {
            return "No se ha implementado el metodo Investigar";
        }
        public string Ordenar()
        {
            return "No se ha implementado el metodo ordenar";
        }
    }
}
