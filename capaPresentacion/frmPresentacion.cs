﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaNegocio;


namespace capaPresentacion
{
    public partial class frmPresentacion : Form
    {
        private bool isNuevo = false;

        private bool isEditar = false;



        public frmPresentacion()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el Nombre de la Presentación");

        }

        //Mostrar Mensaje de Confirmación

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario

        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtIdpresentacion.Text = string.Empty;


        }

        //Habilitar los controles del formulario

        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtIdpresentacion.ReadOnly = !valor;
        }

        //Habilitar los botones

        private void Botones()
        {
            if (this.isNuevo || this.isEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;

            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;


        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NPresentacion.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNombre

        private void BuscarNombre()
        {
            this.dataListado.DataSource = NPresentacion.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }



        private void FrmPresentacion_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.isNuevo = true;
            this.isEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                string rpta = "";
                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese un Nombre");

                }
                else
                {
                    if (this.isNuevo)
                    {
                        rpta = NPresentacion.Insertar(this.txtNombre.Text.Trim().ToUpper(), this.txtDescripcion.Text.Trim());



                    }
                    else
                    {
                        rpta = NPresentacion.Editar(Convert.ToInt32(this.txtIdpresentacion.Text),
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim());
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.isNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOK("Se Actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.isNuevo = false;
                    this.isEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdpresentacion.Text.Equals(""))
            {
                this.isEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.isNuevo = false;
            this.isEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NPresentacion.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Mostrar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void ChkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;

            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);


            }
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdpresentacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpresentacion"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);

            this.tabControl1.SelectedIndex = 1;
        }
    }
}
