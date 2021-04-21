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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        CapaNegocio.Docente profesor1 = new CapaNegocio.Docente();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer los Datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombre.Text;
            string dni = txtDni.Text;
            string lugarNacimiento = txtLugarNacimiento.Text;
            DateTime fechaNacimiento = dtfechaNacimiento.Value;
            string profesion = txtProfesion.Text;

            profesor1.Apellidos = apellidos;
            profesor1.Nombre = nombres;
            profesor1.Dni = dni;
            profesor1.LugarNacimiento = lugarNacimiento;
            profesor1.FechaNacimiento = fechaNacimiento;
            profesor1.Profesion = profesion;

            MessageBox.Show("Se han registrado correctamente los datos de Alumno 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar datos almacenados en el objeto 1
            string apellidos = profesor1.Apellidos;
            string nombres = profesor1.Nombre;
            string dni = profesor1.Dni;
            string lugarNacimiento = profesor1.LugarNacimiento;
            DateTime fechaNacimiento = profesor1.FechaNacimiento;
            string profesion = profesor1.Profesion;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres + " Dni: " + dni + " Lugar de Nacimiento: " + lugarNacimiento + " Fecha de Nacimiento: " + fechaNacimiento + " Profesion: " + profesion);
        }

        private void txtNombres_Load(object sender, EventArgs e)
        {

        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Enseñar
            MessageBox.Show(profesor1.Enseñar());
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Matricular
            MessageBox.Show(profesor1.Matricular());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Aprobar
            MessageBox.Show(profesor1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Desaprobar
            MessageBox.Show(profesor1.Desaprobar());
        }
    }
}
