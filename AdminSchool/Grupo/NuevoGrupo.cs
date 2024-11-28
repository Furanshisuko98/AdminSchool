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
    public partial class NuevoGrupo : Form
    {
        AdminschoolEntities db = new AdminschoolEntities();
        public NuevoGrupo()
        {
            InitializeComponent();
            var profesor = db.profesor.ToList();
            tcbIdProfesor.DataSource = profesor;
            tcbIdProfesor.DisplayMember = "Nombre";
            tcbIdProfesor.ValueMember = "Id";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            grupo grupo = new grupo();
            grupo.Nombre = txtNombre.Text;
            grupo.Grado = Convert.ToInt32(txtGrado.Text);
            grupo.Nivel = tcbNivel.Text;
            grupo.IdAsesor = Convert.ToInt32(tcbIdProfesor.SelectedValue);
            db.grupo.Add(grupo);
            db.SaveChanges();
            MessageBox.Show("Grupo registrado satisfactoriamente");

        }
    }
}
