using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSchool.Estudiantes
{
    public partial class NuevoEstudiante : Form
    {
        AdminschoolEntities db = new AdminschoolEntities();
        string ruta = "";

        public NuevoEstudiante()
        {
            var grupo = db.grupo.ToList();
            InitializeComponent();
            tcbGrupo.DataSource = grupo;
            tcbGrupo.DisplayMember = "Nombre";
            tcbGrupo.ValueMember = "Id";
        }

        private void NuevoEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Archivo de imagen | *.jpg; *.png";
            if (img.ShowDialog() == DialogResult.OK)
            {
                ruta = img.FileName;
                pbFoto.ImageLocation = ruta;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new Funciones.ImgUpdate(ruta).GuardarImg();

            estudiante estudiante = new estudiante();
            estudiante.Nombre = txtNombre.Text;
            estudiante.ApellidoPaterno = txtPaterno.Text;
            estudiante.ApellidoMaterno = txtMaterno.Text;
            estudiante.FechaNacimiento = dtpNacimiento.Value;
            estudiante.Genero = tcbGenero.Text;
            estudiante.Edad = Convert.ToInt32(txtEdad.Text);
            estudiante.Dirección = txtDirrecion.Text;
            estudiante.IdGrupo = Convert.ToInt32(tcbGrupo.SelectedValue);
            estudiante.Matricula = txtMatricula.Text;
            estudiante.NombreTutor = txtTutor.Text;
            estudiante.Teléfono = txtTelefono.Text;
            estudiante.Correo = txtCorreo.Text;
            estudiante.Foto = Path.GetFileName(ruta);
            db.estudiante.Add(estudiante);
            db.SaveChanges();
            MessageBox.Show("Estudiante registrado satisfactoriamente", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
