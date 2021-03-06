﻿using Capa_Controlador.Controlador_Capacitación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Vista_Mantenimientos.Puesto
{
    public partial class frmMantenimientoCurso : Form
    {
        string UsuarioAplicacion;
        static Form FormularioPadre;

        clsControladorCapacitacion Cont = new clsControladorCapacitacion();

        public frmMantenimientoCurso(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            NavegadorPuesto.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            funcLlenarHorario();
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }
        public void funcLlenarHorario()
        {
            //Obetener Valores Para ComboBox
            DataTable Datos = Cont.funcItemsEmp();
            cmbEmp.DataSource = Datos;
            cmbCodEmp.DataSource = Datos;
            cmbEmp.DisplayMember = "nombre1_empleado";
            cmbCodEmp.DisplayMember = "pk_id_empleado";
            cmbEmp.ResetText();
            cmbCodEmp.ResetText();
        }

        private void NavegadorPuesto_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //el numero de aplicacion se debe cambiar por el numero asignado en la base de datos 
            NavegadorPuesto.aplicacion = 1;
            //banco se debe cambiar por la tabla a la que se quiere hacer el mantenimiento
            NavegadorPuesto.tbl = "curso";
            //estado_banco se debe cambiar por el estado de la tabla a la que se desea hacer mantenimiento
            NavegadorPuesto.campoEstado = "estado_curso";
            NavegadorPuesto.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if ((C.Tag != null) && (!C.Tag.ToString().Equals("")))
                {
                    if (C is TextBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is ComboBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is DateTimePicker)
                    {
                        lista.Add(C);
                    }
                }
            }
            NavegadorPuesto.control = lista;
            NavegadorPuesto.formulario = this;
            //el dataGridView1 se debe cambiar por el que se tiene en el formulario
            NavegadorPuesto.DatosActualizar = dgvCurso;
            NavegadorPuesto.procActualizarData();
            NavegadorPuesto.procCargar();
            //en la variable ayuda ruta debe colocar la carpeta y el archivo.chm de su proyecto de ayuda
            NavegadorPuesto.ayudaRuta = "Ayudas_HRM/Ayudas_Modulo_HRM.chm";
            //en ruta debe colocar la pagina html que quiere que se muestre cuendo se presione el boton ayuda
            NavegadorPuesto.ruta = "pg_0012.htm";
        }

        private void rbtnActivo_CheckedChanged(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (rbtnActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void rbtnInactivo_CheckedChanged(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (rbtnInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (txtEstado.Text == "")
            {
                rbtnActivo.Checked = false;
                rbtnInactivo.Checked = false;
            }
            if (txtEstado.Text == "1")
            {
                rbtnActivo.Checked = true;
            }
        }
    }
}
