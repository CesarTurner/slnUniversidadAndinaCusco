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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }
        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer los Datos del formulario
            string codigo = txtCodigo.Text;
            DateTime horario = dtHorario.Value;
            string plan = txtPlan.Text;
            string aula = txtAula.Text;
            string nombreAsignatura = txtNombreAsignatura.Text;

            asignatura1.Codigo = codigo;
            asignatura1.Horario = horario;
            asignatura1.Plan = plan;
            asignatura1.Aula = aula;
            asignatura1.NombreAsignatura = nombreAsignatura;
            MessageBox.Show("Se han registrado correctamente los datos de Asignatura1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar datos almacenados en el objeto 1
            string codigo = asignatura1.Codigo;
            DateTime horario = asignatura1.Horario;
            string plan = asignatura1.Plan;
            string aula = asignatura1.Aula;
            string nombresAsignatura = asignatura1.NombreAsignatura;

            MessageBox.Show("Codigo " + codigo + " Horario " + horario + " plan: " + plan + " aula: " + aula + "Nombre de la Asignatura" + nombresAsignatura);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
            {
                MessageBox.Show(asignatura1.Enseñar());
            }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Estudiar());
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Investigar());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Aprender());
        }
    }
    
}
