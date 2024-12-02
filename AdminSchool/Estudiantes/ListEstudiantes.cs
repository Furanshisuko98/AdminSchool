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
                Id = x.Id,
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
            int Id = Convert.ToInt32(dgvAlumnos["Id", dgvAlumnos.CurrentRow.Index].Value);
            new DetalleEstudiante(Id).ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvAlumnos.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Deseas Continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int fila = dgvAlumnos.CurrentRow.Index;
                    int id = Convert.ToInt32(dgvAlumnos["id", fila].Value);

                    estudiante estudiante = db.estudiante.Find(id);

                    new Funciones.ImgUpdate(estudiante.Foto).DeleteImg();

                    db.estudiante.Remove(estudiante);
                    db.SaveChanges();
                    Consultar();
                }
            }
        }
    }
}
