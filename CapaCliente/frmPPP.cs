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
    public partial class frmPPP : Form
    {
        public frmPPP()
        {
            InitializeComponent();
        }
        CapaNegocio.PPP ppp1 = new CapaNegocio.PPP();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string direccion = txtDireccion.Text;
            string empresa = txtEmpresa.Text;
            string supervisor = txtSupervisor.Text;
            DateTime fecha = dtFecha.Value;
            string codigo = txtCodigo.Text;
            string carrera = txtCarrera.Text;
            string alumnos = txtAlumnos.Text;
            int creditos = int.Parse(txtCreditos.Text);

            ppp1.Direccion = direccion ;
            ppp1.Empresa = empresa;
            ppp1.Supervisor = supervisor;
            ppp1.Fecha = fecha;
            ppp1.Codigo = codigo;
            ppp1.Carrera = carrera;
            ppp1.Alumnos = alumnos;
            ppp1.Creditos = creditos;

            MessageBox.Show("Se han registrado correctamente los datos de PPP 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string direccion = ppp1.Direccion;
            string empresa = ppp1.Empresa;
            string supervisor = ppp1.Supervisor;
            DateTime fecha = ppp1.Fecha;
            string codigo = ppp1.Codigo;
            string carrera = ppp1.Carrera;
            string alumnos = ppp1.Alumnos;
            int creditos = ppp1.Creditos;

            MessageBox.Show(" Direccion: " + direccion + " Empresa:" + empresa + " Supervisor: " + supervisor + " Fecha: " + fecha + " Codigo: " + codigo + " Carrera : " + carrera + " Alumnos : " + alumnos + " Creditos" + creditos); 
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Trabajar());
        }

        private void btnExperiencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Experiencia());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Enseñar());
        }
    }
}
