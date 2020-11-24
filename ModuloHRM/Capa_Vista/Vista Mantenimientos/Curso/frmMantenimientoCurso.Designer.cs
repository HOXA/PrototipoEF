namespace Capa_Vista.Vista_Mantenimientos.Puesto
{
    partial class frmMantenimientoCurso
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
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.NavegadorPuesto = new CapaVistaNavegador.Navegador();
            this.lblEstadoPuesto = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblIDepa = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbCodEmp = new System.Windows.Forms.ComboBox();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCurso
            // 
            this.dgvCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(351, 114);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.RowHeadersWidth = 51;
            this.dgvCurso.Size = new System.Drawing.Size(716, 287);
            this.dgvCurso.TabIndex = 10;
            // 
            // NavegadorPuesto
            // 
            this.NavegadorPuesto.BackColor = System.Drawing.Color.Transparent;
            this.NavegadorPuesto.Location = new System.Drawing.Point(12, 5);
            this.NavegadorPuesto.Name = "NavegadorPuesto";
            this.NavegadorPuesto.Size = new System.Drawing.Size(1059, 105);
            this.NavegadorPuesto.TabIndex = 11;
            this.NavegadorPuesto.Load += new System.EventHandler(this.NavegadorPuesto_Load);
            // 
            // lblEstadoPuesto
            // 
            this.lblEstadoPuesto.AutoSize = true;
            this.lblEstadoPuesto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPuesto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstadoPuesto.Location = new System.Drawing.Point(34, 351);
            this.lblEstadoPuesto.Name = "lblEstadoPuesto";
            this.lblEstadoPuesto.Size = new System.Drawing.Size(115, 15);
            this.lblEstadoPuesto.TabIndex = 20;
            this.lblEstadoPuesto.Text = "Estado del Curso";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHorario.Location = new System.Drawing.Point(34, 233);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(72, 15);
            this.lblHorario.TabIndex = 16;
            this.lblHorario.Text = "Empleado";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalario.Location = new System.Drawing.Point(36, 275);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(61, 15);
            this.lblSalario.TabIndex = 14;
            this.lblSalario.Text = "Detalles";
            // 
            // lblIDepa
            // 
            this.lblIDepa.AutoSize = true;
            this.lblIDepa.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDepa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIDepa.Location = new System.Drawing.Point(34, 135);
            this.lblIDepa.Name = "lblIDepa";
            this.lblIDepa.Size = new System.Drawing.Size(63, 15);
            this.lblIDepa.TabIndex = 18;
            this.lblIDepa.Text = "ID Curso";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(34, 182);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 15);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre del Curso";
            // 
            // cmbCodEmp
            // 
            this.cmbCodEmp.FormattingEnabled = true;
            this.cmbCodEmp.Location = new System.Drawing.Point(252, 251);
            this.cmbCodEmp.Name = "cmbCodEmp";
            this.cmbCodEmp.Size = new System.Drawing.Size(57, 21);
            this.cmbCodEmp.TabIndex = 24;
            this.cmbCodEmp.Tag = "fk_id_empleado_curso";
            this.cmbCodEmp.Visible = false;
            // 
            // cmbEmp
            // 
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(37, 251);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(209, 21);
            this.cmbEmp.TabIndex = 26;
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnActivo.Location = new System.Drawing.Point(89, 369);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(65, 19);
            this.rbtnActivo.TabIndex = 27;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            this.rbtnActivo.CheckedChanged += new System.EventHandler(this.rbtnActivo_CheckedChanged);
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnInactivo.Location = new System.Drawing.Point(175, 369);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(77, 19);
            this.rbtnInactivo.TabIndex = 28;
            this.rbtnInactivo.TabStop = true;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            this.rbtnInactivo.CheckedChanged += new System.EventHandler(this.rbtnInactivo_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.Tag = "pk_id_curso";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.Tag = "nombre_curso";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 293);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 55);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Tag = "detalle_curso";
            this.richTextBox1.Text = "";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(262, 369);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(47, 20);
            this.txtEstado.TabIndex = 33;
            this.txtEstado.Tag = "estado_curso";
            this.txtEstado.Visible = false;
            // 
            // frmMantenimientoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1079, 413);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.cmbCodEmp);
            this.Controls.Add(this.lblEstadoPuesto);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblIDepa);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.NavegadorPuesto);
            this.Controls.Add(this.dgvCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantenimientoCurso";
            this.Text = "Mantenimiento Curso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCurso;
        private CapaVistaNavegador.Navegador NavegadorPuesto;
        private System.Windows.Forms.Label lblEstadoPuesto;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblIDepa;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbCodEmp;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtEstado;
    }
}