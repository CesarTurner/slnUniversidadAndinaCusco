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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }
        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string instrumentos = txtInstrumentos.Text;
            DateTime agenda = dtAgenda.Value;
            string asignatura = txtAsignatura.Text;
            DateTime horario = dtHorario.Value;
            string aforo = txtAforo.Text;

            laboratorio1.Instrumentos = instrumentos;
            laboratorio1.Agenda = agenda;
            laboratorio1.Asignatura = asignatura;
            laboratorio1.Horario = horario;
            laboratorio1.Aforo = aforo;

            MessageBox.Show("Se han registrado correctamente los datos de Laboratorio 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string instrumentos = laboratorio1.Instrumentos;
            DateTime agenda = laboratorio1.Agenda;
            string asignatura = laboratorio1.Asignatura;
            DateTime horario = laboratorio1.Horario;
            string aforo = laboratorio1.Aforo;

            MessageBox.Show("Instrumentos : " + instrumentos + "Agenda:" + agenda + "Asignatura" + asignatura + " Horario" + horario + " Aforo :" + aforo);

        }

        private void btnExperimentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Experimentar());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Enseñar());
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Investigar());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Ordenar());
        }
    }
}
