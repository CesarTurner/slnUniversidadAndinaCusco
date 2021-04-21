using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class Notas
    {
        private string codigo;
        private string apellidos;
        private string nombres;
        private string curso;
        private string aporte;
        private int calificacion;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
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
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public string Aporte
        {
            get { return aporte; }
            set { aporte = value; }
        }
        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        public string Calificar()
        {
            return "No se ha implementado el metodo calificar";
        }
        public string Aprobar()
        {
            return "No se ha implementado el metodo Aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el metodo Desaprobar";
        }
        public string Verificar()
        {
            return "No se ha implementado el metodo verificar";
        }
    }
}
