using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSchool.Profesores
{
    public partial class ListProf : Form
    {
        AdminschoolEntities db = new AdminschoolEntities();

        public ListProf()
        {
            InitializeComponent();
            Consulta();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new Profesores.NuevoProf().ShowDialog();
            Consulta();
        }

        private void Consulta()
        {
            dgvProfesor.DataSource = db.profesor.Select(
                x => new
                {
                    Id = x.Id,
                    Numero = x.NumeroEmpleado,
                    Apellidos = x.ApellidoPaterno + " " + x.ApellidoMaterno,
                    Nombre = x.Nombre,
                    Genero = x.Genero,
                    Edad = x.Edad + " Años",
                    Teléfono = x.Teléfono,
                    Correo = x.Correo
                }).ToList();
            ;
        }

        private void ListProf_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProfesor.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Deseas Continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int fila = dgvProfesor.CurrentRow.Index;
                    int Id = Convert.ToInt32(dgvProfesor["Id", fila].Value);

                    profesor profesor = db.profesor.Find(Id);
                    new Funciones.ImgUpdate(profesor.Foto).DeleteImg();

                    db.profesor.Remove(profesor);
                    db.SaveChanges();
                    Consulta();
                }
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvProfesor["Id", dgvProfesor.CurrentRow.Index].Value);
            new DetallesProfesor(Id).ShowDialog();
        }
    }
}
