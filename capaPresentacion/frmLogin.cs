using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            LblHora.Text = DateTime.Now.ToString();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            DataTable Datos = capaNegocio.NTrabajador.Login(this.txtUsuario.Text, this.txtPassword.Text);

            //Evaluar si existe el usuario

            if(Datos.Rows.Count == 0)
            {
                MessageBox.Show("No tiene Acceso al Sistema de Ventas","Sistema de Ventas", MessageBoxButtons.OK , MessageBoxIcon.Error);

            }
            else
            {
                frmPrincipal frm = new frmPrincipal();
                frm.Idtrabajador = Datos.Rows[0][0].ToString();
                frm.Apellidos = Datos.Rows[0][1].ToString();
                frm.Nombre = Datos.Rows[0][2].ToString();
                frm.Acceso = Datos.Rows[0][3].ToString();

                frm.Show();
                this.Hide();

            }



        }
    }
}
