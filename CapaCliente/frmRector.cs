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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string profesion = txtProfesion.Text;
            string dni = txtDni.Text;
            DateTime fechanacimiento = dtFechaNacimiento.Value;
            string experiencia = txtExperiencia.Text;

            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.Codigo = codigo;
            rector1.Profesion = profesion;
            rector1.Dni = dni;
            rector1.FechaNacimiento = fechanacimiento;
            rector1.Experiencia = experiencia;
            MessageBox.Show("Se han registrado correctamente los datos de Rector 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string codigo = rector1.Codigo;
            string apellidos = rector1.Apellidos;
            string nombres = rector1.Nombres;
            string profesion = rector1.Profesion;
            string dni = rector1.Dni;
            DateTime fechanacimiento = rector1.FechaNacimiento;
            string experiencia = rector1.Experiencia;

            MessageBox.Show("Apellidos : " + apellidos + " Nombres :" + nombres + " Codigo: " + codigo + " Profesion:" + profesion + " Dni: " + dni + " Fecha Nacimiento: " + fechanacimiento + " Experiencia: " + experiencia);

        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Trabajar());
        }

        private void btnTomarDecisiones_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.TomarDecisiones());
        }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Promover());
        }

        private void btnControlar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Controlar());
        }
    }
}
