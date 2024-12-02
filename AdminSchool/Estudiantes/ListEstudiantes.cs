using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSchool.Estudiantes
{
    public partial class ListEstudiantes : Form
    {
        AdminschoolEntities db = new AdminschoolEntities();
        public ListEstudiantes()
        {
            

            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new Estudiantes.NuevoEstudiante().ShowDialog();
            Consultar();
        }

        private void ListEstudiantes_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            dgvAlumnos.DataSource = db.estudiante.Select(x => new
            {
                Matricula = x.Matricula,
                Nombre = x.Nombre,
                Apellidos = x.ApellidoPaterno + " " + x.ApellidoMaterno,
                Grupo = x.grupo.Nombre,
                Tutor = x.NombreTutor,
                Teléfono = x.Teléfono
            }).ToList();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            string Matricula = dgvAlumnos["Matricula", dgvAlumnos.CurrentRow.Index].Value.ToString();
            new DetalleEstudiante(Matricula).ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvAlumnos.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Deseas Continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int fila = dgvAlumnos.CurrentRow.Index;
                    string Matricula = dgvAlumnos["Matricula", fila].Value.ToString();

                    estudiante estudiante = db.estudiante.Find(Matricula);

                    new Funciones.ImgUpdate(estudiante.Foto).DeleteImg();

                    db.estudiante.Remove(estudiante);
                    db.SaveChanges();
                    Consultar();
                }
            }
        }
    }
}
