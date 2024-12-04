using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSchool.Usuario
{
    public partial class ListUsuario : Form
    {
        AdminschoolEntities db = new AdminschoolEntities();

        public ListUsuario()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new Usuario.NuevoUsuario().ShowDialog();
        }

        private void ListUsuario_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            dgvUsuarios.DataSource = db.usuario.Select(x => new
            {
                Nombre = x.Nombre,
                Apodo = x.Apodo,
                Privilegios = x.Privilegio
            }).ToList();
        }
    }
}
