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

namespace AdminSchool.Profesores
{
    public partial class DetallesProfesor : Form
    {
        string ruta = "";
        string NoEmpleado;

        AdminschoolEntities db = new AdminschoolEntities();
        profesor profesor = new profesor();

        public DetallesProfesor(string _NoEmpleado)
        {
            NoEmpleado = _NoEmpleado;
            InitializeComponent();
        }

        private void DetallesProfesor_Load(object sender, EventArgs e)
        {
            profesor = db.profesor.Where(x => x.NumeroEmpleado == NoEmpleado).FirstOrDefault();

            txtNombre.Text = profesor.Nombre;
            txtPaterno.Text = profesor.ApellidoPaterno;
            txtMaterno.Text = profesor.ApellidoMaterno;
            dtpNacimiento.Value = profesor.FechaNacimiento.Value;
            tcbGenero.Text = profesor.Genero;
            txtEdad.Text = profesor.Edad.ToString(); ;
            txtDirrecion.Text = profesor.Dirección;
            txtNoDodecente.Text = profesor.NumeroEmpleado;
            txtTelefono.Text = profesor.Teléfono;
            txtCorreo.Text = profesor.Correo;
            pbFoto.ImageLocation = profesor.Foto;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
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
            db.Entry(profesor).State = EntityState.Modified;
            db.SaveChanges();
            new Funciones.ImgUpdate(ruta).GuardarImg();
            MessageBox.Show("Profesor registrado satisfactoriamente");
        }
    }
}
