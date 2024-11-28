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

namespace AdminSchool.Empresa
{
    public partial class DatosEmpresa : Form
    {
        AdminschoolEntities db = new AdminschoolEntities();

        string ruta = "";
        public DatosEmpresa()
        {
            InitializeComponent();
            bool existeEscuela = db.escuela.Any();

            if (existeEscuela)
            {
                btnRegistrar.Text = "Modificar";
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            escuela escuela = new escuela();

            bool existeEscuela = db.escuela.Any();
            if (!existeEscuela)
            {
                escuela.Nombre = txtNombre.Text;
                escuela.CodigoPostal = txtCP.Text;
                escuela.Calle = txtCalle.Text;
                escuela.NoExt = Convert.ToInt32(txtNoExt.Text);
                escuela.NoInt = Convert.ToInt32(txtNoInt.Text);
                escuela.Colonia = txtColonia.Text;
                escuela.Ciudad = txtCiudad.Text;
                escuela.Municipio = txtMunicipio.Text;
                escuela.Estado = txtEstado.Text;
                escuela.Pais = txtPais.Text;
                escuela.Logo = Path.GetFileName(ruta);

                db.escuela.Add(escuela);
                db.SaveChanges();
                MessageBox.Show("Escuela registrada correctamente");
                new Funciones.ImgUpdate(ruta).GuardarImg();
            }

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Archivo de imagen | *.jpg; *.png";
            if(img.ShowDialog() == DialogResult.OK)
            {
                ruta = img.FileName;
                txtLogo.Text = ruta.ToString();
            }
        }
    }
}