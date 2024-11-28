
namespace AdminSchool
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeLaEscuelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEstudianteToolStripMenuItem,
            this.listaDeEstudiantesToolStripMenuItem});
            this.estudiantesToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.leer;
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            // 
            // nuevoEstudianteToolStripMenuItem
            // 
            this.nuevoEstudianteToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.agregar_usuario1;
            this.nuevoEstudianteToolStripMenuItem.Name = "nuevoEstudianteToolStripMenuItem";
            this.nuevoEstudianteToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.nuevoEstudianteToolStripMenuItem.Text = "Nuevo estudiante";
            this.nuevoEstudianteToolStripMenuItem.Click += new System.EventHandler(this.nuevoEstudianteToolStripMenuItem_Click);
            // 
            // listaDeEstudiantesToolStripMenuItem
            // 
            this.listaDeEstudiantesToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.aprendiendo;
            this.listaDeEstudiantesToolStripMenuItem.Name = "listaDeEstudiantesToolStripMenuItem";
            this.listaDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.listaDeEstudiantesToolStripMenuItem.Text = "Lista de estudiantes";
            this.listaDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.listaDeEstudiantesToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProfesorToolStripMenuItem,
            this.listaDeProfesoresToolStripMenuItem});
            this.profesoresToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.ensenar;
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // nuevoProfesorToolStripMenuItem
            // 
            this.nuevoProfesorToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.agregar_usuario;
            this.nuevoProfesorToolStripMenuItem.Name = "nuevoProfesorToolStripMenuItem";
            this.nuevoProfesorToolStripMenuItem.Size = new System.Drawing.Size(227, 38);
            this.nuevoProfesorToolStripMenuItem.Text = "Nuevo profesor";
            this.nuevoProfesorToolStripMenuItem.Click += new System.EventHandler(this.nuevoProfesorToolStripMenuItem_Click);
            // 
            // listaDeProfesoresToolStripMenuItem
            // 
            this.listaDeProfesoresToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.aprendiendo1;
            this.listaDeProfesoresToolStripMenuItem.Name = "listaDeProfesoresToolStripMenuItem";
            this.listaDeProfesoresToolStripMenuItem.Size = new System.Drawing.Size(227, 38);
            this.listaDeProfesoresToolStripMenuItem.Text = "Lista de profesores";
            this.listaDeProfesoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeProfesoresToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoGrupoToolStripMenuItem,
            this.listaDeGruposToolStripMenuItem});
            this.materiasToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.educacion_en_el_hogar;
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(105, 36);
            this.materiasToolStripMenuItem.Text = "Grupos";
            // 
            // nuevoGrupoToolStripMenuItem
            // 
            this.nuevoGrupoToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.anadir;
            this.nuevoGrupoToolStripMenuItem.Name = "nuevoGrupoToolStripMenuItem";
            this.nuevoGrupoToolStripMenuItem.Size = new System.Drawing.Size(202, 38);
            this.nuevoGrupoToolStripMenuItem.Text = "Nuevo grupo";
            this.nuevoGrupoToolStripMenuItem.Click += new System.EventHandler(this.nuevoGrupoToolStripMenuItem_Click);
            // 
            // listaDeGruposToolStripMenuItem
            // 
            this.listaDeGruposToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.equipo;
            this.listaDeGruposToolStripMenuItem.Name = "listaDeGruposToolStripMenuItem";
            this.listaDeGruposToolStripMenuItem.Size = new System.Drawing.Size(202, 38);
            this.listaDeGruposToolStripMenuItem.Text = "Lista de grupos";
            this.listaDeGruposToolStripMenuItem.Click += new System.EventHandler(this.listaDeGruposToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeLaEscuelaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem1});
            this.administracionToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.ajustes;
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(159, 36);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // datosDeLaEscuelaToolStripMenuItem
            // 
            this.datosDeLaEscuelaToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.instalaciones;
            this.datosDeLaEscuelaToolStripMenuItem.Name = "datosDeLaEscuelaToolStripMenuItem";
            this.datosDeLaEscuelaToolStripMenuItem.Size = new System.Drawing.Size(228, 38);
            this.datosDeLaEscuelaToolStripMenuItem.Text = "Datos de la escuela";
            this.datosDeLaEscuelaToolStripMenuItem.Click += new System.EventHandler(this.datosDeLaEscuelaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.empleados;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(228, 38);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = global::AdminSchool.Properties.Resources.soporte_en_linea;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(228, 38);
            this.cerrarSesiónToolStripMenuItem.Text = "Soporte remoto";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem1
            // 
            this.cerrarSesiónToolStripMenuItem1.Image = global::AdminSchool.Properties.Resources.salida;
            this.cerrarSesiónToolStripMenuItem1.Name = "cerrarSesiónToolStripMenuItem1";
            this.cerrarSesiónToolStripMenuItem1.Size = new System.Drawing.Size(228, 38);
            this.cerrarSesiónToolStripMenuItem1.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "AdminSchool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeGruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeLaEscuelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

