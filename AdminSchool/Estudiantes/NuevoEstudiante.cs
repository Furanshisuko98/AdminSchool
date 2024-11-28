using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSchool.Estudiantes
{
    public partial class NuevoEstudiante : Form
    {
        public NuevoEstudiante()
        {
            InitializeComponent();
        }

        private void NuevoEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Img = new OpenFileDialog();
            Img.Filter = "Archivo de imagen | *jpg; *png";
            Img.ShowDialog();
        }
    }
}
