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
    public partial class ListEstudiantes : Form
    {
        public ListEstudiantes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new Estudiantes.NuevoEstudiante().ShowDialog();
        }
    }
}
