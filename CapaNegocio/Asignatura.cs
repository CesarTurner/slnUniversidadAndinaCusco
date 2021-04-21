using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        private string codigo;
        private DateTime horario;
        private string plan;
        private string aula;
        private string nombreAsignatura;
        public string Codigo
        {
            get { return codigo; } // Lectura del atributo
            set { codigo = value; } // Escritura del atributo
        }
        public DateTime Horario
        {
            get { return horario; } // Lectura del atributo
            set { horario= value; } // Escritura del atributo
        }
        public string Plan
        {
            get { return plan; } // Lectura del atributo
            set {plan = value; } // Escritura del atributo
        }
        public string Aula
        {
            get { return aula; } // Lectura del atributo
            set { aula = value; } // Escritura del atributo
        }
        public string NombreAsignatura
        {
            get { return nombreAsignatura; } // Lectura del atributo
            set { nombreAsignatura = value; } // Escritura del atributo
        }
        //Declarar metodos u operaciones
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
        public string Investigar()
        {
            return "No se ha implementado el metodo investigar";
        }
        public string Aprender()
        {
            return "No se ha implementado el metodo aprender";
        }
    }
}
