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
using System.Data.Entity;


namespace AdminSchool.Estudiantes
{
    public partial class DetalleEstudiante : Form
    {
        string ruta = "";
        string Matricula;

        AdminschoolEntities db = new AdminschoolEntities();
        estudiante estudiante = new estudiante();

        public DetalleEstudiante(string _matricula)
        {
            Matricula = _matricula; 
            InitializeComponent();

            var grupo = db.grupo.ToList();

            tcbGrupo.DataSource = grupo;
            tcbGrupo.DisplayMember = "Nombre";
            tcbGrupo.ValueMember = "Id";
        }

        private void DetalleEstudiante_Load(object sender, EventArgs e)
        {
            estudiante = db.estudiante.Where(x => x.Matricula == Matricula).FirstOrDefault();

            if (estudiante != null)
            {
                txtNombre.Text = estudiante.Nombre;
                txtPaterno.Text = estudiante.ApellidoPaterno;
                txtMaterno.Text = estudiante.ApellidoMaterno;
                dtpNacimiento.Value = estudiante.FechaNacimiento.Value;
                tcbGenero.Text = estudiante.Genero;
                txtEdad.Text = estudiante.Edad.ToString();
                txtDirrecion.Text = estudiante.Dirección;
                tcbGrupo.Text = estudiante.grupo.Nombre;
                txtMatricula.Text = estudiante.Matricula;
                txtTutor.Text = estudiante.NombreTutor;
                txtTelefono.Text = estudiante.Teléfono;
                txtCorreo.Text = estudiante.Correo;
                pbFoto.ImageLocation = "Imágenes/" + estudiante.Foto;
            }

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Archivo de imagen | *.jpg; *.png";

            if (img.ShowDialog() == DialogResult.OK)
            {
                ruta = img.FileName;
                pbFoto.ImageLocation = ruta;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new Funciones.ImgUpdate(ruta).GuardarImg();

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

            db.Entry(estudiante).State = EntityState.Modified;
            db.SaveChanges();
            
            MessageBox.Show("Estudiante modificado satisfactoriamente", "Moficación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
