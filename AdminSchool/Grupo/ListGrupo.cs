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
        }

        private void ListGrupo_Load(object sender, EventArgs e)
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
    }
}
