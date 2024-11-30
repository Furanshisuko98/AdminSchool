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

namespace AdminSchool.Profesores
{
    public partial class NuevoProf : Form
    {
        AdminschoolEntities db = new AdminschoolEntities();
        string ruta = "";

        public NuevoProf()
        {
            InitializeComponent();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            profesor profesor = new profesor();
            profesor.IdEscuela = 1;
            profesor.Nombre = txtNombre.Text;
            profesor.ApellidoPaterno = txtPaterno.Text;
            profesor.ApellidoMaterno = txtMaterno.Text;
            profesor.FechaNacimiento = dtpNacimiento.Value;
            profesor.Genero = tcbGenero.Text;
            profesor.Edad = Convert.ToInt32(txtEdad.Text);
            profesor.Dirección = txtDirrecion.Text;
            profesor.NumeroEmpleado = txtNoDodecente.Text;
            profesor.Teléfono = txtTelefono.Text;
            profesor.Correo = txtCorreo.Text;
            profesor.Foto = Path.GetFileName(ruta);
            db.profesor.Add(profesor);
            db.SaveChanges();
            new Funciones.ImgUpdate(ruta).GuardarImg();
            MessageBox.Show("Profesor registrado satisfactoriamente");


        }
    }
}
