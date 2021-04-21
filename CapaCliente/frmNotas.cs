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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        CapaNegocio.Notas notas1 = new CapaNegocio.Notas();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string curso = txtCurso.Text;
            string aporte = txtAporte.Text;
            int calificacion = int.Parse(txtCalificacion.Text);

            notas1.Codigo = codigo;
            notas1.Apellidos = apellidos;
            notas1.Nombres = nombres;
            notas1.Curso = curso;
            notas1.Aporte = aporte;
            notas1.Calificacion = calificacion;
            MessageBox.Show("Se han registrado correctamente los datos de Notas 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string codigo = notas1.Codigo;
            string apellidos = notas1.Apellidos;
            string nombres = notas1.Nombres;
            string curso = notas1.Curso;
            string aporte = notas1.Aporte;
            int calificacion = notas1.Calificacion;

            MessageBox.Show(" Codigo :" + codigo + " Apellidos : " + apellidos + " Nombres: " + nombres + " Curso: " + curso + " Aporte: " + aporte + " Calificacion: " + calificacion);

        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Calificar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Aprobar());
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Verificar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Desaprobar());
        }
    }
}
