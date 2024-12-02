using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSchool.Empresa
{
    public partial class NuevaEmpresa : Form
    {
        AdminschoolEntities db = new AdminschoolEntities();

        string ruta = "";

        public NuevaEmpresa()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var escuela = db.escuela.Where(x => x.Id == 1).FirstOrDefault();
            
            escuela.Id = 1;
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
            escuela.Correo = txtCorreo.Text;
            
            db.Entry(escuela).State = EntityState.Modified;
            db.SaveChanges();
            
            new Funciones.ImgUpdate(ruta).GuardarImg();

            if (MessageBox.Show("Modificación realizada con exito", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Archivo de imagen | *.jpg; *.png";
            
            if (img.ShowDialog() == DialogResult.OK)
            {
                ruta = img.FileName;
                txtLogo.Text = ruta.ToString();
            }
        }
    }
}
