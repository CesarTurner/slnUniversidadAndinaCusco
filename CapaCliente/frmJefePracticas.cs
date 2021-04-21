using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaCliente
{
    public partial class frmJefePracticas : Form
    {
        public frmJefePracticas()
        {
            InitializeComponent();
        }
        CapaNegocio.JefePractica jefepratica1 = new CapaNegocio.JefePractica();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string semestre = txtSemestre.Text;
            string dni = txtDni.Text;
            DateTime fechanacimiento = dtFechaNacimiento.Value;
            string carrera = txtCarrera.Text;

            jefepratica1.Apellidos = apellidos;
            jefepratica1.Nombres = nombres;
            jefepratica1.Codigo = codigo;
            jefepratica1.Dni = dni;
            jefepratica1.FechaNacimiento = fechanacimiento;
            jefepratica1.Semestre = semestre;
            jefepratica1.Carrera = carrera;

            MessageBox.Show("Se han registrado correctamente los datos de Jefe de Practica 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string codigo = jefepratica1.Codigo;
            string apellidos = jefepratica1.Apellidos;
            string nombres = jefepratica1.Nombres;
            string semestre = jefepratica1.Semestre;
            string dni = jefepratica1.Dni;
            DateTime fechanacimiento = jefepratica1.FechaNacimiento;
            string carrera = txtCarrera.Text;

            MessageBox.Show("Apellidos : " + apellidos + " Nombres :" + nombres + " Codigo: " + codigo + " Dni: " + dni + " Fecha Nacimiento: " + fechanacimiento + " Semestre: " + semestre + " Carrera:" + carrera);
        }

        private void btnAyudar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepratica1.Ayudar());
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepratica1.Verificar());
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepratica1.Calificar());
        }

        private void btnControlar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepratica1.Controlar());
        }
    }
}
