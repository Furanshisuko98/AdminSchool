﻿using System;
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

namespace AdminSchool.Empresa
{
    public partial class DatosEmpresa : Form
    {
        AdminschoolEntities db = new AdminschoolEntities();

        string ruta = "";
        public DatosEmpresa()
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
            if(MessageBox.Show("Modificación realizada con exito", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
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

        private void DatosEmpresa_Load(object sender, EventArgs e)
        {
                escuela escuela = db.escuela.Where(x => x.Id == 1).FirstOrDefault();
                txtNombre.Text = escuela.Nombre;
                txtCP.Text = escuela.CodigoPostal;
                txtCalle.Text = escuela.Calle;
                txtNoExt.Text = escuela.NoExt.ToString();
                txtNoInt.Text = escuela.NoInt.ToString();
                txtColonia.Text = escuela.Colonia;
                txtCiudad.Text = escuela.Ciudad;
                txtMunicipio.Text = escuela.Estado;
                txtEstado.Text = escuela.Estado;
                txtPais.Text = escuela.Pais;
                txtCorreo.Text = escuela.Correo;
                txtLogo.Text = escuela.Logo;
            
        }
    }
}