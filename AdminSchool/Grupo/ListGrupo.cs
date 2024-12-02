using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSchool.Grupo
{
    public partial class ListGrupo : Form
    {
        AdminschoolEntities db = new AdminschoolEntities();
        public ListGrupo()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new Grupo.NuevoGrupo().ShowDialog();
            Consultar();
        }

        private void ListGrupo_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            dgvGrupos.DataSource = db.grupo.Select(
               x => new
               {
                   Id = x.Id,
                   Nombre = x.Nombre,
                   Grado = x.Grado,
                   Nivel = x.Nivel,
                   Asesor = x.profesor.Nombre

               }).ToList();
        }


        private void btnDetalles_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvGrupos["Id", dgvGrupos.CurrentRow.Index].Value);
            new DetallesGrupo(Id).ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Deseas Continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int fila = dgvGrupos.CurrentRow.Index;
                    int id = Convert.ToInt32(dgvGrupos["id", fila].Value);

                    grupo grupo = db.grupo.Find(id);
                    db.grupo.Remove(grupo);
                    db.SaveChanges();
                    Consultar();
                }
            }
        }
    }
}
