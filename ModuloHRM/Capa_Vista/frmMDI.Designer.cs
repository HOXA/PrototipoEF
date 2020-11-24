namespace Capa_Vista
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mspMDI = new System.Windows.Forms.MenuStrip();
            this.tsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCapacitacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimientosDeCapacitaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimientosDeCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCapacitacionProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngresarNuevaCapacitacionProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngresoDeCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCapacitacionReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.mspMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMDI
            // 
            this.mspMDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(74)))), ((int)(((byte)(181)))));
            this.mspMDI.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mspMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInicio,
            this.tsmiMantenimientos,
            this.tsmiProcesos,
            this.tsmiHerramientas,
            this.tsmiReportes,
            this.tsmiAyuda});
            this.mspMDI.Location = new System.Drawing.Point(0, 0);
            this.mspMDI.Name = "mspMDI";
            this.mspMDI.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mspMDI.Size = new System.Drawing.Size(731, 24);
            this.mspMDI.TabIndex = 0;
            // 
            // tsmiInicio
            // 
            this.tsmiInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCerrarSesion});
            this.tsmiInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiInicio.Name = "tsmiInicio";
            this.tsmiInicio.Size = new System.Drawing.Size(48, 20);
            this.tsmiInicio.Text = "Inicio";
            this.tsmiInicio.ToolTipText = "Opciones de Sesión";
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(150, 22);
            this.tsmiCerrarSesion.Text = "Cerrar Sesión";
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
            // 
            // tsmiMantenimientos
            // 
            this.tsmiMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCapacitacion});
            this.tsmiMantenimientos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiMantenimientos.Name = "tsmiMantenimientos";
            this.tsmiMantenimientos.Size = new System.Drawing.Size(108, 20);
            this.tsmiMantenimientos.Text = "Mantenimientos";
            this.tsmiMantenimientos.ToolTipText = "Mantenimientos del Módulo";
            // 
            // tsmiCapacitacion
            // 
            this.tsmiCapacitacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMantenimientosDeCapacitaciones,
            this.tsmiMantenimientosDeCursos});
            this.tsmiCapacitacion.Name = "tsmiCapacitacion";
            this.tsmiCapacitacion.Size = new System.Drawing.Size(180, 22);
            this.tsmiCapacitacion.Text = "Capacitación";
            // 
            // tsmiMantenimientosDeCapacitaciones
            // 
            this.tsmiMantenimientosDeCapacitaciones.Name = "tsmiMantenimientosDeCapacitaciones";
            this.tsmiMantenimientosDeCapacitaciones.Size = new System.Drawing.Size(268, 22);
            this.tsmiMantenimientosDeCapacitaciones.Text = "Mantenimientos de Capacitaciones";
            this.tsmiMantenimientosDeCapacitaciones.Click += new System.EventHandler(this.tsmiMantenimientosDeCapacitaciones_Click);
            // 
            // tsmiMantenimientosDeCursos
            // 
            this.tsmiMantenimientosDeCursos.Name = "tsmiMantenimientosDeCursos";
            this.tsmiMantenimientosDeCursos.Size = new System.Drawing.Size(268, 22);
            this.tsmiMantenimientosDeCursos.Text = "Mantenimientos de Cursos";
            this.tsmiMantenimientosDeCursos.Click += new System.EventHandler(this.tsmiMantenimientosDeCursos_Click);
            // 
            // tsmiProcesos
            // 
            this.tsmiProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCapacitacionProceso});
            this.tsmiProcesos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiProcesos.Name = "tsmiProcesos";
            this.tsmiProcesos.Size = new System.Drawing.Size(70, 20);
            this.tsmiProcesos.Text = "Procesos";
            // 
            // tsmiCapacitacionProceso
            // 
            this.tsmiCapacitacionProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIngresarNuevaCapacitacionProceso,
            this.tsmiIngresoDeCursos});
            this.tsmiCapacitacionProceso.Name = "tsmiCapacitacionProceso";
            this.tsmiCapacitacionProceso.Size = new System.Drawing.Size(180, 22);
            this.tsmiCapacitacionProceso.Text = "Capacitación";
            // 
            // tsmiIngresarNuevaCapacitacionProceso
            // 
            this.tsmiIngresarNuevaCapacitacionProceso.Name = "tsmiIngresarNuevaCapacitacionProceso";
            this.tsmiIngresarNuevaCapacitacionProceso.Size = new System.Drawing.Size(234, 22);
            this.tsmiIngresarNuevaCapacitacionProceso.Text = "Ingresar Nueva Capacitación";
            this.tsmiIngresarNuevaCapacitacionProceso.Click += new System.EventHandler(this.tsmiIngresarNuevaCapacitacionProceso_Click);
            // 
            // tsmiIngresoDeCursos
            // 
            this.tsmiIngresoDeCursos.Name = "tsmiIngresoDeCursos";
            this.tsmiIngresoDeCursos.Size = new System.Drawing.Size(234, 22);
            this.tsmiIngresoDeCursos.Text = "Ingreso de Cursos";
            this.tsmiIngresoDeCursos.Click += new System.EventHandler(this.tsmiIngresoDeCursos_Click);
            // 
            // tsmiHerramientas
            // 
            this.tsmiHerramientas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiHerramientas.Name = "tsmiHerramientas";
            this.tsmiHerramientas.Size = new System.Drawing.Size(94, 20);
            this.tsmiHerramientas.Text = "Herramientas";
            // 
            // tsmiReportes
            // 
            this.tsmiReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCapacitacionReporte});
            this.tsmiReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiReportes.Name = "tsmiReportes";
            this.tsmiReportes.Size = new System.Drawing.Size(70, 20);
            this.tsmiReportes.Text = "Reportes";
            // 
            // tsmiCapacitacionReporte
            // 
            this.tsmiCapacitacionReporte.Name = "tsmiCapacitacionReporte";
            this.tsmiCapacitacionReporte.Size = new System.Drawing.Size(180, 22);
            this.tsmiCapacitacionReporte.Text = "Capacitación";
            this.tsmiCapacitacionReporte.Click += new System.EventHandler(this.tsmiCapacitacionReporte_Click);
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(55, 20);
            this.tsmiAyuda.Text = "Ayuda";
            this.tsmiAyuda.Click += new System.EventHandler(this.tsmiAyuda_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(0, 410);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(731, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 24);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(731, 406);
            this.pnlContenedor.TabIndex = 1;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 430);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.mspMDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspMDI;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0901-17-17587 Raul Alexander Sandoval Estrada ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.mspMDI.ResumeLayout(false);
            this.mspMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMDI;
        private System.Windows.Forms.ToolStripMenuItem tsmiInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcesos;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmiHerramientas;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmiCapacitacionProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiCapacitacionReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresarNuevaCapacitacionProceso;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiCapacitacion;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientosDeCapacitaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientosDeCursos;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresoDeCursos;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}