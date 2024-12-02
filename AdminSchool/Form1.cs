using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AdminSchool
{
    public partial class Main : Form
    {
        AdminschoolEntities db = new AdminschoolEntities();
        public Main()
        {
            InitializeComponent();
        }

        private void nuevoEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Estudiantes.NuevoEstudiante().ShowDialog();
        }

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Estudiantes.ListEstudiantes().ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Profesores.ListProf().ShowDialog();
        }

        private void nuevoProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Profesores.NuevoProf().ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("~/AnyDesk.exe");
        } 

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Grupo.NuevoGrupo().ShowDialog();
        }

        private void listaDeGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Grupo.ListGrupo().ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Usuario.ListUsuario().ShowDialog();
        }

        private void datosDeLaEscuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Empresa.DatosEmpresa().ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var escuela = db.escuela.Where(x => x.Id == 1).FirstOrDefault();
            pbEscuela.ImageLocation = "Imágenes/" + escuela.Logo;
        }
    }
}
