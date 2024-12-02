using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace AdminSchool.Grupo
{
    public partial class DetallesGrupo : Form
    {
        int Id;

        AdminschoolEntities db = new AdminschoolEntities();
        grupo grupo = new grupo();

        public DetallesGrupo(int _Id)
        {
            Id = _Id;
            InitializeComponent();

            var profesor = db.profesor.ToList();

            tcbIdProfesor.DataSource = profesor;
            tcbIdProfesor.DisplayMember = "Nombre";
            tcbIdProfesor.ValueMember = "Id";
        }

        private void DetallesGrupo_Load(object sender, EventArgs e)
        {
            grupo = db.grupo.Where(x => x.Id == Id).FirstOrDefault();

            txtNombre.Text = grupo.Nombre;
            txtGrado.Text = grupo.Grado.ToString();
            tcbNivel.Text = grupo.Nivel;
            tcbIdProfesor.Text = grupo.profesor.Nombre;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            grupo.Nombre = txtNombre.Text;
            grupo.Grado = Convert.ToInt32(txtGrado.Text);
            grupo.Nivel = tcbNivel.Text;
            grupo.IdAsesor = Convert.ToInt32(tcbIdProfesor.SelectedValue);

            db.Entry(grupo).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
